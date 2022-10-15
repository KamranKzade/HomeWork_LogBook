using HomeWork_LogBook.Repository;
using HomeWork_LogBook.UserControls;

namespace HomeWork_LogBook;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    bool checkRadioEsas;

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
    }

    #endregion

    #region Panel1 Click Button

    private void btn_pen_Click(object sender, EventArgs e)
    {
        checkRadioEsas = radioButton1.Checked;
        if (radioButton1.Checked || radioButton2.Checked)
        {
            txtBox_Dersin_adi.Visible = true;
            txtBox_Dersin_adi.Enabled = true;

            btn_save.Visible = true;
            btn_cancel.Visible = true;
        }
        else
            MessageBox.Show("Muellimi secin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    #endregion

    #region Save Button Click

    private void Btn_save_Click(object? sender, EventArgs e)
    {
        txtBox_Dersin_adi.Enabled = false;
        btn_save.Visible = false;
        btn_cancel.Visible = false;

        if (txtBox_Dersin_adi.Text.Length > 3)
        {
            rbt_all.Enabled = true;

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
                    s.rbtn_1.Enabled = true;
                    s.rbtn_2.Enabled = true;
                    s.rbtn_3.Enabled = true;
                }
            }
        }
        else
        {
            MessageBox.Show("Movzunun adini 3 herfden boyuk olmalidir", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    #endregion

    #region Cancel Button

    private void Btn_cancel_Click(object? sender, EventArgs e)
    {
        txtBox_Dersin_adi.Text = string.Empty;
        txtBox_Dersin_adi.Visible = false;

        btn_save.Visible = false;
        btn_cancel.Visible = false;

        rbt_all.Enabled = false;

        foreach (var control in panel2.Controls)
        {
            if (control is Uc_Student s)
            {
                s.rbtn_1.Enabled = false;
                s.rbtn_2.Enabled = false;
                s.rbtn_3.Enabled = false;
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

    #region AllRadioButton

    private void rbt_all_CheckedChanged(object sender, EventArgs e)
    {
        if (checkRadioEsas == true)
            radioButton1.Checked = true;
        else
            radioButton2.Checked = true;

        foreach (var control in panel2.Controls)
            if (control is Uc_Student s)
            {
                s.rbtn_1.Enabled = true;
                s.rbtn_2.Enabled = true;
                s.rbtn_3.Enabled = true;

                s.rbtn_1.Checked = true;
            }
    }

    #endregion


}