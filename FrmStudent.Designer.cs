namespace StudentInfo
{
    partial class frmStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dGVStudentList = new System.Windows.Forms.DataGridView();
            this.studentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.Button();
            this.picStudent = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVStudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Birth Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(102, 15);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(256, 20);
            this.txtId.TabIndex = 5;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(102, 42);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(256, 20);
            this.txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(102, 72);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(256, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(102, 98);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(256, 20);
            this.txtBirthDate.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(102, 128);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(256, 20);
            this.txtAddress.TabIndex = 9;
            // 
            // dGVStudentList
            // 
            this.dGVStudentList.AllowUserToAddRows = false;
            this.dGVStudentList.AllowUserToDeleteRows = false;
            this.dGVStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVStudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentId,
            this.firstName,
            this.lastName,
            this.birthdate,
            this.address});
            this.dGVStudentList.Location = new System.Drawing.Point(102, 251);
            this.dGVStudentList.Name = "dGVStudentList";
            this.dGVStudentList.ReadOnly = true;
            this.dGVStudentList.Size = new System.Drawing.Size(666, 187);
            this.dGVStudentList.TabIndex = 10;
            // 
            // studentId
            // 
            this.studentId.HeaderText = "Student Id";
            this.studentId.Name = "studentId";
            this.studentId.ReadOnly = true;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "First Name";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Last Name";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // birthdate
            // 
            this.birthdate.HeaderText = "Birth Date";
            this.birthdate.Name = "birthdate";
            this.birthdate.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(102, 154);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(256, 23);
            this.Add.TabIndex = 11;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // picStudent
            // 
            this.picStudent.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picStudent.Location = new System.Drawing.Point(426, 12);
            this.picStudent.Name = "picStudent";
            this.picStudent.Size = new System.Drawing.Size(170, 159);
            this.picStudent.TabIndex = 12;
            this.picStudent.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(426, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.picStudent);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dGVStudentList);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmStudent";
            this.Text = "Student Info";
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVStudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DataGridView dGVStudentList;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.PictureBox picStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

