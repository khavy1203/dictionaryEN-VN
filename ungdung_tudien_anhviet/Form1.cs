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
using System.Collections;
namespace ungdung_tudien_anhviet
{
    public partial class Form1 : Form
    {
        
        static List<Tu_tieng_anh> temp_ds = new List<Tu_tieng_anh>();

        public static string temp_name=string.Empty;
        public static string temp_phienam = string.Empty;
        public static string temp_nghia= string.Empty;
        private CDStu_tieng_anh ds_tu_tieng_anh ;

        public Form1()
        {
            
            InitializeComponent();
        }

        private void docfile(string tenfile)
        {
            ds_tu_tieng_anh = new CDStu_tieng_anh();
           
            FileStream file = new FileStream(tenfile, FileMode.Open,FileAccess.Read);
            if(file==null)
            {
                MessageBox.Show("Khong tim kiem dc file");
                this.Close();
            }
            StreamReader reader = new StreamReader(file);


            string line = reader.ReadLine();

            bool flag = false;
            bool dathem = false;
            string[] arrrayfile = File.ReadAllLines(tenfile);
            string chuoicuoi = arrrayfile[arrrayfile.Length - 1];
            
            while (line!=null)
            {
                Tu_tieng_anh tu = new Tu_tieng_anh();
                 
                while(line!=null)
                {
                    
                    if (line.StartsWith("@"))
                    {
                        if (flag == true)
                        {
                            ds_tu_tieng_anh.them(tu);
                            flag = false;
                            dathem = true;

                            
                            break;
                        }
                        tu.id = id(line).Trim('@',' ','-');
                        tu.phienam = phien_am(line).Trim('/');
                    }
                    else
                    {
                        tu.nghia=tu.nghia.Trim(' ') + line + "\r\n";
                        
                        flag = true;
                        if(line==chuoicuoi)
                        {
                            ds_tu_tieng_anh.them(tu);
                        }
                    }
                    if (dathem==true)
                    {
                        dathem = false;
                        break;
                    }
                    line = reader.ReadLine();
                    
                    
                }
            }
            file.Close();
           
            reader.Close();
        }
       
        private Tu_tieng_anh return_one_from_addcs()
        {
            Tu_tieng_anh tu = new Tu_tieng_anh();
            tu.id = temp_name;
            tu.phienam = temp_phienam;
            tu.nghia = temp_nghia;
            ds_tu_tieng_anh.them(tu);
            return tu;
        }
        
       
        private string id(string line)
        {
            int vitri = line.IndexOf('/');
           
            int    i=0;
            if (vitri > 0)
            {
                while (line[i] != '/')
                {
                    i++;
                }
                return line.Substring(0, i);
            }

            else
            {
                return line;
            }
        }
        private string phien_am(string line)
        {
            int vitri = line.IndexOf('/');
            int i = line.LastIndexOf('/');
            if (vitri > 0 )
            {
                return line.Substring(vitri ,i-vitri+1);
}
            else
            {
                return "";
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            docfile("anhviet.txt");
            txtname.Focus();

        }

        private void showtext(Tu_tieng_anh tu)
        {
            txtname.Text = tu.id;
            richtxtphienam.Text = tu.phienam;
            richtxtTV.Text = tu.nghia;
        }


        private void Btntim_Click(object sender, EventArgs e)
        {
            string id = txtname.Text;
            if(id=="")
            {
                MessageBox.Show("Bạn cần nhập từ để tìm kiếm");
                return;

            }
            
            Tu_tieng_anh tu = ds_tu_tieng_anh.tim(id);
            if(tu==null)
            {
                MessageBox.Show("Không có từ bạn tìm kiếm");
                return;
            }
            bool kt_tontai=false;
            
            foreach(ListViewItem _liv in lsveng.Items)
            {
                if (_liv.Text == id)
                {
                    kt_tontai = true;
                    break;
                }
            }
            if (kt_tontai == false)
            {
                ListViewItem liv = new ListViewItem(id);
                lsveng.Items.Add(liv);
            }
            showtext(tu);


        }
       
        private void Lsveng_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            foreach(ListViewItem liv in lsveng.SelectedItems)
            {
                
                string id = liv.SubItems[0].Text;
                Tu_tieng_anh tu = ds_tu_tieng_anh.tim(id);
                showtext(tu);
            }
        }

       

        private void ThêmTừToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            add form_add;
            if (Application.OpenForms.OfType<add>().Count()==1)
            {
                Application.OpenForms.OfType<add>().First().Show();
            }
            else
            {
                form_add = new add();
                form_add.ShowDialog();
            }
            return_one_from_addcs();
        }


        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void LàmSạchCácTừTraGầnĐâyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lsveng.Items.Clear();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void InTừRaFileTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Tu_tieng_anh tu = new Tu_tieng_anh();
            tu =ds_tu_tieng_anh.tim(txtname.Text);
            foreach(Tu_tieng_anh temp in temp_ds )
            {
                if(tu==temp)
                {
                    MessageBox.Show("Từ đã tồn tại trong file in");
                    return;
                }
            }
            if (tu != null)
            {
                temp_ds.Add(tu);
            }
            else

