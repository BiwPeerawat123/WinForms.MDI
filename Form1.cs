namespace WinForms.MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.ShowDialog();
            if (f.EmployeeID == 0)
            {
                return;
            }
            label1.Text += f.EmployeeID.ToString() + Environment.NewLine;
            label1.Text += f.EmpName + Environment.NewLine;
            label1.Text += f.Position + Environment.NewLine;
            label1.Text += f.UserName + Environment.NewLine;
            this.Text = "ชื่อผู้ใช้ :" + f.EmpName + "ตำแหน่ง :" + f.Position;
            button1.Visible = false;
            button2.Visible = true;
            label1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = false;
            label1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowHideMenu(true, false, false);
        }
        void ShowHideMenu(Boolean Stsrt, Boolean mgrMneu, Boolean saleMneu)
        {
            menuStrip1.Visible = Stsrt;
            menuStrip2.Visible = mgrMneu;
            menuStrip3.Visible = saleMneu;
        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.ShowDialog();
            if (f.EmployeeID == 0)
            {
                return;
            }

            this.Text = "ชื่อผู้ใช้ :" + f.EmpName + "ตำแหน่ง :" + f.Position;
            if (f.Position == "Sale Manager")
            {
                ShowHideMenu(false, true, false);
            }
            else if (f.Position == "Sale Representative")
            {
                ShowHideMenu(false, false, true);
            }


        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("ปิดโปรแกรม", "โปรดยืนยัน", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void mnuCell1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuCell2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuProdects_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuCategories_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuCellOut_Click(object sender, EventArgs e)
        {
            foreach (var child in MdiChildren)
            {
                child.Close();
            }
            ShowHideMenu(true, false, false);
            this.Text = "ระบบMinimart";
        }

        private void mnuManigerout_Click(object sender, EventArgs e)
        {
            foreach (var child in MdiChildren)
            {
                child.Close();
            }
            ShowHideMenu(true, false, false);
            this.Text = "ระบบMinimart";
        }
    }
}
