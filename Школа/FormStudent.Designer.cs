namespace Школа
{
    partial class FormStudent
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMiddle = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxMiddle = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.listViewStudent = new System.Windows.Forms.ListView();
            this.columnStudent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMiddle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(25, 12);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(56, 13);
            this.labelSurname.TabIndex = 1;
            this.labelSurname.Text = "Фамилия";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(28, 28);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(25, 76);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Имя";
            // 
            // labelMiddle
            // 
            this.labelMiddle.AutoSize = true;
            this.labelMiddle.Location = new System.Drawing.Point(25, 150);
            this.labelMiddle.Name = "labelMiddle";
            this.labelMiddle.Size = new System.Drawing.Size(54, 13);
            this.labelMiddle.TabIndex = 4;
            this.labelMiddle.Text = "Отчество";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(25, 214);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(86, 13);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "Дата рождения";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(28, 92);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxMiddle
            // 
            this.textBoxMiddle.Location = new System.Drawing.Point(28, 166);
            this.textBoxMiddle.Name = "textBoxMiddle";
            this.textBoxMiddle.Size = new System.Drawing.Size(100, 20);
            this.textBoxMiddle.TabIndex = 7;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(28, 230);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxDate.TabIndex = 8;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(248, 272);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(115, 32);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(380, 272);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(115, 32);
            this.buttonEdit.TabIndex = 16;
            this.buttonEdit.Text = "Изменить ";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(510, 272);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(115, 32);
            this.buttonDel.TabIndex = 17;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // listViewStudent
            // 
            this.listViewStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnStudent,
            this.columnSurname,
            this.columnName,
            this.columnMiddle,
            this.columnDate});
            this.listViewStudent.HideSelection = false;
            this.listViewStudent.Location = new System.Drawing.Point(138, 12);
            this.listViewStudent.Name = "listViewStudent";
            this.listViewStudent.Size = new System.Drawing.Size(510, 238);
            this.listViewStudent.TabIndex = 18;
            this.listViewStudent.UseCompatibleStateImageBehavior = false;
            this.listViewStudent.View = System.Windows.Forms.View.Details;
            // 
            // columnStudent
            // 
            this.columnStudent.Text = "Код ученика";
            this.columnStudent.Width = 82;
            // 
            // columnSurname
            // 
            this.columnSurname.Text = "Фамилия";
            this.columnSurname.Width = 96;
            // 
            // columnName
            // 
            this.columnName.Text = "Имя";
            this.columnName.Width = 90;
            // 
            // columnMiddle
            // 
            this.columnMiddle.Text = "Отчество";
            this.columnMiddle.Width = 113;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Дата рождения";
            this.columnDate.Width = 117;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 316);
            this.Controls.Add(this.listViewStudent);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxMiddle);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelMiddle);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelSurname);
            this.Name = "FormStudent";
            this.Text = "Ученики";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMiddle;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxMiddle;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ListView listViewStudent;
        private System.Windows.Forms.ColumnHeader columnStudent;
        private System.Windows.Forms.ColumnHeader columnSurname;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnMiddle;
        private System.Windows.Forms.ColumnHeader columnDate;
    }
}

