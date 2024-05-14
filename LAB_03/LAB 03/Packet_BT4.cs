using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_03
{
    public enum DataCinema
    {
        Login,
        Logout,
        Buy,
        Null
    }
    public class Packet_BT4
    {
        private DataCinema identifier;
        private string username;
        private string message;

        public DataCinema RequestDataIdentifier
        {
            get { return identifier; }
            set { identifier = value; }
        }

        public string RequestName
        {
            get { return username; }
            set { username = value; }
        }

        public string RequestMessage
        {
            get { return message; }
            set { message = value; }
        }

        public Packet_BT4()
        {
            this.identifier = DataCinema.Null;
            this.username = "";
            this.message = "";
        }

        public Packet_BT4(byte[] data)
        {
            this.identifier = (DataCinema)BitConverter.ToInt64(data, 0);
            int username_length = (int)BitConverter.ToInt64(data, 4);
            int message_length = (int)BitConverter.ToInt64(data, 8);

            if (username_length > 0)
                this.username = Encoding.UTF8.GetString(data, 12, username_length);
            else
                this.username = "";

            if (message_length > 0)
                this.message = Encoding.UTF8.GetString(data, 12 + username_length, message_length + 1000);
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
