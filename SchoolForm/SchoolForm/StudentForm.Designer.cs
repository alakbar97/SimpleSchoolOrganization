namespace SchoolForm
{
    partial class StudentForm
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
            this.cmbc_Class = new System.Windows.Forms.ComboBox();
            this.cmbx_Teacher = new System.Windows.Forms.ComboBox();
            this.cmbx_Subject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbc_Class
            // 
            this.cmbc_Class.DisplayMember = "1";
            this.cmbc_Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbc_Class.FormattingEnabled = true;
            this.cmbc_Class.Location = new System.Drawing.Point(84, 87);
            this.cmbc_Class.Name = "cmbc_Class";
            this.cmbc_Class.Size = new System.Drawing.Size(121, 21);
            this.cmbc_Class.TabIndex = 0;
            this.cmbc_Class.SelectedIndexChanged += new System.EventHandler(this.cmbc_Class_SelectedIndexChanged);
            this.cmbc_Class.SelectionChangeCommitted += new System.EventHandler(this.cmbc_Class_SelectionChangeCommitted);
            // 
            // cmbx_Teacher
            // 
            this.cmbx_Teacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_Teacher.FormattingEnabled = true;
            this.cmbx_Teacher.Location = new System.Drawing.Point(84, 249);
            this.cmbx_Teacher.Name = "cmbx_Teacher";
            this.cmbx_Teacher.Size = new System.Drawing.Size(121, 21);
            this.cmbx_Teacher.TabIndex = 0;
            // 
            // cmbx_Subject
            // 
            this.cmbx_Subject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_Subject.FormattingEnabled = true;
            this.cmbx_Subject.Location = new System.Drawing.Point(84, 172);
            this.cmbx_Subject.Name = "cmbx_Subject";
            this.cmbx_Subject.Size = new System.Drawing.Size(121, 21);
            this.cmbx_Subject.TabIndex = 0;
            this.cmbx_Subject.SelectionChangeCommitted += new System.EventHandler(this.cmbx_Subject_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teacher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Subject";
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(84, 326);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(121, 31);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add Class";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 450);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbx_Subject);
            this.Controls.Add(this.cmbx_Teacher);
            this.Controls.Add(this.cmbc_Class);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbc_Class;
        private System.Windows.Forms.ComboBox cmbx_Teacher;
        private System.Windows.Forms.ComboBox cmbx_Subject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Add;
    }
}