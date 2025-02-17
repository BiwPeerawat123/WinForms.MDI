namespace WinForms.MDI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            mnuLogin = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            mnuProdects = new ToolStripMenuItem();
            mnuCategories = new ToolStripMenuItem();
            mnuEmployees = new ToolStripMenuItem();
            mnuManiger = new ToolStripMenuItem();
            mnuManigerout = new ToolStripMenuItem();
            menuStrip3 = new MenuStrip();
            mnuCell1 = new ToolStripMenuItem();
            mnuCell2 = new ToolStripMenuItem();
            mnuCellOut = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            menuStrip3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F);
            button1.Location = new Point(1098, 219);
            button1.Name = "button1";
            button1.Size = new Size(116, 53);
            button1.TabIndex = 0;
            button1.Text = "login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16.2F);
            button2.Location = new Point(916, 219);
            button2.Name = "button2";
            button2.Size = new Size(116, 53);
            button2.TabIndex = 1;
            button2.Text = "logout";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1014, 298);
            label1.Name = "label1";
            label1.Size = new Size(127, 38);
            label1.TabIndex = 2;
            label1.Text = "บุคลากร  :";
            label1.Visible = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuLogin, mnuExit });
            menuStrip1.Location = new Point(0, 56);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1282, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuLogin
            // 
            mnuLogin.Name = "mnuLogin";
            mnuLogin.Size = new Size(80, 24);
            mnuLogin.Text = "เข้าสู่ระบบ";
            mnuLogin.Click += mnuLogin_Click;
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(90, 24);
            mnuExit.Text = "ปิดโปรแกรม";
            mnuExit.Click += mnuExit_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { mnuProdects, mnuCategories, mnuEmployees, mnuManiger, mnuManigerout });
            menuStrip2.Location = new Point(0, 28);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1282, 28);
            menuStrip2.TabIndex = 5;
            menuStrip2.Text = "menuStrip2";
            // 
            // mnuProdects
            // 
            mnuProdects.Name = "mnuProdects";
            mnuProdects.Size = new Size(128, 24);
            mnuProdects.Text = "จัดการข้อมูลสินค้า";
            mnuProdects.Click += mnuProdects_Click;
            // 
            // mnuCategories
            // 
            mnuCategories.Name = "mnuCategories";
            mnuCategories.Size = new Size(145, 24);
            mnuCategories.Text = "จัดการหมวดหมู่สินค้า";
            mnuCategories.Click += mnuCategories_Click;
            // 
            // mnuEmployees
            // 
            mnuEmployees.Name = "mnuEmployees";
            mnuEmployees.Size = new Size(145, 24);
            mnuEmployees.Text = "จัดการข้อมูลพนักงาน";
            // 
            // mnuManiger
            // 
            mnuManiger.Name = "mnuManiger";
            mnuManiger.Size = new Size(112, 24);
            mnuManiger.Text = "รายงานการขาย";
            // 
            // mnuManigerout
            // 
            mnuManigerout.Name = "mnuManigerout";
            mnuManigerout.Size = new Size(101, 24);
            mnuManigerout.Text = "ออกจากระบบ";
            mnuManigerout.Click += mnuManigerout_Click;
            // 
            // menuStrip3
            // 
            menuStrip3.ImageScalingSize = new Size(20, 20);
            menuStrip3.Items.AddRange(new ToolStripItem[] { mnuCell1, mnuCell2, mnuCellOut });
            menuStrip3.Location = new Point(0, 0);
            menuStrip3.Name = "menuStrip3";
            menuStrip3.Size = new Size(1282, 28);
            menuStrip3.TabIndex = 6;
            menuStrip3.Text = "menuStrip3";
            // 
            // mnuCell1
            // 
            mnuCell1.Name = "mnuCell1";
            mnuCell1.Size = new Size(80, 24);
            mnuCell1.Text = "ขายสินค้า";
            mnuCell1.Click += mnuCell1_Click;
            // 
            // mnuCell2
            // 
            mnuCell2.Name = "mnuCell2";
            mnuCell2.Size = new Size(115, 24);
            mnuCell2.Text = "รายงานยอดขาย";
            mnuCell2.Click += mnuCell2_Click;
            // 
            // mnuCellOut
            // 
            mnuCellOut.Name = "mnuCellOut";
            mnuCellOut.Size = new Size(101, 24);
            mnuCellOut.Text = "ออกจากระบบ";
            mnuCellOut.Click += mnuCellOut_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 590);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            Controls.Add(menuStrip3);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            menuStrip3.ResumeLayout(false);
            menuStrip3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private MenuStrip menuStrip3;
        private ToolStripMenuItem mnuLogin;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuProdects;
        private ToolStripMenuItem mnuCategories;
        private ToolStripMenuItem mnuEmployees;
        private ToolStripMenuItem mnuManiger;
        private ToolStripMenuItem mnuCell1;
        private ToolStripMenuItem mnuCell2;
        private ToolStripMenuItem mnuCellOut;
        private ToolStripMenuItem mnuManigerout;
    }
}