            {
                DialogResult dlr = MessageBox.Show("Bạn cần chọn tìm kiếm từ để in", "Thông báo", MessageBoxButtons.OK ,MessageBoxIcon.Warning) ;

            }
        }


        private void XuấtFileTextLênMàngHìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {

            

            if (temp_ds.Count == 0)
            {
            DialogResult dlr = MessageBox.Show("File chưa có từ nào, vui lòng chọn và in từ trước khi xuất file", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;

            }
            FileStream file = new FileStream("file_in_tu.txt", FileMode.Open, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file, Encoding.UTF8);
            foreach(Tu_tieng_anh tu in temp_ds)
            {
                writer.WriteLine("@"+tu.id+"   /"+tu.phienam+"/"+"\r\n"+tu.nghia);
                writer.WriteLine("----------------------------------------");

            }
            writer.Flush();
            writer.Close();

            file.Close();

            
            filetext form_txt = new filetext();
            
            form_txt.ShowDialog();
        }


        private void them_id_vaomenucombobox()
        {

            mnt_cbx.Items.Clear();
            foreach (ListViewItem liv in lsveng.Items)
            {
                this.mnt_cbx.Items.AddRange(new object[] { liv.Text});
            }
        }


        private void Btnrst_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Từ điển đã được cập nhật");
        }

        

        private void MENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            them_id_vaomenucombobox();
        }

        private void Mnt_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tu = mnt_cbx.SelectedItem.ToString();
            bool kiemtra_daxoa_haychua;
            kiemtra_daxoa_haychua=ds_tu_tieng_anh.xoa(tu);
            if (kiemtra_daxoa_haychua ==true)
            {
                MessageBox.Show("Bạn đã xóa thành công ");
                foreach(ListViewItem _liv in lsveng.Items)
                {
                    if (_liv.Text == tu) lsveng.Items.Remove(_liv);

                }
                txtname.Text = null;
                richtxtTV.Text = null;
                richtxtphienam.Text = null;
            }
            else
            {
                MessageBox.Show("Từ này đã xóa", "Bạn hãy chọn từ khác");
            }
            MENUToolStripMenuItem_Click(sender, e);

        }


        private void TrênIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tu = txtname.Text;
            bool kiemtra_daxoa_haychua;
            kiemtra_daxoa_haychua = ds_tu_tieng_anh.xoa(tu);
            if (kiemtra_daxoa_haychua == true)
            {
                MessageBox.Show("Bạn đã xóa thành công ");
                foreach (ListViewItem _liv in lsveng.Items)
                {
                    if (_liv.Text == tu) lsveng.Items.Remove(_liv);

                }
                txtname.Text = null;
                richtxtTV.Text =null;
                richtxtphienam.Text = null ;

            }
            else
            {
                MessageBox.Show("Bạn cần phải tìm kiếm từ cần xóa");
            }
            txtname.Focus();
        }


        private void Txtname_KeyDown(object sender, KeyEventArgs e)
        {
            
                if (e.KeyCode == Keys.Enter) 
                Btntim_Click(sender, e);
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            txtname.Text = null;
            richtxtphienam.Text = null;
            richtxtTV.Text = null;
            LàmSạchCácTừTraGầnĐâyToolStripMenuItem_Click(sender, e);
        }


        private void SuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Tu_tieng_anh tu = ds_tu_tieng_anh.tim(txtname.Text);

            if(tu==null)
            {
                MessageBox.Show("Từ này không có trong từ điển để sửa! Vui lòng kiểm tra lại ID");
                return;
            }
            
            else
            {
                
                if (richtxtTV.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập NGHĨA để được sửa");
                    richtxtTV.Focus();
                    return;
                }
                if (richtxtphienam.Text == "")
                {
                    
                    DialogResult dlr_phienam= MessageBox.Show("Chúng tôi sẽ sửa từ này với phần phiên âm sẽ không có ?.","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (dlr_phienam == DialogResult.No)
                    {
                        richtxtphienam.Focus();
                        return;
                    }
                }
                if (tu.nghia == richtxtTV.Text && tu.phienam == richtxtphienam.Text)
                {
                    MessageBox.Show("Chưa thấy sự thay đổi về phiên âm và nghĩa của từ này!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                

                DialogResult dlr = MessageBox.Show("Bạn chắc chắn sửa từ này!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.No) return;

                tu.id = txtname.Text;
                tu.phienam = richtxtphienam.Text;
                tu.nghia = richtxtTV.Text;
                MessageBox.Show("Từ đã được sửa thành công");
            }
        }

        
    }
}
