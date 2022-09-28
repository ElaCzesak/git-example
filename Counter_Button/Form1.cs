namespace Counter_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonZaehler_Click(object sender, EventArgs e)
        {

            var feld = anzahl.Text;
            var button = buttonZaehler.Text;
            


            int? feldint = Int32.Parse(feld);
            int? buttonint = buttonZaehler.Text.Length;
            
            buttonint = feldint + 1;

            anzahl.Text = buttonint.ToString();

        }

        private void anzahl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}