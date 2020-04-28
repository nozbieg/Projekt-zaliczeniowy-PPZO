namespace Projekt_zaliczeniowy_PPZO
{
    partial class MainView
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_addWorker = new System.Windows.Forms.Button();
            this.dataGridView_Persons = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_DeleteWorker = new System.Windows.Forms.Button();
            this.btn_SearchWorker = new System.Windows.Forms.Button();
            this.textBox_SearchBox = new System.Windows.Forms.TextBox();
            this.btn_ClearSearch = new System.Windows.Forms.Button();
            this.lbl_SearchByName = new System.Windows.Forms.Label();
            this.btn_GiveBonus = new System.Windows.Forms.Button();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Persons)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_addWorker
            // 
            this.btn_addWorker.Location = new System.Drawing.Point(24, 21);
            this.btn_addWorker.Name = "btn_addWorker";
            this.btn_addWorker.Size = new System.Drawing.Size(75, 23);
            this.btn_addWorker.TabIndex = 3;
            this.btn_addWorker.Text = "Add Employee";
            this.btn_addWorker.UseVisualStyleBackColor = true;
            this.btn_addWorker.Click += new System.EventHandler(this.btn_addWorker_Click);
            // 
            // dataGridView_Persons
            // 
            this.dataGridView_Persons.AllowUserToAddRows = false;
            this.dataGridView_Persons.AllowUserToDeleteRows = false;
            this.dataGridView_Persons.AllowUserToResizeColumns = false;
            this.dataGridView_Persons.AllowUserToResizeRows = false;
            this.dataGridView_Persons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Persons.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Persons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Persons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FirstName,
            this.SecondName,
            this.Age,
            this.Salary,
            this.Position});
            this.dataGridView_Persons.Location = new System.Drawing.Point(24, 62);
            this.dataGridView_Persons.Name = "dataGridView_Persons";
            this.dataGridView_Persons.ReadOnly = true;
            this.dataGridView_Persons.Size = new System.Drawing.Size(453, 257);
            this.dataGridView_Persons.TabIndex = 6;
            this.dataGridView_Persons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Persons_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 41;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 79;
            // 
            // SecondName
            // 
            this.SecondName.HeaderText = "SecondName";
            this.SecondName.Name = "SecondName";
            this.SecondName.ReadOnly = true;
            this.SecondName.Width = 97;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 51;
            // 
            // Salary
            // 
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            this.Salary.Width = 61;
            // 
            // btn_DeleteWorker
            // 
            this.btn_DeleteWorker.Location = new System.Drawing.Point(105, 21);
            this.btn_DeleteWorker.Name = "btn_DeleteWorker";
            this.btn_DeleteWorker.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteWorker.TabIndex = 7;
            this.btn_DeleteWorker.Text = "Delete Employee";
            this.btn_DeleteWorker.UseVisualStyleBackColor = true;
            this.btn_DeleteWorker.Click += new System.EventHandler(this.btn_DeleteWorker_Click);
            // 
            // btn_SearchWorker
            // 
            this.btn_SearchWorker.Location = new System.Drawing.Point(267, 21);
            this.btn_SearchWorker.Name = "btn_SearchWorker";
            this.btn_SearchWorker.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchWorker.TabIndex = 8;
            this.btn_SearchWorker.Text = "Search";
            this.btn_SearchWorker.UseVisualStyleBackColor = true;
            this.btn_SearchWorker.Click += new System.EventHandler(this.btn_SearchWorker_Click);
            // 
            // textBox_SearchBox
            // 
            this.textBox_SearchBox.Location = new System.Drawing.Point(348, 23);
            this.textBox_SearchBox.Name = "textBox_SearchBox";
            this.textBox_SearchBox.Size = new System.Drawing.Size(129, 20);
            this.textBox_SearchBox.TabIndex = 9;
            // 
            // btn_ClearSearch
            // 
            this.btn_ClearSearch.Location = new System.Drawing.Point(186, 21);
            this.btn_ClearSearch.Name = "btn_ClearSearch";
            this.btn_ClearSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearSearch.TabIndex = 10;
            this.btn_ClearSearch.Text = "ClearSearch";
            this.btn_ClearSearch.UseVisualStyleBackColor = true;
            this.btn_ClearSearch.Click += new System.EventHandler(this.btn_ClearSearch_Click);
            // 
            // lbl_SearchByName
            // 
            this.lbl_SearchByName.AutoSize = true;
            this.lbl_SearchByName.Location = new System.Drawing.Point(345, 9);
            this.lbl_SearchByName.Name = "lbl_SearchByName";
            this.lbl_SearchByName.Size = new System.Drawing.Size(67, 13);
            this.lbl_SearchByName.TabIndex = 11;
            this.lbl_SearchByName.Text = "Search input";
            // 
            // btn_GiveBonus
            // 
            this.btn_GiveBonus.Location = new System.Drawing.Point(382, 326);
            this.btn_GiveBonus.Name = "btn_GiveBonus";
            this.btn_GiveBonus.Size = new System.Drawing.Size(95, 23);
            this.btn_GiveBonus.TabIndex = 12;
            this.btn_GiveBonus.Text = "Give Bonus";
            this.btn_GiveBonus.UseVisualStyleBackColor = true;
            this.btn_GiveBonus.Click += new System.EventHandler(this.btn_GiveBonus_Click);
            // 
            // Position
            // 
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            this.Position.Width = 69;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 361);
            this.Controls.Add(this.btn_GiveBonus);
            this.Controls.Add(this.lbl_SearchByName);
            this.Controls.Add(this.btn_ClearSearch);
            this.Controls.Add(this.textBox_SearchBox);
            this.Controls.Add(this.btn_SearchWorker);
            this.Controls.Add(this.btn_DeleteWorker);
            this.Controls.Add(this.dataGridView_Persons);
            this.Controls.Add(this.btn_addWorker);
            this.Name = "MainView";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Persons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addWorker;
        private System.Windows.Forms.DataGridView dataGridView_Persons;
        private System.Windows.Forms.Button btn_DeleteWorker;
        private System.Windows.Forms.Button btn_SearchWorker;
        private System.Windows.Forms.TextBox textBox_SearchBox;
        private System.Windows.Forms.Button btn_ClearSearch;
        private System.Windows.Forms.Label lbl_SearchByName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.Button btn_GiveBonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
    }
}

