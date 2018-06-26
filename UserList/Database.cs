using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserList.Mvp.Models;

namespace UserList
{
    internal static class Database
    {
        private static IList<User> membersList = new List<User>();

        static public bool UserSearch(User user)
        {
            foreach (User item in membersList)
            {
                return user.Username.Equals(item.Username) && user.Password.Equals(item.Password);
            }
            return false;
        }

        static public void AddUser(User user)
        {
            membersList.Add(user);
        }

        static public void DeleteUser(string username)
        {
            for (int i=0;i<membersList.Count;i++)
            {
                if(membersList[i].Username==username)
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
    }
}