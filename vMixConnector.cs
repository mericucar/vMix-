using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace vMixStatusGetter
{
    /// <summary>
    /// This application is made by Meriç Uçar, 500801785, IC103
    /// </summary>
    public class vMixConnector
    {
        //Declaration of the TcpClient object for connection later to the vMix
        TcpClient tcpClient;

        //public constructor
        public vMixConnector()
        {
        }

        //method to get the network stream from the vMix which is where we read and write data
        public NetworkStream GetvMixNetworkStream(string address)
        {
            //Gets the last IPv4 addresses 
            IPAddress ipAddress = Array.FindLast(
                Dns.GetHostEntry(string.Empty).AddressList,
                a => a.AddressFamily == AddressFamily.InterNetwork);
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 8099);

            //creating new object for the tcp client
            tcpClient = new TcpClient();

            //Connecting to the vMix
            tcpClient.Connect(ipEndPoint);

            //Getting the stream
            NetworkStream netStream = tcpClient.GetStream();

            return netStream;
        }

        //Method to fetch the status using the network stream
        //This can be used to pass any command (e.g. TALLY)
        public string FetchStatus(NetworkStream netStream, string command)
        {
            //append the termination string to the end of the command for it to work -- "\r\n"
            command = AppendTermination(command);

            //if stream can write, get byte data of the command then write it to the stream, else return an error
            if (netStream.CanWrite)
            {
                Byte[] sendBytes = Encoding.UTF8.GetBytes(command);
                netStream.Write(sendBytes, 0, sendBytes.Length);
            }
            else
            {
                Console.WriteLine("You cannot write data to this stream.");
                tcpClient.Close();

                // Closing the tcpClient instance does not close the network stream.
                netStream.Close();
                return "";
            }

            //if stream can read, get byte data of from the stream, else return an error
            if (netStream.CanRead)
            {
                // Reads NetworkStream into a byte buffer.
                byte[] bytes = new byte[tcpClient.ReceiveBufferSize];

                // Read can return anything from 0 to numBytesToRead. 
                // This method blocks until at least one byte is read.
                netStream.Read(bytes, 0, (int)tcpClient.ReceiveBufferSize);

                // Returns the data received from the host to the console.
                string returndata = Encoding.UTF8.GetString(bytes);

                //Ignore the first read stream as it will return the version of vMix
                if (returndata.Contains("VERSION")) { returndata = ""; }
                return returndata.Replace("TALLY OK ","");

            }
            else
            {
                Console.WriteLine("You cannot read data from this stream.");
                tcpClient.Close();

                // Closing the tcpClient instance does not close the network stream.
                netStream.Close();
                return "";
            }

        }

        //Method to clean-up the command
        private string AppendTermination(string stringToClean)
        {
            stringToClean = stringToClean + @"\r\n";
            stringToClean = stringToClean.Replace(@"\r", "\r");
            stringToClean = stringToClean.Replace(@"\n", "\n");
            return stringToClean;
        }
    }
}
