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
                    return "Connection fonctionnelle.";
                }
            }
            catch (Exception ex)
            {
                return "Une erreur s'est produite : " + "\n" + ex.ToString();
            }
        }

        public void ConnectionSSH(string user, string password, string host)
        {
            try
            {
                using (var client = new SshClient(host, user, password))
                {
                    //Start the connection
                    client.Connect();
                    client.Disconnect();
                    ChoixGPIO gpio = new ChoixGPIO();
                    gpio.Text = "Choix du GPIO";
                    gpio.Show();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string TurnGpio23ON(string user, string password, string host, string file)
        {
            try
            {
                using (var client = new SshClient(host, user, password))
                {
                    //Start the connection
                    client.Connect();
                    var output = client.RunCommand("python /home/pi/Mapple_Channel_Scripts/" + file + ".py");
                    client.Disconnect();
                    return "Commande envoyée. Les ports sélectionnés sont maintenant ouverts.";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string TurnGpio23OFF(string user, string password, string host)
        {
            try
            {
                using (var client = new SshClient(host, user, password))
                {
                    //Start the connection
                    client.Connect();
                    var output = client.RunCommand("python /home/pi/Mapple_Channel_Scripts/Close_Mapple_Channels.py");
                    client.Disconnect();
                    return "Commande envoyée. Les ports sélectonnés sont maintenant fermés.";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string TurnGpio24ON(string user, string password, string host)
        {
            try
            {
                using (var client = new SshClient(host, user, password))
                {
                    //Start the connection
                    client.Connect();
                    var output = client.RunCommand("python /home/pi/Mapple_Channel_Scripts/Open_Mapple_Channel_GPIO24_0.py");
                    client.Disconnect();
                    return "Commande envoyée. Les ports sélectionnés sont maintenant ouverts.";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string TurnGpio24OFF(string user, string password, string host)
        {
            try
            {
                using (var client = new SshClient(host, user, password))
                {
                    //Start the connection
                    client.Connect();
                    var output = client.RunCommand("python /home/pi/Mapple_Channel_Scripts/Close_Mapple_Channel_GPIO24.py");
                    client.Disconnect();
                    return "Commande envoyée. Les ports sélectonnés sont maintenant fermés.";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
