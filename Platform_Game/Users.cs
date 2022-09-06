using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.IO;

namespace Platform_Game
{
    internal class Users
    {
        public static List<User> MyUsers { get; set; }

        public Users()
        {
            MyUsers = new List<User>();
        }

        public static void UploadUsers()
        {
            Stream stream = File.OpenWrite("User.txt");
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            serializer.Serialize(stream, MyUsers);
            stream.Close();
        }

        public static void DownloadUsers()
        {
            Stream stream = File.OpenRead("User.txt");
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            MyUsers = (List<User>)serializer.Deserialize(stream);
            stream.Close();
        }

        public static bool DeleteUser(int aID)
        {
            foreach (User u in MyUsers)
                if(u.Id == aID)
                {
                    Users.MyUsers.Remove(u);
                    return true;
                }
            return false;
        }
        public static bool DeleteUser(string aUserName)
        {
            foreach (User u in MyUsers)
                if (u.UserName == aUserName)
                {
                    Users.MyUsers.Remove(u);
                    return true;
                }
            return false;
        }
        public static bool UpdateUser(User a)
        {
            foreach (User u in MyUsers)
                if (a.UserName == u.UserName)
                {
                    u.UpdateProgression(a.level, a.kills);
                    return true;
                }
            return false;                    
        }
        public static bool AddUser(User a)
        {
            if (!a.IsValidInput())
                return false;

            a.GenerateNewId();
            Users.MyUsers.Add(a);
            return true;
        }
        
    }
}
