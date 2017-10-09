using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class LibraryMain : MetroFramework.Forms.MetroForm
    {        
        public LibraryMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            LB_Settings set = new LB_Settings();
            set.Show();
            this.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            LB_Return_Book ret = new LB_Return_Book();
            ret.Show();
            this.Hide();
        }

        private void btnFine_Click(object sender, EventArgs e)
        {
            LB_Fine fine = new LB_Fine();
            fine.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            LB_Stuent_register _register = new LB_Stuent_register();
            _register.Show();
            this.Hide();
        }

        private void btnLending_Click(object sender, EventArgs e)
        {
            LB_Lending_Book lending = new LB_Lending_Book();
            lending.Show();
            this.Hide();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            LB_Book book = new LB_Book();
            book.Show();
            this.Hide();
        }        

        private void btnUser_Click(object sender, EventArgs e)
        {
            LB_User user = new LB_User();
            user.Show();
            this.Hide();
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            this.metroContextMenu1.Show(btnExit,0,btnExit.Height);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login _login = new Login();
            _login.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
    
}
