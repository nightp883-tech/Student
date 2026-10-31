using System;
using System.Drawing;
using System.Windows.Forms;

namespace Student
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtCode;
        private TextBox txtPhone;
        private Label lblTotal;
        private LinkLabel lnkClear;
        private CheckBox chkScholarship;
        private RadioButton rdoDay;
        private CheckedListBox clbSubjects;
        private NumericUpDown nudAge;
        private ComboBox cboDepartment;
        private DateTimePicker dtpBirthDate;
        private Button btnRegister;
        private ListBox lstLanguages;
        private PictureBox picStudent;
        private DataGridView dgvStudents;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colAge;
        private TreeView treeDepartments;
        private RichTextBox rtbSummary;
        private Label lblSummaryTitle;
        private Panel pnlSummary;
        private ProgressBar progressBar1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtCode = new TextBox();
            txtPhone = new TextBox();
            lblTotal = new Label();
            lnkClear = new LinkLabel();
            chkScholarship = new CheckBox();
            rdoDay = new RadioButton();
            clbSubjects = new CheckedListBox();
            nudAge = new NumericUpDown();
            cboDepartment = new ComboBox();
            dtpBirthDate = new DateTimePicker();
            btnRegister = new Button();
            lstLanguages = new ListBox();
            picStudent = new PictureBox();
            dgvStudents = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colAge = new DataGridViewTextBoxColumn();
            treeDepartments = new TreeView();
            rtbSummary = new RichTextBox();
            lblSummaryTitle = new Label();
            pnlSummary = new Panel();
            progressBar1 = new ProgressBar();

            ((System.ComponentModel.ISupportInitialize)nudAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            pnlSummary.SuspendLayout();
            SuspendLayout();

            // Оюутны код
            txtCode.Location = new Point(28, 28);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(245, 35);
            txtCode.Font = new Font("Segoe UI", 13F);
            txtCode.Text = "M.SW24D000";

            // Нийт бүртгэлийн тоо (жишээ утга)
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(350, 34);
            lblTotal.Name = "lblTotal";
            lblTotal.Font = new Font("Segoe UI", 13F);
            lblTotal.Text = "Нийт: 0";

            // Цэвэрлэх холбоос
            lnkClear.AutoSize = true;
            lnkClear.Location = new Point(630, 34);
            lnkClear.Name = "lnkClear";
            lnkClear.Font = new Font("Segoe UI", 13F);
            lnkClear.Text = "Цэвэрлэх";
            lnkClear.LinkColor = Color.Blue;

            // Тэтгэлэг
            chkScholarship.Location = new Point(30, 110);
            chkScholarship.Name = "chkScholarship";
            chkScholarship.Size = new Size(230, 34);
            chkScholarship.Text = "Тэтгэлэгтэй";
            chkScholarship.Checked = true;

            // Сургалтын хэлбэр
            rdoDay.Location = new Point(30, 158);
            rdoDay.Name = "rdoDay";
            rdoDay.Size = new Size(240, 34);
            rdoDay.Text = "Өдрийн сургалт";
            rdoDay.Checked = true;

            // Хичээл сонголт
            clbSubjects.Location = new Point(28, 225);
            clbSubjects.Name = "clbSubjects";
            clbSubjects.Size = new Size(245, 185);
            clbSubjects.CheckOnClick = true;
            clbSubjects.BorderStyle = BorderStyle.FixedSingle;
            clbSubjects.Items.AddRange(new object[] {
                "Программчлал", "Өгөгдлийн бүтэц", "Алгоритм", "Өгөгдлийн сан", "Сүлжээ"
            });
            clbSubjects.SetItemChecked(0, true);
            clbSubjects.SetItemChecked(1, true);

            // Нас
            nudAge.Location = new Point(28, 445);
            nudAge.Name = "nudAge";
            nudAge.Size = new Size(245, 35);
            nudAge.Minimum = 1;
            nudAge.Maximum = 120;
            nudAge.Value = 21;

            // Тэнхим
            cboDepartment.Location = new Point(28, 560);
            cboDepartment.Name = "cboDepartment";
            cboDepartment.Size = new Size(245, 35);
            cboDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDepartment.Items.AddRange(new object[] {
                "Мэдээллийн технологи", "Компьютерын ухаан", "Программ хангамж", "Математик", "Физик"
            });
            cboDepartment.SelectedIndex = 0;

            // Утас
            txtPhone.Location = new Point(28, 618);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(245, 35);
            txtPhone.Text = "9999-9999";

            // Төрсөн өдөр
            dtpBirthDate.Location = new Point(28, 675);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(245, 35);
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Value = new DateTime(2005, 1, 28);

            // Бүртгэх товч (одоогоор үйлдэлгүй)
            btnRegister.Location = new Point(28, 765);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(265, 75);
            btnRegister.Text = "Бүртгэх";
            btnRegister.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnRegister.ForeColor = Color.Blue;
            btnRegister.BackColor = Color.White;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.FlatAppearance.BorderColor = Color.SteelBlue;
            btnRegister.FlatAppearance.BorderSize = 2;
            btnRegister.UseVisualStyleBackColor = false;

            // Хэл сонгох
            lstLanguages.Location = new Point(350, 132);
            lstLanguages.Name = "lstLanguages";
            lstLanguages.Size = new Size(245, 178);
            lstLanguages.Items.AddRange(new object[] {
                "Монгол", "Англи", "Орос", "Хятад", "Япон", "Солонгос"
            });
            lstLanguages.SelectedIndex = 1;

            // Оюутны зураг (зураг сонгосон үед харуулах хоосон талбар)
            picStudent.Location = new Point(350, 330);
            picStudent.Name = "picStudent";
            picStudent.Size = new Size(245, 270);
            picStudent.BackColor = Color.White;
            picStudent.BorderStyle = BorderStyle.FixedSingle;
            picStudent.SizeMode = PictureBoxSizeMode.Zoom;

            // Бүртгэлийн хүснэгт
            dgvStudents.Location = new Point(625, 132);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(415, 178);
            dgvStudents.BackgroundColor = Color.White;
            dgvStudents.BorderStyle = BorderStyle.FixedSingle;
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.ReadOnly = true;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            colName.Name = "colName";
            colName.HeaderText = "Овог нэр";
            colName.FillWeight = 45F;
            colPhone.Name = "colPhone";
            colPhone.HeaderText = "Утас";
            colPhone.FillWeight = 35F;
            colAge.Name = "colAge";
            colAge.HeaderText = "Нас";
            colAge.FillWeight = 20F;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { colName, colPhone, colAge });

            // Тэнхимийн мод
            treeDepartments.Location = new Point(625, 330);
            treeDepartments.Name = "treeDepartments";
            treeDepartments.Size = new Size(415, 270);
            treeDepartments.Nodes.Add(new TreeNode("Мэдээллийн технологийн сургууль", new TreeNode[] {
                new TreeNode("Компьютерын ухаан"),
                new TreeNode("Мэдээллийн технологи"),
                new TreeNode("Программ хангамж")
            }));
            treeDepartments.Nodes.Add(new TreeNode("Байгалийн ухааны сургууль", new TreeNode[] {
                new TreeNode("Математик"), new TreeNode("Физик")
            }));
            treeDepartments.ExpandAll();

            // Мэдээллийн хэсэг
            pnlSummary.Location = new Point(350, 650);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Size = new Size(690, 315);
            pnlSummary.BackColor = Color.White;
            pnlSummary.BorderStyle = BorderStyle.FixedSingle;

            lblSummaryTitle.Location = new Point(12, 8);
            lblSummaryTitle.Name = "lblSummaryTitle";
            lblSummaryTitle.Size = new Size(640, 45);
            lblSummaryTitle.Text = "ОЮУТНЫ БҮРТГЭЛ";
            lblSummaryTitle.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblSummaryTitle.ForeColor = Color.Navy;

            rtbSummary.Location = new Point(10, 65);
            rtbSummary.Name = "rtbSummary";
            rtbSummary.Size = new Size(665, 235);
            rtbSummary.BorderStyle = BorderStyle.None;
            rtbSummary.BackColor = Color.White;
            rtbSummary.Font = new Font("Segoe UI", 12F);
            rtbSummary.ReadOnly = true;
            rtbSummary.Text =
                "Код: M.SW24D000\n" +
                "Утас: 9999-9999\n" +
                "Нас: 21\n" +
                "Төрсөн өдөр: 2005-01-28\n" +
                "Сургалт: Өдрийн\n" +
                "Тэнхим: Мэдээллийн технологи\n" +
                "Тэтгэлэг: Тийм\n" +
                "Хичээл: Программчлал, Өгөгдлийн бүтэц\n" +
                "Хэл: Англи";
            pnlSummary.Controls.Add(lblSummaryTitle);
            pnlSummary.Controls.Add(rtbSummary);

            // Доод явцын мөр (зөвхөн дизайн)
            progressBar1.Location = new Point(28, 995);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1012, 38);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Value = 100;

            // Form
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 1060);
            BackColor = Color.FromArgb(242, 242, 242);
            Font = new Font("Segoe UI", 12F);
            Name = "Form1";
            Text = "Оюутны бүртгэлийн программ";
            StartPosition = FormStartPosition.CenterScreen;
            AutoScroll = true;
            Controls.Add(txtCode);
            Controls.Add(txtPhone);
            Controls.Add(lblTotal);
            Controls.Add(lnkClear);
            Controls.Add(chkScholarship);
            Controls.Add(rdoDay);
            Controls.Add(clbSubjects);
            Controls.Add(nudAge);
            Controls.Add(cboDepartment);
            Controls.Add(dtpBirthDate);
            Controls.Add(btnRegister);
            Controls.Add(lstLanguages);
            Controls.Add(picStudent);
            Controls.Add(dgvStudents);
            Controls.Add(treeDepartments);
            Controls.Add(pnlSummary);
            Controls.Add(progressBar1);

            ((System.ComponentModel.ISupportInitialize)nudAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            pnlSummary.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}