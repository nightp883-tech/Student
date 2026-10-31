
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
            lnkClear.Click += btnClear_Click;
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            // TextBox цэвэрлэх
            txtCode.Clear();
            txtPhone.Clear();

            // Нас болон төрсөн өдөр
            nudAge.Value = 18;
            dtpBirthDate.Value = DateTime.Today;

            // Тэтгэлэг
            chkScholarship.Checked = false;

            // Сургалтын хэлбэр
            rdoDay.Checked = false;

            // Тэнхим
            cboDepartment.SelectedIndex = -1;
            // Сонгосон хичээлүүд
            for (int i = 0; i < clbSubjects.Items.Count; i++)
            {
                clbSubjects.SetItemChecked(i, false);
            }

            // Хэлний сонголт
            lstLanguages.ClearSelected();

            // Дэлгэрэнгүй мэдээлэл
            dgvStudents.Rows.Clear();

            // Оюутны код дээр курсор байрлуулах
            txtCode.Focus();
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
            ShowStudentDetails();
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


        private void ShowStudentDetails()
        {
            string code = txtCode.Text;
            string phone = txtPhone.Text;
            int age = (int)nudAge.Value;

            string birthDate =
                dtpBirthDate.Value.ToString("yyyy-MM-dd");

            string scholarship =
                chkScholarship.Checked ? "Тийм" : "Үгүй";

            string training =
                rdoDay.Checked ? "Өдрийн" : "Оройн";

            string department = cboDepartment.Text;

            string subjects = "";

            foreach (object item in clbSubjects.CheckedItems)
            {
                if (subjects != "")
                    subjects += ", ";

                subjects += item.ToString();
            }

            string language = lstLanguages.Text;

            rtbSummary.Text =
                "ОЮУТНЫ БҮРТГЭЛ\n\n" +
                "Код: " + code + "\n" +
                "Утас: " + phone + "\n" +
                "Нас: " + age + "\n" +
                "Төрсөн өдөр: " + birthDate + "\n" +
                "Сургалт: " + training + "\n" +
                "Тэнхим: " + department + "\n" +
                "Тэтгэлэг: " + scholarship + "\n" +
                "Хичээл: " + subjects + "\n" +
                "Хэл: " + language;
        }

    }
}
