using System.Collections.Generic;
using System.Xml;
using UserList.Mvp.Models;

namespace UserList
{
    internal static class Database
    {
        private static IList<User> membersList = new List<User>();

        static public void AddUser(User user)
        {
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
        }

        static public IEnumerable<User> ListUsers
        {
            get { return membersList; }
        }

        static public void Initialisetion()
        {
            XmlDocument xmlDocument = new XmlDocument();

            xmlDocument.Load(@"C:\Users\User\Desktop\Pasha computer\Паша\Windows Forms\Homework\UserList\UserList\Data1");
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