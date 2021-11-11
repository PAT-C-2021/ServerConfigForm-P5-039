using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using ServiceMtk_P1_20190140039;

namespace ServerConfigForm_P5_20190140039
{
    public partial class Form1 : Form
    {
        private ServiceHost Host;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ON_Click(object sender, EventArgs e)
        {
            Host = new ServiceHost(typeof(Matematika));

            LabelOnOff.Text = "Server ON";
            labelKeterangan.Text = "Klik OFF untuk Mematikan Server";
            Host.Open();
            ON.Enabled = false;
            OFF.Enabled = true;
        }

        private void OFF_Click(object sender, EventArgs e)
        {
            ON.Enabled = true;
            OFF.Enabled = false;
            LabelOnOff.Text = "Server OFF";
            labelKeterangan.Text = "Klik ON untuk Menjalankan Server";
            Host.Close();
        }

        private void LabelOnOff_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
