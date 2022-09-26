using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClickThis_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Hello World!";
            colorBtn.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorBtn.BackColor = Color.Green;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorBtn.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}