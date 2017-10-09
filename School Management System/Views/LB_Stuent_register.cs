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
    public partial class LB_Stuent_register : MetroFramework.Forms.MetroForm
    {

        LibraryMain _libryMain = new LibraryMain();

        public LB_Stuent_register()
        {
            InitializeComponent();
        }

        private void Stuent_register_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            _libryMain.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string index = this.txtIndex.Text;
            string fullName = this.txtName.Text;
            string grade = this.txtGrade.Text;
            string contactNo = this.txtContactNo.Text;
            string indexGarantor = this.txtIndexOfGurantor.Text;
            string date = Date.Value.ToString("yyyy-MM-dd");

            MessageBox.Show(index, fullName);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            _libryMain.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
