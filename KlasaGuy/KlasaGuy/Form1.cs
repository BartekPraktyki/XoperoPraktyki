namespace KlasaGuy
{
    public partial class Form1 : Form
    {
        Guy joe = new Guy();
        Guy bob = new Guy();
        int bank = 100;

        public void UpdateForm()
        {
            joesCashLabel.Text = joe.Name + " ma " + joe.Cash + " z³";
            bobsCashLabel.Text = bob.Name + " ma " + bob.Cash + " z³";
            bankCashLabel.Text = "Bank ma " + bank + " z³";
        }
        public Form1()
        {
            InitializeComponent();
            joe.Cash = 50;
            joe.Name = "Joe";
            bob.Cash = 100;
            bob.Name = "Bob";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
                MessageBox.Show("Bank nie posiada takiej iloœci pieniêdzy");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }
    }
}
