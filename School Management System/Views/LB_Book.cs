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
    public partial class LB_Book : MetroFramework.Forms.MetroForm
    {
        public LB_Book()
        {
            InitializeComponent();
        }

        private void LB_Book_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LibraryMain lib = new LibraryMain();
            lib.Show();
            this.Hide();
        }

        private void metroTabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
