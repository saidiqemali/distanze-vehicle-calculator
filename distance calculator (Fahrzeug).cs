using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_distance_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int speed;
            int hours;
            int distance;
            int i;
            bool clear = false;


            IstOutput.Items.Clear();

            if (int.TryParse(textspeed.Text, out speed) && int.TryParse(txtzeit.Text, out hours))
            {
                for (i = 1; i <= hours; i++);
                {
                    distance = speed * i;

                    IstOutput.Items.Add("Du bist " + i + ("kilometer gefahren") + distance.ToString("m"));
                }
            }

            else
            {
                MessageBox.Show("Bitte Richtige Zahlen Schreiben");
            }
        }
    }
}