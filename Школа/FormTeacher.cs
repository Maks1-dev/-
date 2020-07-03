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
    public partial class FormTeacher : Form
    {
        void ShowTeacher()
        {
            listViewTeacher.Items.Clear();
            foreach (Учителя Учителя in Program.wftDb.Учителя)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                        Учителя.Код_учителя.ToString(), Учителя.Фамилия, Учителя.Имя,
                        Учителя.Отчество, Учителя.Электронная_почта
                });
                item.Tag = Учителя;
                listViewTeacher.Items.Add(item);
            }
            listViewTeacher.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public FormTeacher()
        {
            InitializeComponent();
            ShowTeacher();
        }

        private void listViewStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTeacher.SelectedItems.Count == 1)
            {
                Учителя Учителя = listViewTeacher.SelectedItems[0].Tag as Учителя;
                textBoxSurname.Text = Учителя.Фамилия;
                textBoxName.Text = Учителя.Имя;
                textBoxMiddle.Text = Учителя.Отчество;
                textBoxMail.Text = Учителя.Электронная_почта;

            }
            else
            {
                textBoxSurname.Text = "";
                textBoxName.Text = "";
                textBoxMiddle.Text = "";
                textBoxMail.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Учителя Учителя = new Учителя();
            Учителя.Фамилия = textBoxSurname.Text;
            Учителя.Имя = textBoxName.Text;
            Учителя.Отчество = textBoxMiddle.Text;
            Учителя.Электронная_почта = textBoxMail.Text;
            Program.wftDb.Учителя.Add(Учителя);
            Program.wftDb.SaveChanges();
            ShowTeacher();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewTeacher.SelectedItems.Count == 1)
            {
                Учителя Учителя = listViewTeacher.SelectedItems[0].Tag as Учителя;
                Учителя.Фамилия = textBoxSurname.Text;
                Учителя.Имя = textBoxName.Text;
                Учителя.Отчество = textBoxMiddle.Text;
                Учителя.Электронная_почта = textBoxMail.Text;
                Program.wftDb.SaveChanges();
                ShowTeacher();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewTeacher.SelectedItems.Count == 1)
                {
                    Учителя Учителя = listViewTeacher.SelectedItems[0].Tag as Учителя;
                    Program.wftDb.Учителя.Remove(Учителя);
                    Program.wftDb.SaveChanges();
                    ShowTeacher();
                }
                textBoxSurname.Text = "";
                textBoxName.Text = "";
                textBoxMiddle.Text = "";
                textBoxMail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
