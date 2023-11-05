using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Open.Nat;
using static System.Resources.ResXFileRef;

namespace server_manager
{
    // Token: 0x02000002 RID: 2
    public partial class Form1 : MetroForm
    {
        // Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
        public Form1()
        {
            this.InitializeComponent();
        }

        // Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Start();
            try
            {


                string hostname = Dns.GetHostName();

                IPAddress[] adrList = Dns.GetHostAddresses(hostname);
                foreach (IPAddress address in adrList)
                {
                    label8.Text = address.ToString();

                }
                metroButton2.Enabled = true;
            }
            catch
            {

                label8.Text = "取得できませんでした";

            }








            try
            {


                string externalIpString = new WebClient().DownloadString("https://ipinfo.io/ip");
                var externalIp = IPAddress.Parse(externalIpString);

                wnip.Text = externalIp.ToString();
                metroButton1.Enabled = true;

            }
            catch
            {
                wnip.Text = "取得できませんでした";

            }
            new Task(() =>
            {

                UPnPControlPoint p = new UPnPControlPoint();


                var result = p.GetExternalIPAddress();


                this.Invoke((MethodInvoker)delegate ()
                {

                    if (result == null)
                    {
                        metroProgressSpinner1.Visible = false;
                        label7.Text = "利用不可能";
                        this.label7.ForeColor = Color.Red;
                        label9.Visible = true;
                        metroPanel2.Enabled = false;
                        panel2.Enabled = false;
                    }
                    else
                    {
                        metroProgressSpinner1.Visible = false;
                        label7.Text = "利用可能";

                        this.label7.ForeColor = Color.LimeGreen;
                    }


                });
            }).Start();











            this.timer1.Start();
            textBox1.Text = label8.Text;
        }

        // Token: 0x06000003 RID: 3 RVA: 0x00002078 File Offset: 0x00000278
        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        // Token: 0x06000004 RID: 4 RVA: 0x000020B8 File Offset: 0x000002B8
        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        // Token: 0x06000005 RID: 5 RVA: 0x000020D8 File Offset: 0x000002D8
        private void metroTabPage2_Click(object sender, EventArgs e)
        {
        }

        // Token: 0x06000006 RID: 6 RVA: 0x000020DB File Offset: 0x000002DB
        private void button1_Click(object sender, EventArgs e)
        {
        }

