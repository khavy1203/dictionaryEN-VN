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
    public partial class add : Form
    {
        
        public add()
        {
            InitializeComponent();
            
        }

        private void Btnthem_Click(object sender, EventArgs e)
        {
           
            if(txt_formadd_name.Text=="")
            {
                MessageBox.Show("Bạn phải nhập NAME để được thêm");
                txt_formadd_name.Focus();
                return;
            }
            if (txt_formadd_nghia.Text == "")
            {
                MessageBox.Show("Bạn phải nhập NGHĨA để được thêm");
                txt_formadd_nghia.Focus();
                return;
            }
            if(txt_formadd_phienam.Text=="")
            {
                MessageBox.Show("Chúng tôi sẽ thêm từ này với phần phiên âm sẽ không có.");
            }
            DialogResult dlr = MessageBox.Show("Chúng tôi sẽ thêm từ này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No) return;

            Form1.temp_name = txt_formadd_name.Text;
            Form1.temp_nghia = txt_formadd_nghia.Text;
            Form1.temp_phienam = txt_formadd_phienam.Text;
            

            clear();


            this.Hide();
            if(Application.OpenForms.OfType<Form1>().Count()==1)
            {
                
                Application.OpenForms.OfType<Form1>().First().Show();
                
            }
            this.Close();
            

        }
        private void clear()
        {
            txt_formadd_name.Text =null;
            txt_formadd_nghia.Text = null;
            txt_formadd_phienam.Text =null;
        }

       
        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void QuayLạiFormChínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms.OfType<Form1>().First().Show();
            this.Close();
        }

        

        private void ThêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Btnthem_Click(sender, e);
        }

       

        private void Button1_Click(object sender, EventArgs e)
        {
            QuayLạiFormChínhToolStripMenuItem_Click( sender,  e);
        }

        private void Add_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                Btnthem_Click(sender, e);
            }
        }

       
    }
}
