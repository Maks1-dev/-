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
    public partial class FormStudent : Form
    {
        void ShowStudent()
        {
            listViewStudent.Items.Clear();
            foreach (Ученики Ученики in Program.wftDb.Ученики)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                        Ученики.Код_ученика.ToString(), Ученики.Фамилия, Ученики.Имя,
                        Ученики.Отчество, Ученики.Дата_рождения
                });
                item.Tag = Ученики;
                listViewStudent.Items.Add(item);
            }
            listViewStudent.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public FormStudent()
        {
            InitializeComponent();
            ShowStudent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Ученики Ученики = new Ученики();
            Ученики.Фамилия = textBoxSurname.Text;
            Ученики.Имя = textBoxName.Text;
            Ученики.Отчество = textBoxMiddle.Text;
            Ученики.Дата_рождения = textBoxDate.Text;
            Program.wftDb.Ученики.Add(Ученики);
            Program.wftDb.SaveChanges();
            ShowStudent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStudent.SelectedItems.Count == 1)
            {
                Ученики Ученики = listViewStudent.SelectedItems[0].Tag as Ученики;
                textBoxSurname.Text = Ученики.Фамилия;
                textBoxName.Text = Ученики.Имя;
                textBoxMiddle.Text = Ученики.Отчество;
                textBoxDate.Text = Ученики.Дата_рождения;

            }
            else
            {
                textBoxSurname.Text = "";
                textBoxName.Text = "";
                textBoxMiddle.Text = "";
                textBoxDate.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewStudent.SelectedItems.Count == 1)
            {
                Ученики Ученики = listViewStudent.SelectedItems[0].Tag as Ученики;
                Ученики.Фамилия = textBoxSurname.Text;
                Ученики.Имя = textBoxName.Text;
                Ученики.Отчество = textBoxMiddle.Text;
                Ученики.Дата_рождения = textBoxDate.Text;
                Program.wftDb.SaveChanges();
                ShowStudent();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewStudent.SelectedItems.Count == 1)
                {
                    Ученики Ученики = listViewStudent.SelectedItems[0].Tag as Ученики;
                    Program.wftDb.Ученики.Remove(Ученики);
                    Program.wftDb.SaveChanges();
                    ShowStudent();
                }
                textBoxSurname.Text = "";
                textBoxName.Text = "";
                textBoxMiddle.Text = "";
                textBoxDate.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
