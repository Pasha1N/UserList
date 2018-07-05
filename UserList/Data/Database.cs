using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using UserList.Date.Mvp.Models;

namespace UserList.Date
{
    internal static class Database
    {
        private static IList<User> membersList = new List<User>();

        static public void AddUser(User user)
        {
            XmlDocument xmlDocument = new XmlDocument();
              xmlDocument.Load(@"../../Data/Users.xml");


           XmlElement xmlElement=xmlDocument.CreateElement("sfsadf");

            xmlElement.Attributes.Append(xmlDocument.CreateAttribute("name"));
            xmlDocument.AppendChild(xmlElement);
            xmlDocument.Save(Path.Combine(Environment.CurrentDirectory, " Users.xml" ));

        





            //  membersList.Add(user);
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
        }

        static public IEnumerable<User> ListUsers
        {
            get { return membersList; }
        }

        static public void Initialisetion()
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(@"../../Data/Users.xml");


            XmlElement xmlElement = xmlDocument.CreateElement("sfsadf");
            XmlNodeList nodeList = xmlDocument.DocumentElement.ChildNodes;

          if(  xmlDocument.DocumentElement.Name=="users")
            {
                xmlDocument.DocumentElement.AppendChild(xmlElement);
                xmlDocument.Save(Path.Combine(Environment.CurrentDirectory, " Users.xml"));
            }
        
        }

        static public bool UserSearch(User user)
        {
            foreach (User item in membersList)
            {
                return user.Username.Equals(item.Username) && user.Password.Equals(item.Password);
            }
            return false;
        }
    }
}