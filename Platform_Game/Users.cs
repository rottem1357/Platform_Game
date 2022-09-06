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
            try
            {
                Stream stream = File.OpenRead("User.txt");
                XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
                MyUsers = (List<User>)serializer.Deserialize(stream);
                stream.Close();
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }
            
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
        public static bool UpdateUser(int aId, int aLevel,int aKills)
        {
            foreach (User u in MyUsers)
                if (aId == u.Id)
                {
                    u.UpdateProgression(aLevel, aKills);
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Id of acount if it is exists</returns>
        public static int IsExist(string aUserName)
        { 
            foreach(User u in MyUsers)
            {
                if (u.UserName == aUserName)
                    return u.Id;
            }
            return 0;
        }
        public static string GetPasswordAtId(int aId)
        {
            foreach (User u in MyUsers)
            {
                if (u.Id == aId)
                    return u.Password;
            }
            return "";
        }
        public static string GetNickNameAtId(int aId)
        {
            foreach (User u in MyUsers)
            {
                if (u.Id == aId)
                    return u.NickName;
            }
            return "";
        }
        public static int GetLevelAtId(int aId)
        {
            foreach (User u in MyUsers)
            {
                if (u.Id == aId)
                    return u.level;
            }
            return 1;
        }
        public static int GetKillsAtId(int aId)
        {
            foreach (User u in MyUsers)
            {
                if (u.Id == aId)
                    return u.kills;
            }
            return 0;
        }
        public static System.Drawing.Color GetColorAtId(int aId)
        {
            foreach (User u in MyUsers)
            {
                if (u.Id == aId)
                    return System.Drawing.Color.FromName(u.MainColorName);
            }
            return System.Drawing.Color.Red;
        }
    }
}
