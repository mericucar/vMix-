using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vMixStatusGetter
{
    /// <summary>
    /// This application is made by Meriç Uçar, 500801785, IC103
    /// </summary>
    public partial class vMixStatus : Form
    {
        //Defining the initial variables needed
        vMixConnector currentvMixConnector;
        NetworkStream netStream;
        String command;

        public vMixStatus()
        {
            //Initialize main form components
            InitializeComponent();

            //Initialize the vMixConnector object
            currentvMixConnector = new vMixConnector();

            //Get the network stream using localhost to connect to vMix
            netStream = currentvMixConnector.GetvMixNetworkStream("localhost");

            //Send first command, which will be ignored as it always sends the version
            command = "TALLY";
            SetStatus();

            //Send second command which will correctly fetch the status
            command = "TALLY";
            SetStatus();

            //start the timer to make the updating automated every 500 m/s
            timer1.Start();
        }

        private void SetStatus()
        {
            //Get the status from the stream
            string streamedStatus = currentvMixConnector.FetchStatus(netStream, command);

            //check if stream is not empty, then proceed to the data parsing
            if (streamedStatus != "")
            {
                //Split the status to get the main data
                string[] statusString = streamedStatus.Split();

                //divide the main data to each camera status (to array)
                char[] statusChar = statusString[0].ToCharArray();

                //initialize the camera status values
                previewCamera.Text = "None";
                liveCamera.Text = "None";

                //if 2 = Preview, 1 = Live, 0 = Off (stay as None)
                if (statusChar[0] == '2')
                {
                    previewCamera.Text = "Camera 1";
                }
                else if (statusChar[0] == '1')
                {
                    liveCamera.Text = "Camera 1";
                }

                if (statusChar[1] == '2')
                {
                    previewCamera.Text = "Camera 2";
                }
                else if (statusChar[1] == '1')
                {
                    liveCamera.Text = "Camera 2";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Get status every 500 m/s
            SetStatus();
        }
    }
}
