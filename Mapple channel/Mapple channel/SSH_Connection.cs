using System;
using Renci.SshNet;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapple_channel
{
    class SSH_Connection
    {
        public static string user;
        public static string password;
        public static string IP;

        public string ConnectionTest(string user, string password, string host)
        {
            try
            {
                using (var client = new SshClient(host, user, password))
                {
                    //Start the connection
                    client.Connect();
                    client.Disconnect();
                    return "Connection fonctionnelle";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ON(string user, string password, string host)
        {
            try
            {
                using (var client = new SshClient(host, user, password))
                {
                    //Start the connection
                    client.Connect();
                    var output = client.RunCommand("python /home/pi/test.py");
                    client.Disconnect();
                    return "Connection fonctionnelle";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string OFF(string user, string password, string host)
        {
            try
            {
                using (var client = new SshClient(host, user, password))
                {
                    //Start the connection
                    client.Connect();
                    var output = client.RunCommand("python /home/pi/test.py");
                    client.Disconnect();
                    return "Connection fonctionnelle";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
