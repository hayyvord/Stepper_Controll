using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.IO.Ports;

using System.Threading;

namespace Stepper_Controll
{
    public partial class StepperControl : Form
    {

        #region Varibles

        public SerialPort RobotPort;

        private bool isConnected = false;

        private string Direction = string.Empty;

        #endregion

        #region Constructor

        public StepperControl()
        {
            Thread t = new Thread(new ThreadStart(LoadScreen));
            t.Start();
            Thread.Sleep(5000);

            InitializeComponent();
            SearchForPorts();
            t.Abort();
        }

        private void LoadScreen()
        {
            Application.Run(new Load());
        }

        #endregion

        #region SearchForPorts

        private void SearchForPorts()
        {
            cbPorts.Items.Clear();

            string[] portNames = System.IO.Ports.SerialPort.GetPortNames();

            if (portNames.Length == 0)
            {
                cbPorts.Text = "No Ports";
                return;
            }

            foreach (string item in portNames)
            {
                cbPorts.Items.Add(item);
            }

            cbPorts.Text = cbPorts.Items[0].ToString();
        }

        #endregion

        #region Connect

        public void Connect(string portName)
        {
            try
            {
                if (!isConnected)
                {
                    RobotPort = new SerialPort();
                    RobotPort.PortName = portName;
                    RobotPort.BaudRate = 9600;
                    RobotPort.DataBits = 8;
                    RobotPort.StopBits = StopBits.One;
                    RobotPort.Parity = Parity.None;
                    RobotPort.Open();

                    isConnected = true;
                }

            }
            catch
            {
                isConnected = false;
                Thread.Sleep(3000);
            }
        }

        #endregion

        #region Disconnect

        public void Disconnect()
        {
            if (isConnected)
            {
                RobotPort.Close();
            }
            isConnected = false;
        }

        #endregion

        #region Reset

        public void Reset()
        {
            if (isConnected)
            {
                RobotPort.DtrEnable = true;
                Thread.Sleep(200);
                RobotPort.DtrEnable = false;
            }
        }

        #endregion

        #region SendCommands

        public void SendCommands(string Command)
        {
            try
            {
                if (isConnected)
                {
                    Console.WriteLine(string.Format("Command:{0}", Command));
                    RobotPort.WriteLine(Command);
                }
            }
            catch
            {
                isConnected = false;

            }
        }

        #endregion

        #region Buttons

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string Port = cbPorts.Text;
            this.Connect(Port);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            this.Disconnect();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                try
                {
                    // string Direction = string.Empty;

                    int Steps = Int32.Parse(tbSteps.Text);

                    if (cbDirections.Text == "CW") { Direction = "-"; };
                    if (cbDirections.Text == "CCW") { Direction = "+"; };

                    //?X+255:120\n

                    string Command = string.Format("?{0}{1}{2:D3}", cbMIndex.Text.ToString(), Direction, Steps);

                    #region Properties

                    SendCommands(Command);
                    Console.WriteLine(Command);
                    tbStatus.AppendText(string.Format("Command to Robot: {0}", Command));
                    tbStatus.AppendText(Environment.NewLine);

                    #endregion
                }

                catch (Exception excep)
                {
                    Console.WriteLine(excep);
                }

            }
        }

        private void btnRev_Click(object sender, EventArgs e)
        {
            float Degreese = float.Parse(tbDeg.Text);
            float DegPerStep = float.Parse(tbDStep.Text);

            float StepPerTurn = Degreese / DegPerStep; 

            int Rev = Int32.Parse(tbRev.Text);

            int speed = Int32.Parse(tbSpeed.Text);

            if (cbDirections.Text == "CW") { Direction = "-"; };
            if (cbDirections.Text == "CCW") { Direction = "+"; };

            int steps = 0;

            if (cbStepM.Checked)
            {
                steps = Rev * (int)StepPerTurn;
                cbStepM.Text = "FullStep";
            }

            else 
            {
                steps = (int)StepPerTurn / 2;
                cbStepM.Text = "HalfStep";
            }

            string Command = string.Format("?{0}{1}{2:D3}:{3:D3}", cbMIndex.Text.ToString(),Direction,steps,speed);
            SendCommands(Command);
            tbStatus.AppendText(Command);
            tbStatus.AppendText(Environment.NewLine);
        }

        #endregion

    }
}
