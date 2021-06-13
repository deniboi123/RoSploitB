using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WeAreDevs_API;
using System.IO;
using System.Security.Cryptography;
using System.Net.Http;
using System.Net;
using System.Diagnostics;

namespace RoSploit
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        ExploitAPI api = new ExploitAPI();

        public Form1()
        {
            InitializeComponent();
            this.panel1.MouseDown += Form1_MouseDown1;
        }

        private void Form1_MouseDown1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private void panel1_Click(object sender,  EventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

   
        private void button1_Click(object sender, EventArgs e)
        {
            api.SendLuaScript(fastColoredTextBox1.Text);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            var name = openFileDialog1.FileName;

            var read = File.ReadAllText(@name);
            fastColoredTextBox1.Text = read;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            var name = saveFileDialog1.FileName;

            File.WriteAllText(@name, fastColoredTextBox1.Text);
        }

        

      

      
   

        private void button_Click(object sender, EventArgs e)
        {
            Process[] pname = Process.GetProcessesByName("RobloxPlayerBeta");
            if (pname.Length == 0)
            {
                Form2 myNewForm = new Form2();

                myNewForm.Show();
            }
            else
            {

                foreach (var process in Process.GetProcessesByName("RobloxPlayerBeta"))
                {
                    process.Kill();
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            api.LaunchExploit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            api.SendLuaScript(fastColoredTextBox1.Text);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://wearedevs.net");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
