namespace ungdung_tudien_anhviet
{
    partial class filetext
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(filetext));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quayLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quayLạiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtghifile = new System.Windows.Forms.TextBox();
            this.btnthoatfile = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quayLạiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(56, 450);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quayLạiToolStripMenuItem
            // 
            this.quayLạiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quayLạiToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.quayLạiToolStripMenuItem.Name = "quayLạiToolStripMenuItem";
            this.quayLạiToolStripMenuItem.Size = new System.Drawing.Size(49, 19);
            this.quayLạiToolStripMenuItem.Text = "MENU";
            // 
            // quayLạiToolStripMenuItem1
            // 
            this.quayLạiToolStripMenuItem1.Name = "quayLạiToolStripMenuItem1";
            this.quayLạiToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.quayLạiToolStripMenuItem1.Text = "Thoát FILE";
            this.quayLạiToolStripMenuItem1.Click += new System.EventHandler(this.QuayLạiToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // txtghifile
            // 
            this.txtghifile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtghifile.Location = new System.Drawing.Point(0, 39);
            this.txtghifile.Multiline = true;
            this.txtghifile.Name = "txtghifile";
            this.txtghifile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtghifile.Size = new System.Drawing.Size(801, 411);
            this.txtghifile.TabIndex = 2;
            this.txtghifile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
           
            // 
            // btnthoatfile
            // 
            this.btnthoatfile.Location = new System.Drawing.Point(704, 10);
            this.btnthoatfile.Name = "btnthoatfile";
            this.btnthoatfile.Size = new System.Drawing.Size(97, 23);
            this.btnthoatfile.TabIndex = 3;
            this.btnthoatfile.Text = "THOÁT FILE";
            this.btnthoatfile.UseVisualStyleBackColor = true;
            this.btnthoatfile.Click += new System.EventHandler(this.Btnthoatfile_Click);
            // 
            // filetext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.btnthoatfile);
            this.Controls.Add(this.txtghifile);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "filetext";
            this.Text = "filetext";
            this.Load += new System.EventHandler(this.Filetext_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quayLạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quayLạiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtghifile;
        private System.Windows.Forms.Button btnthoatfile;
    }
}