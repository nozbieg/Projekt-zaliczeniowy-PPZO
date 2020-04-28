namespace Projekt_zaliczeniowy_PPZO
{
    partial class addForm
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
            this.btn_addWorker = new System.Windows.Forms.Button();
            this.txtBox_FirstName = new System.Windows.Forms.TextBox();
            this.txtBox_SecondName = new System.Windows.Forms.TextBox();
            this.txtBox_Age = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.secondName = new System.Windows.Forms.Label();
            this.personPosition = new System.Windows.Forms.Label();
            this.textBox_Salary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtn_SalesPerson = new System.Windows.Forms.RadioButton();
            this.rBtn_Manager = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_addWorker
            // 
            this.btn_addWorker.Location = new System.Drawing.Point(107, 193);
            this.btn_addWorker.Name = "btn_addWorker";
            this.btn_addWorker.Size = new System.Drawing.Size(100, 23);
            this.btn_addWorker.TabIndex = 0;
            this.btn_addWorker.Text = "AddEmploye";
            this.btn_addWorker.UseVisualStyleBackColor = true;
            this.btn_addWorker.Click += new System.EventHandler(this.btn_addWorker_Click);
            // 
            // txtBox_FirstName
            // 
            this.txtBox_FirstName.Location = new System.Drawing.Point(107, 29);
            this.txtBox_FirstName.Name = "txtBox_FirstName";
            this.txtBox_FirstName.Size = new System.Drawing.Size(100, 20);
            this.txtBox_FirstName.TabIndex = 1;
            // 
            // txtBox_SecondName
            // 
            this.txtBox_SecondName.Location = new System.Drawing.Point(107, 56);
            this.txtBox_SecondName.Name = "txtBox_SecondName";
            this.txtBox_SecondName.Size = new System.Drawing.Size(100, 20);
            this.txtBox_SecondName.TabIndex = 2;
            // 
            // txtBox_Age
            // 
            this.txtBox_Age.Location = new System.Drawing.Point(107, 83);
            this.txtBox_Age.Name = "txtBox_Age";
            this.txtBox_Age.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Age.TabIndex = 3;
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(44, 32);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(57, 13);
            this.firstName.TabIndex = 4;
            this.firstName.Text = "First Name";
            // 
            // secondName
            // 
            this.secondName.AutoSize = true;
            this.secondName.Location = new System.Drawing.Point(26, 59);
            this.secondName.Name = "secondName";
            this.secondName.Size = new System.Drawing.Size(75, 13);
            this.secondName.TabIndex = 5;
            this.secondName.Text = "Second Name";
            // 
            // personPosition
            // 
            this.personPosition.AutoSize = true;
            this.personPosition.Location = new System.Drawing.Point(75, 86);
            this.personPosition.Name = "personPosition";
            this.personPosition.Size = new System.Drawing.Size(26, 13);
            this.personPosition.TabIndex = 6;
            this.personPosition.Text = "Age";
            this.personPosition.Click += new System.EventHandler(this.personPosition_Click);
            // 
            // textBox_Salary
            // 
            this.textBox_Salary.Location = new System.Drawing.Point(107, 109);
            this.textBox_Salary.Name = "textBox_Salary";
            this.textBox_Salary.Size = new System.Drawing.Size(100, 20);
            this.textBox_Salary.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Salary";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtn_SalesPerson);
            this.groupBox1.Controls.Add(this.rBtn_Manager);
            this.groupBox1.Location = new System.Drawing.Point(107, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 52);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rBtn_SalesPerson
            // 
            this.rBtn_SalesPerson.AutoSize = true;
            this.rBtn_SalesPerson.Location = new System.Drawing.Point(7, 26);
            this.rBtn_SalesPerson.Name = "rBtn_SalesPerson";
            this.rBtn_SalesPerson.Size = new System.Drawing.Size(87, 17);
            this.rBtn_SalesPerson.TabIndex = 1;
            this.rBtn_SalesPerson.TabStop = true;
            this.rBtn_SalesPerson.Text = "Sales Person";
            this.rBtn_SalesPerson.UseVisualStyleBackColor = true;
            // 
            // rBtn_Manager
            // 
            this.rBtn_Manager.AutoSize = true;
            this.rBtn_Manager.Location = new System.Drawing.Point(7, 9);
            this.rBtn_Manager.Name = "rBtn_Manager";
            this.rBtn_Manager.Size = new System.Drawing.Size(67, 17);
            this.rBtn_Manager.TabIndex = 0;
            this.rBtn_Manager.TabStop = true;
            this.rBtn_Manager.Text = "Manager";
            this.rBtn_Manager.UseVisualStyleBackColor = true;
            // 
            // addForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 229);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Salary);
            this.Controls.Add(this.personPosition);
            this.Controls.Add(this.secondName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.txtBox_Age);
            this.Controls.Add(this.txtBox_SecondName);
            this.Controls.Add(this.txtBox_FirstName);
            this.Controls.Add(this.btn_addWorker);
            this.Name = "addForm";
            this.Text = "add Employee";
            this.Load += new System.EventHandler(this.addForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addWorker;
        private System.Windows.Forms.TextBox txtBox_FirstName;
        private System.Windows.Forms.TextBox txtBox_SecondName;
        private System.Windows.Forms.TextBox txtBox_Age;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label secondName;
        private System.Windows.Forms.Label personPosition;
        private System.Windows.Forms.TextBox textBox_Salary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtn_Manager;
        private System.Windows.Forms.RadioButton rBtn_SalesPerson;
    }
}