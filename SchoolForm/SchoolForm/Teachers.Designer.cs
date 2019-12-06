namespace SchoolForm
{
    partial class Teachers
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
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_Name = new System.Windows.Forms.TextBox();
            this.txbx_surname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmx_Subject = new System.Windows.Forms.ComboBox();
            this.btn_name = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // txbx_Name
            // 
            this.txbx_Name.Location = new System.Drawing.Point(114, 55);
            this.txbx_Name.Name = "txbx_Name";
            this.txbx_Name.Size = new System.Drawing.Size(121, 20);
            this.txbx_Name.TabIndex = 2;
            // 
            // txbx_surname
            // 
            this.txbx_surname.Location = new System.Drawing.Point(114, 137);
            this.txbx_surname.Name = "txbx_surname";
            this.txbx_surname.Size = new System.Drawing.Size(121, 20);
            this.txbx_surname.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Subject";
            // 
            // cmx_Subject
            // 
            this.cmx_Subject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmx_Subject.FormattingEnabled = true;
            this.cmx_Subject.Location = new System.Drawing.Point(114, 214);
            this.cmx_Subject.Name = "cmx_Subject";
            this.cmx_Subject.Size = new System.Drawing.Size(121, 21);
            this.cmx_Subject.TabIndex = 6;
            // 
            // btn_name
            // 
            this.btn_name.Location = new System.Drawing.Point(50, 281);
            this.btn_name.Name = "btn_name";
            this.btn_name.Size = new System.Drawing.Size(121, 23);
            this.btn_name.TabIndex = 7;
            this.btn_name.Text = "Add";
            this.btn_name.UseVisualStyleBackColor = true;
            this.btn_name.Click += new System.EventHandler(this.btn_name_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(200, 281);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(121, 23);
            this.btn_Next.TabIndex = 8;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 377);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_name);
            this.Controls.Add(this.cmx_Subject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbx_surname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_Name);
            this.Controls.Add(this.label2);
            this.Name = "Teachers";
            this.Text = "Teachers";
            this.Load += new System.EventHandler(this.Teachers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbx_Name;
        private System.Windows.Forms.TextBox txbx_surname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmx_Subject;
        private System.Windows.Forms.Button btn_name;
        private System.Windows.Forms.Button btn_Next;
    }
}