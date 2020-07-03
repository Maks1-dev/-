namespace Школа
{
    partial class FormMenu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonStudent = new System.Windows.Forms.Button();
            this.buttonTeacher = new System.Windows.Forms.Button();
            this.buttonObjekt = new System.Windows.Forms.Button();
            this.buttonControl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Школа.Properties.Resources.шк;
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonStudent
            // 
            this.buttonStudent.Location = new System.Drawing.Point(27, 158);
            this.buttonStudent.Name = "buttonStudent";
            this.buttonStudent.Size = new System.Drawing.Size(171, 40);
            this.buttonStudent.TabIndex = 1;
            this.buttonStudent.Text = "Ученики";
            this.buttonStudent.UseVisualStyleBackColor = true;
            this.buttonStudent.Click += new System.EventHandler(this.buttonStudent_Click);
            // 
            // buttonTeacher
            // 
            this.buttonTeacher.Location = new System.Drawing.Point(27, 204);
            this.buttonTeacher.Name = "buttonTeacher";
            this.buttonTeacher.Size = new System.Drawing.Size(171, 40);
            this.buttonTeacher.TabIndex = 2;
            this.buttonTeacher.Text = "Учителя";
            this.buttonTeacher.UseVisualStyleBackColor = true;
            this.buttonTeacher.Click += new System.EventHandler(this.buttonTeacher_Click);
            // 
            // buttonObjekt
            // 
            this.buttonObjekt.Location = new System.Drawing.Point(27, 250);
            this.buttonObjekt.Name = "buttonObjekt";
            this.buttonObjekt.Size = new System.Drawing.Size(171, 40);
            this.buttonObjekt.TabIndex = 3;
            this.buttonObjekt.Text = "Предметы";
            this.buttonObjekt.UseVisualStyleBackColor = true;
            this.buttonObjekt.Click += new System.EventHandler(this.buttonObjekt_Click);
            // 
            // buttonControl
            // 
            this.buttonControl.Location = new System.Drawing.Point(27, 296);
            this.buttonControl.Name = "buttonControl";
            this.buttonControl.Size = new System.Drawing.Size(171, 40);
            this.buttonControl.TabIndex = 4;
            this.buttonControl.Text = "Оценки";
            this.buttonControl.UseVisualStyleBackColor = true;
            this.buttonControl.Click += new System.EventHandler(this.buttonControl_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(223, 352);
            this.Controls.Add(this.buttonControl);
            this.Controls.Add(this.buttonObjekt);
            this.Controls.Add(this.buttonTeacher);
            this.Controls.Add(this.buttonStudent);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormMenu";
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonStudent;
        private System.Windows.Forms.Button buttonTeacher;
        private System.Windows.Forms.Button buttonObjekt;
        private System.Windows.Forms.Button buttonControl;
    }
}