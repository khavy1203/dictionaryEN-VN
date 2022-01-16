namespace ungdung_tudien_anhviet
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richtxtTV = new System.Windows.Forms.RichTextBox();
            this.richtxtphienam = new System.Windows.Forms.RichTextBox();
            this.btntim = new System.Windows.Forms.Button();
            this.lsveng = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inTừRaFileTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtFileTextLênMàngHìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmTừToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaTừToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trênIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hayNhiêuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_cbx = new System.Windows.Forms.ToolStripComboBox();
            this.SuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.làmSạchCácTừTraGầnĐâyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button2 = new System.Windows.Forms.Button();
            this.btnchuyendoi = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Code Pro", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(111, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(642, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "TỪ ĐIỂN ANH VIỆT";
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiếng Anh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(539, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiếng Việt";
            // 
            // richtxtTV
            // 
            this.richtxtTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtxtTV.Location = new System.Drawing.Point(261, 150);
            this.richtxtTV.Name = "richtxtTV";
            this.richtxtTV.Size = new System.Drawing.Size(573, 290);
            this.richtxtTV.TabIndex = 4;
            this.richtxtTV.Text = "";
            // 
            // richtxtphienam
            // 
            this.richtxtphienam.Location = new System.Drawing.Point(154, 151);
            this.richtxtphienam.Name = "richtxtphienam";
            this.richtxtphienam.Size = new System.Drawing.Size(101, 290);
            this.richtxtphienam.TabIndex = 5;
            this.richtxtphienam.Text = "";
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(163, 119);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(68, 23);
            this.btntim.TabIndex = 7;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.Btntim_Click);
            // 
            // lsveng
            // 
            this.lsveng.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lsveng.HideSelection = false;
            this.lsveng.Location = new System.Drawing.Point(12, 148);
            this.lsveng.Name = "lsveng";
            this.lsveng.Size = new System.Drawing.Size(136, 290);
            this.lsveng.TabIndex = 8;
            this.lsveng.Tag = "0";
            this.lsveng.UseCompatibleStateImageBehavior = false;
            this.lsveng.View = System.Windows.Forms.View.Details;
            this.lsveng.SelectedIndexChanged += new System.EventHandler(this.Lsveng_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CÁC TỪ TRA GẦN ĐÂY";
            this.columnHeader1.Width = 167;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(792, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửaToolStripMenuItem,
            this.thêmTừToolStripMenuItem,
            this.xóaTừToolStripMenuItem,
            this.SuaToolStripMenuItem,
            this.làmSạchCácTừTraGầnĐâyToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.mENUToolStripMenuItem.Text = "MENU";
            this.mENUToolStripMenuItem.Click += new System.EventHandler(this.MENUToolStripMenuItem_Click);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inTừRaFileTextToolStripMenuItem,
            this.xuấtFileTextLênMàngHìnhToolStripMenuItem});
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.sửaToolStripMenuItem.Text = "Truy xuất từ vào file";
            // 
            // inTừRaFileTextToolStripMenuItem
            // 
            this.inTừRaFileTextToolStripMenuItem.Name = "inTừRaFileTextToolStripMenuItem";
            this.inTừRaFileTextToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.inTừRaFileTextToolStripMenuItem.Text = "In từ vào  file.";
            this.inTừRaFileTextToolStripMenuItem.Click += new System.EventHandler(this.InTừRaFileTextToolStripMenuItem_Click);
            // 
            // xuấtFileTextLênMàngHìnhToolStripMenuItem
            // 
            this.xuấtFileTextLênMàngHìnhToolStripMenuItem.Name = "xuấtFileTextLênMàngHìnhToolStripMenuItem";
            this.xuấtFileTextLênMàngHìnhToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.xuấtFileTextLênMàngHìnhToolStripMenuItem.Text = "Xuất/Thống kê các từ đã in";
            this.xuấtFileTextLênMàngHìnhToolStripMenuItem.Click += new System.EventHandler(this.XuấtFileTextLênMàngHìnhToolStripMenuItem_Click);
            // 
            // thêmTừToolStripMenuItem
            // 
            this.thêmTừToolStripMenuItem.Name = "thêmTừToolStripMenuItem";
            this.thêmTừToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.thêmTừToolStripMenuItem.Text = "Thêm từ";
            this.thêmTừToolStripMenuItem.Click += new System.EventHandler(this.ThêmTừToolStripMenuItem_Click);
            // 
            // xóaTừToolStripMenuItem
            // 
            this.xóaTừToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trênIDToolStripMenuItem,
            this.hayNhiêuToolStripMenuItem});
            this.xóaTừToolStripMenuItem.Name = "xóaTừToolStripMenuItem";
            this.xóaTừToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.xóaTừToolStripMenuItem.Text = "Xóa từ";
            // 
            // trênIDToolStripMenuItem
            // 
            this.trênIDToolStripMenuItem.Name = "trênIDToolStripMenuItem";
            this.trênIDToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.trênIDToolStripMenuItem.Text = "Trên mục \"Tìm kiếm\"";
            this.trênIDToolStripMenuItem.Click += new System.EventHandler(this.TrênIDToolStripMenuItem_Click);
            // 
            // hayNhiêuToolStripMenuItem
            // 
            this.hayNhiêuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnt_cbx});
            this.hayNhiêuToolStripMenuItem.Name = "hayNhiêuToolStripMenuItem";
            this.hayNhiêuToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.hayNhiêuToolStripMenuItem.Text = "Trên danh sách các từ tra gần đây";
            // 
            // mnt_cbx
            // 
            this.mnt_cbx.Name = "mnt_cbx";
            this.mnt_cbx.Size = new System.Drawing.Size(121, 23);
            this.mnt_cbx.SelectedIndexChanged += new System.EventHandler(this.Mnt_cbx_SelectedIndexChanged);
            // 
            // SuaToolStripMenuItem
            // 
            this.SuaToolStripMenuItem.Name = "SuaToolStripMenuItem";
            this.SuaToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.SuaToolStripMenuItem.Text = "Sửa từ";
            this.SuaToolStripMenuItem.Click += new System.EventHandler(this.SuaToolStripMenuItem_Click);
            // 
            // làmSạchCácTừTraGầnĐâyToolStripMenuItem
            // 
            this.làmSạchCácTừTraGầnĐâyToolStripMenuItem.Name = "làmSạchCácTừTraGầnĐâyToolStripMenuItem";
            this.làmSạchCácTừTraGầnĐâyToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.làmSạchCácTừTraGầnĐâyToolStripMenuItem.Text = "Làm sạch các từ tra gần đây";
            this.làmSạchCácTừTraGầnĐâyToolStripMenuItem.Click += new System.EventHandler(this.LàmSạchCácTừTraGầnĐâyToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(846, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(781, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 28);
            this.button2.TabIndex = 13;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnchuyendoi
            // 
            this.btnchuyendoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchuyendoi.Location = new System.Drawing.Point(429, 92);
            this.btnchuyendoi.Name = "btnchuyendoi";
            this.btnchuyendoi.Size = new System.Drawing.Size(75, 28);
            this.btnchuyendoi.TabIndex = 10;
            this.btnchuyendoi.Text = "~";
            this.btnchuyendoi.UseVisualStyleBackColor = true;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(12, 122);
            this.txtname.Name = "txtname";
            this.txtname.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtname.Size = new System.Drawing.Size(136, 20);
            this.txtname.TabIndex = 0;
            this.txtname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtname_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnchuyendoi);
            this.Controls.Add(this.lsveng);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.richtxtphienam);
            this.Controls.Add(this.richtxtTV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ứng dụng từ điển";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richtxtTV;
        private System.Windows.Forms.RichTextBox richtxtphienam;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.ListView lsveng;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmTừToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem làmSạchCácTừTraGầnĐâyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtFileTextLênMàngHìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inTừRaFileTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SuaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaTừToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trênIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hayNhiêuToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox mnt_cbx;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnchuyendoi;
        private System.Windows.Forms.TextBox txtname;
    }
}

