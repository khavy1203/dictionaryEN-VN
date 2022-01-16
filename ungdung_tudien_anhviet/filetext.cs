using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ungdung_tudien_anhviet
{
    public partial class filetext : Form
    {
        public filetext()
        {
            InitializeComponent();
        }
        private void docfile()
        {
            FileStream file = new FileStream("file_in_tu.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file, Encoding.UTF8);
            string temp = reader.ReadToEnd();
            txtghifile.Text = temp;
            reader.Close();
            file.Close();
        }
        private void QuayLạiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            if (Application.OpenForms.OfType<Form1>().Count() == 1)
            {

                Application.OpenForms.OfType<Form1>().First().Show();

            }
            this.Close();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            Application.Exit();
        }

        private void Filetext_Load(object sender, EventArgs e)
        {

            docfile();
            FileStream file = new FileStream("file_in_tu.txt", FileMode.Create);
            file.Close();
        }

        private void Btnthoatfile_Click(object sender, EventArgs e)
        {
            QuayLạiToolStripMenuItem1_Click(sender, e);
        }

        
    }
}
