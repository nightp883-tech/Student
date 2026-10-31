
using System;
using System.Windows.Forms;

namespace Student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnRegister.Click += btnRegister_Click;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCode.Clear();
            txtPhone.Clear();

            nudAge.Value = 18;
            chkScholarship.Checked = false;

            dtpBirthDate.Value = DateTime.Today;
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            string phone = txtPhone.Text.Trim();
            int age = (int)nudAge.Value;

            if (code == "" || phone == "")
            {
                MessageBox.Show(
                    "Оюутны код болон утсаа оруулна уу!",
                    "Анхааруулга",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Хүснэгтэд оюутан нэмэх
            dgvStudents.Rows.Add(code, phone, age);

            // Нийт бүртгэлийн тоо
            lblTotal.Text = "Нийт: " +
                dgvStudents.Rows.Count;

            MessageBox.Show(
                "Оюутан амжилттай бүртгэгдлээ!",
                "Амжилттай",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

    }
}
