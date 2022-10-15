using HomeWork_LogBook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork_LogBook.UserControls;

public partial class Uc_Student : UserControl
{
    public Uc_Student(Student student)
    {
        InitializeComponent();


        cbox_test.SelectedIndex = 0;
        cbox_classwork.SelectedIndex = 0;

        lbl_no.Text = student.Number.ToString();

        if (!string.IsNullOrWhiteSpace(student.PictureUrl))
            pictureBox1.Load($"./../../../Resources/{student.PictureUrl}");


        lbl_fullname.Text = student.FullName;
        lbl_lastin.Text = student.LastIn.ToShortDateString();


        switch (student.Status)
        {
            case ParticipationStatus.Present:
                rbtn_1.Checked = true;
                break;
            case ParticipationStatus.Late:
                rbtn_2.Checked = true;
                break;
            case ParticipationStatus.Absent:
                rbtn_3.Checked = true;
                break;
        }
    }

    Student student = new();

    private void btn_comment_Click(object sender, EventArgs e)
    {
        txt_comment.Visible = true;
        txt_comment.Enabled = true;

        btn_comment_save.Visible = true;
        btn_diamond_cancel.Visible = true;
    }

    private void cbox_test_SelectedIndexChanged(object sender, EventArgs e) => student.LaboratoryWork = (byte)cbox_test.SelectedIndex;

    private void cbox_classwork_SelectedIndexChanged(object sender, EventArgs e) => student.ClassWork = (byte)cbox_classwork.SelectedIndex;

    private void btn_comment_save_Click(object sender, EventArgs e)
    {
        if (txt_comment.Text.Length <= 3)
        {
            MessageBox.Show("Comment 3 herfden cox olmalidir", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_comment.Text = string.Empty;
            txt_comment.Visible = false;
        }

        btn_comment_save.Visible = false;
        txt_comment.Enabled = false;

        student.Comment = txt_comment.Text;
    }

}
