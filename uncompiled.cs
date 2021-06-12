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

   

        private void button6_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (api.isAPIAttached())
            {
                button2.Text = "ATTACHED";
            }
            else
            {
                api.LaunchExploit();
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
    }
}
