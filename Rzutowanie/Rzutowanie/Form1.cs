namespace Rzutowanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal myDecimalvalue = 10;
            int myIntValue = (int)myDecimalvalue;

            MessageBox.Show("myIntValue jest równe " + myIntValue);
        }
    }
}
