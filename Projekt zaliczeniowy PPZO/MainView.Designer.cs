﻿namespace Projekt_zaliczeniowy_PPZO
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
            this.PersonPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_DeleteWorker = new System.Windows.Forms.Button();
            this.btn_SearchWorker = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Persons)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_addWorker
            // 
            this.btn_addWorker.Location = new System.Drawing.Point(24, 21);
            this.btn_addWorker.Name = "btn_addWorker";
            this.btn_addWorker.Size = new System.Drawing.Size(75, 23);
            this.btn_addWorker.TabIndex = 3;
            this.btn_addWorker.Text = "btn_AddWorker";
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
            this.PersonPosition});
            this.dataGridView_Persons.Location = new System.Drawing.Point(24, 62);
            this.dataGridView_Persons.Name = "dataGridView_Persons";
            this.dataGridView_Persons.ReadOnly = true;
            this.dataGridView_Persons.Size = new System.Drawing.Size(453, 271);
            this.dataGridView_Persons.TabIndex = 6;
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
            // PersonPosition
            // 
            this.PersonPosition.HeaderText = "PersonPosition";
            this.PersonPosition.Name = "PersonPosition";
            this.PersonPosition.ReadOnly = true;
            this.PersonPosition.Width = 102;
            // 
            // btn_DeleteWorker
            // 
            this.btn_DeleteWorker.Location = new System.Drawing.Point(105, 21);
            this.btn_DeleteWorker.Name = "btn_DeleteWorker";
            this.btn_DeleteWorker.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteWorker.TabIndex = 7;
            this.btn_DeleteWorker.Text = "btn_DeleteWorker";
            this.btn_DeleteWorker.UseVisualStyleBackColor = true;
            this.btn_DeleteWorker.Click += new System.EventHandler(this.btn_DeleteWorker_Click);
            // 
            // btn_SearchWorker
            // 
            this.btn_SearchWorker.Location = new System.Drawing.Point(186, 21);
            this.btn_SearchWorker.Name = "btn_SearchWorker";
            this.btn_SearchWorker.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchWorker.TabIndex = 8;
            this.btn_SearchWorker.Text = "btn_SearchWorker";
            this.btn_SearchWorker.UseVisualStyleBackColor = true;
            this.btn_SearchWorker.Click += new System.EventHandler(this.btn_SearchWorker_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 361);
            this.Controls.Add(this.btn_SearchWorker);
            this.Controls.Add(this.btn_DeleteWorker);
            this.Controls.Add(this.dataGridView_Persons);
            this.Controls.Add(this.btn_addWorker);
            this.Name = "MainView";
            this.Text = "Worker database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Persons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addWorker;
        private System.Windows.Forms.DataGridView dataGridView_Persons;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonPosition;
        private System.Windows.Forms.Button btn_DeleteWorker;
        private System.Windows.Forms.Button btn_SearchWorker;
    }
}
