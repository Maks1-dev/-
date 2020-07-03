namespace Школа
{
    partial class FormTeacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewTeacher = new System.Windows.Forms.ListView();
            this.columnTeacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMiddle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelMiddle = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.textBoxMiddle = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewTeacher
            // 
            this.listViewTeacher.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTeacher,
            this.columnSurname,
            this.columnName,
            this.columnMiddle,
            this.columnMail});
            this.listViewTeacher.HideSelection = false;
            this.listViewTeacher.Location = new System.Drawing.Point(128, 12);
            this.listViewTeacher.Name = "listViewTeacher";
            this.listViewTeacher.Size = new System.Drawing.Size(497, 238);
            this.listViewTeacher.TabIndex = 1;
            this.listViewTeacher.UseCompatibleStateImageBehavior = false;
            this.listViewTeacher.View = System.Windows.Forms.View.Details;
            this.listViewTeacher.SelectedIndexChanged += new System.EventHandler(this.listViewStudent_SelectedIndexChanged);
            // 
            // columnTeacher
            // 
            this.columnTeacher.Text = "Код учителя";
            this.columnTeacher.Width = 82;
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
            // columnMail
            // 
            this.columnMail.Text = "Электронная почта";
            this.columnMail.Width = 117;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(9, 25);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(56, 13);
            this.labelSurname.TabIndex = 2;
            this.labelSurname.Text = "Фамилия";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(12, 41);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(9, 81);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Имя";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 97);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 7;
            // 
            // labelMiddle
            // 
            this.labelMiddle.AutoSize = true;
            this.labelMiddle.Location = new System.Drawing.Point(9, 143);
            this.labelMiddle.Name = "labelMiddle";
            this.labelMiddle.Size = new System.Drawing.Size(54, 13);
            this.labelMiddle.TabIndex = 8;
            this.labelMiddle.Text = "Отчество";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(9, 214);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(104, 13);
            this.labelMail.TabIndex = 9;
            this.labelMail.Text = "Электронная почта";
            // 
            // textBoxMiddle
            // 
            this.textBoxMiddle.Location = new System.Drawing.Point(12, 159);
            this.textBoxMiddle.Name = "textBoxMiddle";
            this.textBoxMiddle.Size = new System.Drawing.Size(100, 20);
            this.textBoxMiddle.TabIndex = 10;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(12, 230);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(100, 20);
            this.textBoxMail.TabIndex = 11;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(268, 259);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(115, 32);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(389, 259);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(115, 32);
            this.buttonEdit.TabIndex = 17;
            this.buttonEdit.Text = "Изменить ";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(510, 259);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(115, 32);
            this.buttonDel.TabIndex = 18;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 304);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxMiddle);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelMiddle);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.listViewTeacher);
            this.Name = "FormTeacher";
            this.Text = "Учитель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewTeacher;
        private System.Windows.Forms.ColumnHeader columnTeacher;
        private System.Windows.Forms.ColumnHeader columnSurname;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnMiddle;
        private System.Windows.Forms.ColumnHeader columnMail;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelMiddle;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.TextBox textBoxMiddle;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
    }
}