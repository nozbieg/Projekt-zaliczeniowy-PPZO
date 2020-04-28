namespace Projekt_zaliczeniowy_PPZO
{
    partial class BonusForm
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
            this.lbl_EmployeeID = new System.Windows.Forms.Label();
            this.lbl_Bonus = new System.Windows.Forms.Label();
            this.txtBox_EmployeeID = new System.Windows.Forms.TextBox();
            this.txtBox_Bonus = new System.Windows.Forms.TextBox();
            this.btv_Bonus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_EmployeeID
            // 
            this.lbl_EmployeeID.AutoSize = true;
            this.lbl_EmployeeID.Location = new System.Drawing.Point(13, 31);
            this.lbl_EmployeeID.Name = "lbl_EmployeeID";
            this.lbl_EmployeeID.Size = new System.Drawing.Size(67, 13);
            this.lbl_EmployeeID.TabIndex = 0;
            this.lbl_EmployeeID.Text = "Employee ID";
            // 
            // lbl_Bonus
            // 
            this.lbl_Bonus.AutoSize = true;
            this.lbl_Bonus.Location = new System.Drawing.Point(43, 64);
            this.lbl_Bonus.Name = "lbl_Bonus";
            this.lbl_Bonus.Size = new System.Drawing.Size(37, 13);
            this.lbl_Bonus.TabIndex = 1;
            this.lbl_Bonus.Text = "Bonus";
            // 
            // txtBox_EmployeeID
            // 
            this.txtBox_EmployeeID.Location = new System.Drawing.Point(86, 28);
            this.txtBox_EmployeeID.Name = "txtBox_EmployeeID";
            this.txtBox_EmployeeID.Size = new System.Drawing.Size(100, 20);
            this.txtBox_EmployeeID.TabIndex = 2;
            // 
            // txtBox_Bonus
            // 
            this.txtBox_Bonus.Location = new System.Drawing.Point(86, 61);
            this.txtBox_Bonus.Name = "txtBox_Bonus";
            this.txtBox_Bonus.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Bonus.TabIndex = 3;
            // 
            // btv_Bonus
            // 
            this.btv_Bonus.Location = new System.Drawing.Point(16, 104);
            this.btv_Bonus.Name = "btv_Bonus";
            this.btv_Bonus.Size = new System.Drawing.Size(170, 23);
            this.btv_Bonus.TabIndex = 4;
            this.btv_Bonus.Text = "GiveBonus";
            this.btv_Bonus.UseVisualStyleBackColor = true;
            this.btv_Bonus.Click += new System.EventHandler(this.btv_Bonus_Click);
            // 
            // BonusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 148);
            this.Controls.Add(this.btv_Bonus);
            this.Controls.Add(this.txtBox_Bonus);
            this.Controls.Add(this.txtBox_EmployeeID);
            this.Controls.Add(this.lbl_Bonus);
            this.Controls.Add(this.lbl_EmployeeID);
            this.Name = "BonusForm";
            this.Text = "Give bonus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_EmployeeID;
        private System.Windows.Forms.Label lbl_Bonus;
        private System.Windows.Forms.TextBox txtBox_EmployeeID;
        private System.Windows.Forms.TextBox txtBox_Bonus;
        private System.Windows.Forms.Button btv_Bonus;
    }
}