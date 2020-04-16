namespace Projekt_zaliczeniowy_PPZO
{
    partial class DeleteForm
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
            this.btn_DeleteWorker = new System.Windows.Forms.Button();
            this.textBox_WorkerId = new System.Windows.Forms.TextBox();
            this.WorkerID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_DeleteWorker
            // 
            this.btn_DeleteWorker.Location = new System.Drawing.Point(15, 76);
            this.btn_DeleteWorker.Name = "btn_DeleteWorker";
            this.btn_DeleteWorker.Size = new System.Drawing.Size(226, 23);
            this.btn_DeleteWorker.TabIndex = 0;
            this.btn_DeleteWorker.Text = "btn_DeleteWorker";
            this.btn_DeleteWorker.UseVisualStyleBackColor = true;
            this.btn_DeleteWorker.Click += new System.EventHandler(this.btn_DeleteWorker_Click);
            // 
            // textBox_WorkerId
            // 
            this.textBox_WorkerId.Location = new System.Drawing.Point(71, 33);
            this.textBox_WorkerId.Name = "textBox_WorkerId";
            this.textBox_WorkerId.Size = new System.Drawing.Size(170, 20);
            this.textBox_WorkerId.TabIndex = 1;
            // 
            // WorkerID
            // 
            this.WorkerID.AutoSize = true;
            this.WorkerID.Location = new System.Drawing.Point(12, 36);
            this.WorkerID.Name = "WorkerID";
            this.WorkerID.Size = new System.Drawing.Size(53, 13);
            this.WorkerID.TabIndex = 2;
            this.WorkerID.Text = "WorkerID";
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 118);
            this.Controls.Add(this.WorkerID);
            this.Controls.Add(this.textBox_WorkerId);
            this.Controls.Add(this.btn_DeleteWorker);
            this.Name = "DeleteForm";
            this.Text = "DeleteForm";
            this.Load += new System.EventHandler(this.DeleteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_DeleteWorker;
        private System.Windows.Forms.TextBox textBox_WorkerId;
        private System.Windows.Forms.Label WorkerID;
    }
}