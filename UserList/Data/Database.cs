using System.Collections.Generic;
using System.Xml;
using UserList.Date.Mvp.Models;

namespace UserList.Date
{
    internal static class Database
    {
        private const string Filename = @"../../Data/Users.xml";

        private static IList<User> membersList = new List<User>();

        static public void AddUser(User user)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(Filename);

            XmlElement xmlElement = xmlDocument.CreateElement("user");
            xmlElement.SetAttribute("username", $"{user.Username}");
            xmlElement.SetAttribute("password", $"{user.Password}");

            XmlNodeList nodeList = xmlDocument.DocumentElement.ChildNodes;

            if (xmlDocument.DocumentElement.Name == "users")
            {
                xmlDocument.DocumentElement.AppendChild(xmlElement);
                xmlDocument.Save(Filename);
            }
            membersList.Add(user);
        }

        static public void DeleteUser(string username)
        {
            for (int i = 0; i < membersList.Count; i++)
            {
                if (membersList[i].Username == username)
                {
                    membersList.RemoveAt(i);
                    break;
                }
            }

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(Filename);

            if (xmlDocument.DocumentElement.Name == "users")
            {
                XmlNodeList users = xmlDocument.DocumentElement.ChildNodes;

                foreach (XmlNode item in users)
                {
                    if (item.Name == "user")
                    {
                        if (item.Attributes["username"].Value == username)
                        {
                            xmlDocument.DocumentElement.RemoveChild(item);
                            xmlDocument.Save(Filename);
                            break;
                        }
                    }
                }
            }
        }

        static public IEnumerable<User> ListUsers
        {
            get { return membersList; }
        }

        static public void Initialisetion()
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(Filename);

            if (xmlDocument.DocumentElement.Name == "users")
            {
                XmlNodeList users = xmlDocument.DocumentElement.ChildNodes;

                foreach (XmlNode item in users)
                {
                    if (item.Name == "user")
                    {
                        User user = new User(item.Attributes["username"].Value, item.Attributes["password"].Value);
                        membersList.Add(user);
                    }
                }
            }
        }

        static public bool UserSearch(User user)
        {
            bool thereIsСorrespondence = false;
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(Filename);

            if (xmlDocument.DocumentElement.Name == "users")
            {
                XmlNodeList nodeList = xmlDocument.DocumentElement.ChildNodes;

                foreach (XmlNode item in nodeList)
                {
                    if (item.Name == "user")
                    {
                        if (item.Attributes["username"].Value == user.Username &&
                            item.Attributes["password"].Value == user.Password)
                        {
                            thereIsСorrespondence = true;
                        }
                    }
                }
            }
            return thereIsСorrespondence;
        }

        static public bool UserSearch(string username)
        {
            bool thereIsСorrespondence = false;
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(Filename);

            if (xmlDocument.DocumentElement.Name == "users")
            {
                XmlNodeList nodeList = xmlDocument.DocumentElement.ChildNodes;

                foreach (XmlNode item in nodeList)
                {
                    if (item.Name == "user")
                    {
                        if (item.Attributes["username"].Value == username)
                        {
                            thereIsСorrespondence = true;
                        }
                    }
                }
            }
            return thereIsСorrespondence;
        }
    }
}