using System.Windows.Forms;
using System.IO;

namespace DamianWymówki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            currentExcuse.LastUsed = lastUsed.Value;
        }

        private Excuse currentExcuse = new Excuse();
        private string selectedFolder = "";
        private bool formChanged = false;
        Random random = new Random();

        private void folder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = selectedFolder;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                selectedFolder = folderBrowserDialog1.SelectedPath;
                save.Enabled = true;
                open.Enabled = true;
                randomExcuse.Enabled = true;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(description.Text) || String.IsNullOrEmpty(results.Text))
            {
                MessageBox.Show("Określ wymówkę  rezultat", "Nie można zapisać pliku", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
            }
            saveFileDialog1.InitialDirectory = selectedFolder;
            saveFileDialog1.Filter = "Pliki wymówek (*.excuse)|*.excuse|Wszystkie pliki (*.*)|*.*";
            saveFileDialog1.FileName = description.Text + ".excuse";
            DialogResult result = saveFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                currentExcuse.Save(saveFileDialog1.FileName);
                UpdateForm(false);
                MessageBox.Show("Wymówka zapisana");
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                saveFileDialog1.InitialDirectory = selectedFolder;
                saveFileDialog1.Filter = "Pliki tekstowe (*.excuse)|*.excuse|Wszystkie pliki (*.*)|*.*";
                saveFileDialog1.FileName = description.Text + ".excuse";
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    currentExcuse = new Excuse(OpenFileDialog1.FilenName);
                    UpdateForm(false);
                }
            }
        }

        private void randomExcuse_Click(object sender, EventArgs e)
        {
            if(CheckChanged())
            {
                currentExcuse = new Excuse(random, selectedFolder);
                UpdateForm(false);
            }
        }

        private bool CheckChanged()
        {
            if(formChanged)
            {
                DialogResult result = MessageBox.Show("Biężąca wymówka nie została zapisana. Czy kontynuować?", "Ostrzeżenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return false;
            }
            return true;
        }

        private void description_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Description = description.Text;
            UpdateForm(true);
        }

        private void results_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Results = results.Text;
            UpdateForm(true);
        }

        private void lastUsed_ValueChanged(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = lastUsed.Text;
            UpdateForm(true);
        }
    }
}
