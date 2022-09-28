using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            //test 123324
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var feld = anzahl.Text;
            var button = buttonZaehler.Text;

            //convert to int
            int feldint = Int32.Parse(feld);
            int buttonint = buttonZaehler.Text.Length;

            //add 1 for click
            buttonint = feldint + 1;

            //write field
            anzahl.Text = buttonint.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void anzahl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
