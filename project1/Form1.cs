using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.LightGray;
            label1.BackColor = Color.White;
            textBox1.Font = new Font("Times New Roman", 12);
            button1.Font = new Font("Times New Roman", 12);
            label1.Font = new Font("Times New Roman", 14);
            textBox1.TextAlign = HorizontalAlignment.Center;
            label1.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Halo "+textBox1.Text;
        }
    }
}