        // Token: 0x06000007 RID: 7 RVA: 0x000020E0 File Offset: 0x000002E0
        private void timer1_Tick(object sender, EventArgs e)
        {

















































            this.label1.ForeColor = Color.LimeGreen;
            this.label1.Text = "使用可能";
            int num = 80;
            IPGlobalProperties ipglobalProperties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] activeTcpListeners = ipglobalProperties.GetActiveTcpListeners();
            foreach (IPEndPoint ipendPoint in activeTcpListeners)
            {
                bool flag = ipendPoint.Port == num;
                if (flag)
                {
                    this.label1.ForeColor = Color.Goldenrod;
                    this.label1.Text = "使用中";
                }
            }
            this.label3.ForeColor = Color.LimeGreen;
            this.label3.Text = "使用可能";
            int num2 = 443;
            IPGlobalProperties ipglobalProperties2 = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] activeTcpListeners2 = ipglobalProperties.GetActiveTcpListeners();
            foreach (IPEndPoint ipendPoint2 in activeTcpListeners)
            {
                bool flag2 = ipendPoint2.Port == num2;
                if (flag2)
                {
                    this.label3.ForeColor = Color.Goldenrod;
                    this.label3.Text = "使用中";
                }
            }
            this.label2.ForeColor = Color.LimeGreen;
            this.label2.Text = "使用可能";
            int num3 = 25565;
            IPGlobalProperties ipglobalProperties3 = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] activeTcpListeners3 = ipglobalProperties.GetActiveTcpListeners();
            foreach (IPEndPoint ipendPoint3 in activeTcpListeners)
            {
                bool flag3 = ipendPoint3.Port == num3;
                if (flag3)
                {
                    this.label2.ForeColor = Color.Goldenrod;
                    this.label2.Text = "使用中";
                }
            }



































            try
            {
                this.label5.ForeColor = Color.LimeGreen;
                this.label5.Text = "使用可能";
                int num4 = (int)this.numericUpDown1.Value;
                IPGlobalProperties ipglobalProperties4 = IPGlobalProperties.GetIPGlobalProperties();
                IPEndPoint[] activeTcpListeners4 = ipglobalProperties.GetActiveTcpListeners();
                foreach (IPEndPoint ipendPoint4 in activeTcpListeners)
                {
                    bool flag4 = ipendPoint4.Port == num4;
                    if (flag4)
                    {
                        this.label5.ForeColor = Color.Goldenrod;
                        this.label5.Text = "使用中";
                    }
                }
            }
            catch
            {
            }














            this.label4.ForeColor = Color.LimeGreen;
            this.label4.Text = "使用可能";
            int numr = 3389;
            IPGlobalProperties ipglobalPropertiesr = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] activeTcpListenersr = ipglobalProperties.GetActiveTcpListeners();
            foreach (IPEndPoint ipendPointr in activeTcpListeners)
            {
                bool flagr = ipendPointr.Port == numr;
                if (flagr)
                {
                    this.label4.ForeColor = Color.Goldenrod;
                    this.label4.Text = "使用中";
                }
            }



























        }


        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(wnip.Text);
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(label8.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void cmdForward_Click(object sender, EventArgs e)
        {

        }





        private async void metroButton4_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked == false)
            {
                numericUpDown3.Value = numericUpDown2.Value;
            }
            if (metroRadioButton2.Checked == true)
            {


                metroPanel3.Enabled = false;

                var nat = new NatDiscoverer();
                var device = await nat.DiscoverDeviceAsync();
                if (device != null)
                {

                    // ポート開放
                    int externalPort = (int)numericUpDown2.Value;// 内部port
                    int internalPort = (int)numericUpDown3.Value;   // 外部port






                    try
                    {

                        await device.CreatePortMapAsync(new Mapping(Protocol.Tcp, externalPort, internalPort, "Port_Forwarding_By_Ptki_server_Manager(TCP)"));


                        MessageBox.Show("ポート解放に成功しました", "Server_Manager", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        metroPanel3.Enabled = true;



                        try
                        {
                            listBox1.Items.Add(textBox1.Text + ": " + internalPort + " (TCP)");
                        }
                        catch
                        {

                        }

                    }
                    catch
                    {
                        MessageBox.Show("ポート開放に失敗しました", "Server_Manager", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        metroPanel3.Enabled = true;
                    }
                }

            }
            if (metroRadioButton1.Checked == true)
            {
                metroPanel3.Enabled = false;
                var nat = new NatDiscoverer();
                var device = await nat.DiscoverDeviceAsync();
                if (device != null)
                {

                    // ポート開放
                    int externalPort = (int)numericUpDown2.Value;// 内部port
                    int internalPort = (int)numericUpDown3.Value;   // 外部port

                    try
                    {
                        await device.CreatePortMapAsync(new Mapping(Protocol.Udp, externalPort, internalPort, "Port_Forwarding_By_Ptki_server_Manager(UDP)"));
                        MessageBox.Show("ポート解放に成功しました", "Server_Manager", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        metroPanel3.Enabled = true;


                        try
                        {
                            listBox1.Items.Add(textBox1.Text + ": " + internalPort + " (UDP)");
                        }
                        catch
                        {

                        }



                    }
                    catch
                    {
                        MessageBox.Show("ポート開放に失敗しました", "Server_Manager", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        metroPanel3.Enabled = true;
                    }
                }
            }
        }

        private async void metroButton3_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked == false)
            {
                numericUpDown3.Value = numericUpDown2.Value;
            }
            if (metroRadioButton2.Checked == true)

                if (metroRadioButton2.Checked == true)
                {
                    metroPanel3.Enabled = false;
                    var nat = new NatDiscoverer();
                    var device = await nat.DiscoverDeviceAsync();
                    if (device != null)
                    {
                        // ポート閉鎖
                        int externalPort = (int)numericUpDown2.Value;// port
                        int internalPort = (int)numericUpDown3.Value;   // port
                        string internalClientIP = textBox1.Text; // 内部クライアントのIPアドレス

                        try
                        {
                            await device.DeletePortMapAsync(new Mapping(Protocol.Tcp, externalPort, internalPort, "Port Forwarding Example"));
                            MessageBox.Show("ポート閉鎖に成功しました", "Server_Manager", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            metroPanel3.Enabled = true;


                            try
                            {

                                listBox1.Items.Remove(textBox1.Text + ": " + internalPort + " (TCP)");
                            }
                            catch
                            {


                            }


                        }
                        catch
                        {


                            {
                                MessageBox.Show("ポート閉鎖に失敗しました", "Server_Manager", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                metroPanel3.Enabled = true;
                            }
                        }
                    }

                }
            if (metroRadioButton1.Checked == true)
            {
                metroPanel3.Enabled = false;
                var nat = new NatDiscoverer();
                var device = await nat.DiscoverDeviceAsync();
                if (device != null)
                {
                    // ポート閉鎖
                    int externalPort = (int)numericUpDown2.Value;// port
                    int internalPort = (int)numericUpDown3.Value;   // port
                    string internalClientIP = textBox1.Text; // 内部クライアントのIPアドレス
                    try
                    {
                        await device.DeletePortMapAsync(new Mapping(Protocol.Udp, externalPort, internalPort, "Port Forwarding Example"));
                        MessageBox.Show("ポート閉鎖に成功しました", "Server_Manager", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        metroPanel3.Enabled = true;
                        try
                        {
                            listBox1.Items.Remove(textBox1.Text + ": " + internalPort + " (UDP)");
                        }
                        catch
                        {

                        }
                    }
                    catch
                    {
                        MessageBox.Show("ポート閉鎖に失敗しました", "Server_Manager", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        metroPanel3.Enabled = true;
                    }
                }
            }
        }

        private void wnip_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {


        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("By Ptki_uo", "Server_Manager", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            if (minejava.Text == "このポートを開放する")
            {
                metroRadioButton2.Checked = true;
                numericUpDown2.Value = 25565;
                //	metroTabControl1.SelectedIndex = 0;
                metroButton4_Click(sender, e);
            }
            else

            {
                metroRadioButton2.Checked = true;
                numericUpDown2.Value = 25565;
                // metroTabControl1.SelectedIndex = 0;
                metroButton3_Click(sender, e);
            }
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {

        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            if (rdp.Text == "このポートを開放する")
            {
                metroRadioButton2.Checked = true;
                numericUpDown2.Value = 3389;
                //     metroTabControl1.SelectedIndex = 0;
                metroButton4_Click(sender, e);
            }
            else

            {
                metroRadioButton2.Checked = true;
                numericUpDown2.Value = 3389;
                //  metroTabControl1.SelectedIndex = 0;
                metroButton3_Click(sender, e);
            }
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            if (metroButton8.Text == "このポートを開放する")
            {
                metroRadioButton2.Checked = true;
                numericUpDown2.Value = 443;
                //   metroTabControl1.SelectedIndex = 0;
                metroButton4_Click(sender, e);
            }
            else

            {
                metroRadioButton2.Checked = true;
                numericUpDown2.Value = 443;
                //  metroTabControl1.SelectedIndex = 0;
                metroButton3_Click(sender, e);
            }
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            if (metroButton7.Text == "このポートを開放する")
            {

                metroRadioButton2.Checked = true;
                numericUpDown2.Value = 80;
                //       metroTabControl1.SelectedIndex = 0;
                metroButton4_Click(sender, e);
            }
            else

            {
                metroRadioButton2.Checked = true;
                numericUpDown2.Value = 80;
                //   metroTabControl1.SelectedIndex = 0;
                metroButton3_Click(sender, e);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (ListBox.NoMatches != listBox1.FindStringExact(textBox1.Text + ": " + 25565 + " (TCP)"))
            {
                minejava.Text = "このポートを閉鎖する";
            }
            else
            {
                minejava.Text = "このポートを開放する";
            }
            if (ListBox.NoMatches != listBox1.FindStringExact(textBox1.Text + ": " + 3389 + " (TCP)"))
            {
                rdp.Text = "このポートを閉鎖する";
            }
            else
            {
                rdp.Text = "このポートを開放する";
            }
            if (ListBox.NoMatches != listBox1.FindStringExact(textBox1.Text + ": " + 80 + " (TCP)"))
            {
                metroButton7.Text = "このポートを閉鎖する";
            }
            else
            {
                metroButton7.Text = "このポートを開放する";
            }
            if (ListBox.NoMatches != listBox1.FindStringExact(textBox1.Text + ": " + 443 + " (TCP)"))
            {
                metroButton8.Text = "このポートを閉鎖する";
            }
            else
            {
                metroButton8.Text = "このポートを開放する";
            }

        }

        private async void button2_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }



        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroCheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

                panel3.Visible = true;

            }
            else
            {


                panel3.Visible = false;

            }
        }
    }
}
