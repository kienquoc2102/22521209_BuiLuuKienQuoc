using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_03
{
    public enum DataIdentifier
    {
        Login,
        Logout,
        Message,
        File,
        Private,
        Null
    }

    public class Packet
    {
        private DataIdentifier identifier;
        private string username;
        private string message;

        public DataIdentifier ChatDataIdentifier
        {
            get { return identifier; }
            set { identifier = value; }
        }

        public string ChatName
        {
            get { return username; }
            set { username = value; }
        }

        public string ChatMessage
        {
            get { return message; }
            set { message = value; }
        }

        public Packet()
        {
            this.identifier = DataIdentifier.Null;
            this.username = "";
            this.message = "";
        }

        public Packet(byte[] data)
        {
            this.identifier = (DataIdentifier)BitConverter.ToInt64(data, 0);
            int username_length = (int)BitConverter.ToInt64(data, 4);
            int message_length = (int)BitConverter.ToInt64(data, 8);

            if (username_length > 0)
                this.username = Encoding.UTF8.GetString(data, 12, username_length);
            else
                this.username = "";

            if (message_length > 0)
                this.message = Encoding.UTF8.GetString(data, 12 + username_length, message_length + 12);
            else
                this.message = "";
        }

        public byte[] GetDataStream()
        {
            List<byte> data = new List<byte>();

            data.AddRange(BitConverter.GetBytes((int)this.identifier));

            if (this.username != "")
                data.AddRange(BitConverter.GetBytes(this.username.Length));
            else
                data.AddRange(BitConverter.GetBytes(0));

            if (this.message != "")
                data.AddRange(BitConverter.GetBytes(this.username.Length));
            else
                data.AddRange(BitConverter.GetBytes(0));

            if (this.username != "")
                data.AddRange(Encoding.UTF8.GetBytes(this.username));

            if (this.message != "")
                data.AddRange(Encoding.UTF8.GetBytes(this.message));

            return data.ToArray(); 
        }
    }
}
