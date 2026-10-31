
using System;
using System.Windows.Forms;

namespace Student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCode.Clear();
            txtPhone.Clear();

            nudAge.Value = 18;
            chkScholarship.Checked = false;

            dtpBirthDate.Value = DateTime.Today;
        }
    }
}
