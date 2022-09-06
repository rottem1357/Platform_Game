/// <file>
/// Authors: Rotem Dresler . ID: 209207398. 
///          Izhak keidar . ID: 066016155.
///          
/// Date:    07/09/2022.
/// </file>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Platform_Game
{
    [Serializable()]
    public class User : ISerializable
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string MainColorName { get; set; }
        public int Id { get; set; }
        public int Level { get; set; }
        public int Kills { get; set; }
        public string NickName { get; set; }

        public User()
        {
            this.UserName = "";
            this.Password = "";
            this.Id = 0;
            this.MainColorName = "Blue";
            this.Level = 1;
            this.Kills = 0;
        }
        public User(SerializationInfo info, StreamingContext context)
        {
            this.UserName = (string)info.GetValue("UserName", typeof(string));
            this.Password = (string)info.GetValue("Password", typeof(string));
            this.MainColorName = (string)info.GetValue("MainColor", typeof(string));
            this.Id = (int)info.GetValue("ID", typeof(int));
            this.Kills = (int)info.GetValue("Kills", typeof(int));
            this.Level = (int)info.GetValue("Level", typeof(int));
            this.NickName = (string)info.GetValue("NickName", typeof(string));
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ID", this.Id);
            info.AddValue("UserName", this.UserName);
            info.AddValue("Password", this.Password);
            info.AddValue("MainColor", this.MainColorName);
            info.AddValue("Kills", this.Kills);
            info.AddValue("NickName", this.NickName);
            info.AddValue("level", this.Level);
        }

        public void GenerateNewId()
        {
            int temp = 1;
            foreach(User user in Users.MyUsers)
            {
                if(user.Id >= temp)
                    temp = user.Id + 1;
            }
            this.Id = temp;
        }

        public bool IsValidInput()
        {
            if (this.IsValidUserName() && this.IsValidPassowrd() && this.IsValidColor() &&
                this.IsValidNickName())
                return true;
            return false;
        }
        public bool IsValidNickName()
        {
            if (this.NickName == "")
                return false;
            return true;
        }
        public bool IsValidUserName()
        {
            if (this.UserName == "")
                return false;

            foreach (User u in Users.MyUsers)
                if (u.UserName == this.UserName)
                    return false;

            return true;
        }

        public bool IsValidPassowrd()
        {
            if (this.Password == "")
                return false;
            return true;

        }
        public bool IsValidColor()
        {
            return true;
        }

        public void UpdateProgression(int aLevel, int aKills)
        { 
            this.Level = aLevel;
            this.Kills = aKills;
        }
    }
}
