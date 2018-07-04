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
            // XDocument xmlDocument = new XDocument();
            //  xmlDocument.Load(@"../../Data/Users.xml");
            // for (int i = 0; i < 10; i++)
            //  {
            // if (xmlDocument.Root.Name == "users")
            // {
            // xmlDocument.Root.Add(new XElement("olea", new XAttribute("years", 23)));
            //    xmlDocument.AddAfterSelf(new XElement("olea", new XAttribute("years", 23)));
            // }
            //  }

            //   XDocument xmlDocument = new XDocument(new XDeclaration("0.1", "utf-8", "yes"), new XElement("users"));
            //  xmlDocument.Root.Add(new XElement("olea", new XAttribute("years", 23)));
            //   xmlDocument.Save(Path.Combine(Environment.CurrentDirectory, "Users.xml"));


            //  XmlDocument document = new XmlDocument();
            // if (document.== "users")
            // {
            // }
            // xmlDocument.AddAfterSelf(new XElement("olea", new XAttribute("years", 23));

            // xmlDocument.Save(Path.Combine(Environment.CurrentDirectory, " Users.xml" ));

          //  using (XmlWriter xmlWriter = XmlWriter("sdfs"))
           // {

           // }






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