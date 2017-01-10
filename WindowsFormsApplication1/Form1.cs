using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExactIT;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.Write("Don't click me!\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 frm = new Form2();
            frm.Show();
            System.Diagnostics.Debug.Write ("Test?\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.Write ("Test again?\n");
            label2.Text = "Your IP has Been reset.\nPlease Restart your computer.";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.Write("Clicking for Computer name.\n");
            System.Diagnostics.Debug.Write(System.Net.Dns.GetHostName());
            label2.Text = "Computer Name: " + System.Net.Dns.GetHostName();
            Refresh();
        }
    }
}
