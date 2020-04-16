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
            this.txtBox_PersonPosition = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.secondName = new System.Windows.Forms.Label();
            this.personPosition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_addWorker
            // 
            this.btn_addWorker.Location = new System.Drawing.Point(107, 132);
            this.btn_addWorker.Name = "btn_addWorker";
            this.btn_addWorker.Size = new System.Drawing.Size(100, 23);
            this.btn_addWorker.TabIndex = 0;
            this.btn_addWorker.Text = "btn_addWorker";
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
            // txtBox_PersonPosition
            // 
            this.txtBox_PersonPosition.Location = new System.Drawing.Point(107, 83);
            this.txtBox_PersonPosition.Name = "txtBox_PersonPosition";
            this.txtBox_PersonPosition.Size = new System.Drawing.Size(100, 20);
            this.txtBox_PersonPosition.TabIndex = 3;
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
            this.personPosition.Location = new System.Drawing.Point(21, 86);
            this.personPosition.Name = "personPosition";
            this.personPosition.Size = new System.Drawing.Size(80, 13);
            this.personPosition.TabIndex = 6;
            this.personPosition.Text = "Person Position";
            // 
            // addForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 180);
            this.Controls.Add(this.personPosition);
            this.Controls.Add(this.secondName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.txtBox_PersonPosition);
            this.Controls.Add(this.txtBox_SecondName);
            this.Controls.Add(this.txtBox_FirstName);
            this.Controls.Add(this.btn_addWorker);
            this.Name = "addForm";
            this.Text = "addForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addWorker;
        private System.Windows.Forms.TextBox txtBox_FirstName;
        private System.Windows.Forms.TextBox txtBox_SecondName;
        private System.Windows.Forms.TextBox txtBox_PersonPosition;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label secondName;
        private System.Windows.Forms.Label personPosition;
    }
}