using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Школа
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {
            Form FormStudent = new FormStudent();
            FormStudent.Show();
        }

        private void buttonTeacher_Click(object sender, EventArgs e)
        {
            Form FormTeacher = new FormTeacher();
            FormTeacher.Show();
        }

        private void buttonObjekt_Click(object sender, EventArgs e)
        {
            Form FormSubject = new FormSubject();
            FormSubject.Show();
        }

        private void buttonControl_Click(object sender, EventArgs e)
        {
            Form FormEvaluation = new FormEvaluation();
            FormEvaluation.Show();
        }
    }
}
