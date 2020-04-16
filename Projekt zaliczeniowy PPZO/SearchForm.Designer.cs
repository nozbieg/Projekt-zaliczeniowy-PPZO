namespace Projekt_zaliczeniowy_PPZO
{
    partial class SearchForm
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
            this.dataGridView_Persons = new System.Windows.Forms.DataGridView();
            this.WorkerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchBy = new System.Windows.Forms.Label();
            this.chckBox_workerId = new System.Windows.Forms.CheckBox();
            this.chckBox_firstName = new System.Windows.Forms.CheckBox();
            this.chckBox_secondName = new System.Windows.Forms.CheckBox();
            this.chckBox_PersonPosition = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_SearchWorker = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Persons)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Persons
            // 
            this.dataGridView_Persons.AllowUserToAddRows = false;
            this.dataGridView_Persons.AllowUserToDeleteRows = false;
            this.dataGridView_Persons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Persons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WorkerID,
            this.FirstName,
            this.SecondName,
            this.PersonPosition});
            this.dataGridView_Persons.Location = new System.Drawing.Point(32, 32);
            this.dataGridView_Persons.Name = "dataGridView_Persons";
            this.dataGridView_Persons.ReadOnly = true;
            this.dataGridView_Persons.Size = new System.Drawing.Size(454, 150);
            this.dataGridView_Persons.TabIndex = 0;
            // 
            // WorkerID
            // 
            this.WorkerID.HeaderText = "WorkerID";
            this.WorkerID.Name = "WorkerID";
            this.WorkerID.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // SecondName
            // 
            this.SecondName.HeaderText = "SecondName";
            this.SecondName.Name = "SecondName";
            this.SecondName.ReadOnly = true;
            // 
            // PersonPosition
            // 
            this.PersonPosition.HeaderText = "PersonPosition";
            this.PersonPosition.Name = "PersonPosition";
            this.PersonPosition.ReadOnly = true;
            // 
            // SearchBy
            // 
            this.SearchBy.AutoSize = true;
            this.SearchBy.Location = new System.Drawing.Point(29, 209);
            this.SearchBy.Name = "SearchBy";
            this.SearchBy.Size = new System.Drawing.Size(56, 13);
            this.SearchBy.TabIndex = 1;
            this.SearchBy.Text = "SearchBy:";
            // 
            // chckBox_workerId
            // 
            this.chckBox_workerId.AutoSize = true;
            this.chckBox_workerId.Location = new System.Drawing.Point(32, 231);
            this.chckBox_workerId.Name = "chckBox_workerId";
            this.chckBox_workerId.Size = new System.Drawing.Size(72, 17);
            this.chckBox_workerId.TabIndex = 6;
            this.chckBox_workerId.Text = "WorkerID";
            this.chckBox_workerId.UseVisualStyleBackColor = true;
            // 
            // chckBox_firstName
            // 
            this.chckBox_firstName.AutoSize = true;
            this.chckBox_firstName.Location = new System.Drawing.Point(32, 253);
            this.chckBox_firstName.Name = "chckBox_firstName";
            this.chckBox_firstName.Size = new System.Drawing.Size(73, 17);
            this.chckBox_firstName.TabIndex = 7;
            this.chckBox_firstName.Text = "FirstName";
            this.chckBox_firstName.UseVisualStyleBackColor = true;
            // 
            // chckBox_secondName
            // 
            this.chckBox_secondName.AutoSize = true;
            this.chckBox_secondName.Location = new System.Drawing.Point(32, 276);
            this.chckBox_secondName.Name = "chckBox_secondName";
            this.chckBox_secondName.Size = new System.Drawing.Size(91, 17);
            this.chckBox_secondName.TabIndex = 8;
            this.chckBox_secondName.Text = "SecondName";
            this.chckBox_secondName.UseVisualStyleBackColor = true;
            // 
            // chckBox_PersonPosition
            // 
            this.chckBox_PersonPosition.AutoSize = true;
            this.chckBox_PersonPosition.Location = new System.Drawing.Point(32, 299);
            this.chckBox_PersonPosition.Name = "chckBox_PersonPosition";
            this.chckBox_PersonPosition.Size = new System.Drawing.Size(96, 17);
            this.chckBox_PersonPosition.TabIndex = 9;
            this.chckBox_PersonPosition.Text = "PersonPosition";
            this.chckBox_PersonPosition.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 322);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 10;
            // 
            // btn_SearchWorker
            // 
            this.btn_SearchWorker.Location = new System.Drawing.Point(32, 348);
            this.btn_SearchWorker.Name = "btn_SearchWorker";
            this.btn_SearchWorker.Size = new System.Drawing.Size(110, 23);
            this.btn_SearchWorker.TabIndex = 11;
            this.btn_SearchWorker.Text = "btn_searchWorker";
            this.btn_SearchWorker.UseVisualStyleBackColor = true;
            this.btn_SearchWorker.Click += new System.EventHandler(this.btn_SearchWorker_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.checkedListBox1.Items.AddRange(new object[] {
            "WorkerId",
            "FirstName",
            "SecondName",
            "PersonPosition"});
            this.checkedListBox1.Location = new System.Drawing.Point(192, 231);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 12;
            this.checkedListBox1.UseTabStops = false;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btn_SearchWorker);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chckBox_PersonPosition);
            this.Controls.Add(this.chckBox_secondName);
            this.Controls.Add(this.chckBox_firstName);
            this.Controls.Add(this.chckBox_workerId);
            this.Controls.Add(this.SearchBy);
            this.Controls.Add(this.dataGridView_Persons);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Persons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Persons;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonPosition;
        private System.Windows.Forms.Label SearchBy;
        private System.Windows.Forms.CheckBox chckBox_workerId;
        private System.Windows.Forms.CheckBox chckBox_firstName;
        private System.Windows.Forms.CheckBox chckBox_secondName;
        private System.Windows.Forms.CheckBox chckBox_PersonPosition;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_SearchWorker;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}