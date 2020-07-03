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
    public partial class FormSubject : Form
    {
        void ShowStubject()
        {
            listView.Items.Clear();
            foreach (Предметы Предметы in Program.wftDb.Предметы)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                        Предметы.Код_предмета.ToString(), Предметы.Название, Предметы.Код_учителя,
                });
                item.Tag = Предметы;
                listView.Items.Add(item);
            }
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public FormSubject()
        {
            InitializeComponent();
            ShowStubject();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Предметы Предметы = new Предметы();
            Предметы.Название = textBoxName.Text;
            Предметы.Код_учителя = comboBoxTeacher.Text;
            Program.wftDb.Предметы.Add(Предметы);
            Program.wftDb.SaveChanges();
            ShowStubject();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 1)
            {
                Предметы Предметы = listView.SelectedItems[0].Tag as Предметы;
                Предметы.Название = textBoxName.Text;
                Предметы.Код_учителя = comboBoxTeacher.Text;
                Program.wftDb.SaveChanges();
                ShowStubject();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView.SelectedItems.Count == 1)
                {
                    Предметы Предметы = listView.SelectedItems[0].Tag as Предметы;
                    Program.wftDb.Предметы.Remove(Предметы);
                    Program.wftDb.SaveChanges();
                    ShowStubject();
                }
                textBoxName.Text = "";
                comboBoxTeacher.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
