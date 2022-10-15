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
                rbtn_1.Checked = false;
                break;
            case ParticipationStatus.Late:
                rbtn_2.Checked = false;
                break;
            case ParticipationStatus.Absent:
                rbtn_3.Checked = false;
                break;
        }
    }

    private void btn_comment_Click(object sender, EventArgs e)
    {
        txt_comment.Enabled = true;
    }
}
