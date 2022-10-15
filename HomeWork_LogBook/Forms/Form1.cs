using HomeWork_LogBook.Repository;
using HomeWork_LogBook.UserControls;

namespace HomeWork_LogBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Load_Form

        private void Form1_Load(object sender, EventArgs e)
        {
            var students = FakeDepo.GetStudents();

            for (int i = students.Count - 1; i >= 0; i--)
            {
                Uc_Student uc = new(students[i]);
                uc.Dock = DockStyle.Top;

                panel2.Controls.Add(uc);
            }

            rbt_all.Enabled = false;
            txtBox_Dersin_adi.Enabled = false;
        }

        #endregion


        #region Dersin adi


        private void btn_pen_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked)
            {
                txtBox_Dersin_adi.Enabled = true;
                btn_save.Enabled = true;
                btn_cancel.Enabled = true;


                TextBox textBox = new TextBox()
                {
                    Location = new Point(737, 23),
                    Size = new Size(444, 93),
                    Name = "txtBox_Dersin_adi"
                };



                btn_cancel.Click += Btn_cancel_Click;
                btn_save.Click += Btn_save_Click;
            }
            else
                MessageBox.Show("Muellimi secin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Btn_save_Click(object? sender, EventArgs e)
        {

            txtBox_Dersin_adi.Enabled = false;
            btn_save.Enabled = false;
            btn_cancel.Enabled = false;
            rbt_all.Enabled = true;

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;

            if (txtBox_Dersin_adi.Text.Length > 3)
            {
                foreach (var control in panel2.Controls)
                {
                    if (control is Uc_Student s)
                    {
                        s.cbox_test.Enabled = true;
                        s.cbox_classwork.Enabled = true;
                        s.btn_comment.Enabled = true;
                        s.btn_c1.Enabled = true;
                        s.btn_c2.Enabled = true;
                        s.btn_c3.Enabled = true;
                        s.btn_diamond_cancel.Enabled = true;
                    }
                }
            }
            else
                MessageBox.Show("Movzunun adini 3 herfden boyuk olmalidir", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Btn_cancel_Click(object? sender, EventArgs e)
        {
            txtBox_Dersin_adi.Text = string.Empty;
            txtBox_Dersin_adi.Enabled = false;

            btn_save.Enabled = false;
            btn_cancel.Enabled = false;
            foreach (var control in panel2.Controls)
            {
                if (control is Uc_Student s)
                {
                    s.cbox_test.Enabled = false;
                    s.cbox_classwork.Enabled = false;
                    s.btn_comment.Enabled = false;
                    s.btn_c1.Enabled = false;
                    s.btn_c2.Enabled = false;
                    s.btn_c3.Enabled = false;
                    s.btn_diamond_cancel.Enabled = false;
                }
            }
        }
    



        #endregion






        private void rbt_all_CheckedChanged(object sender, EventArgs e)
        {
            if (txtBox_Dersin_adi.Text != string.Empty)
            {
                foreach (var control in panel2.Controls)
                    if (control is Uc_Student s)
                    {
                        s.rbtn_1.Enabled = true;
                        s.rbtn_2.Enabled = true;
                        s.rbtn_3.Enabled = true;

                        s.rbtn_1.Checked = true;
                    }

                txtBox_Dersin_adi.Enabled = false;
                btn_save.Enabled = false;
                btn_cancel.Enabled = false;
            }
            else
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                rbt_all.Enabled = false;
                MessageBox.Show("Movzunun adini daxil edin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}