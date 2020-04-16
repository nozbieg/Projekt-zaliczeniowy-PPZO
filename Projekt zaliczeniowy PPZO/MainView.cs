﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//SYSTEM DO OBSŁUGI KADRY PRZEDSIĘBIORSTWA
namespace Projekt_zaliczeniowy_PPZO
{
    public partial class MainView : Form
    {
        public List<Position> personList = new List<Position>();

        public MainView()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_addWorker_Click(object sender, EventArgs e)
        {
            addForm addForm = new addForm();
            addForm.Owner = this;
            try
            {
                addForm.ShowDialog();
            }
            finally
            {
                addForm.Dispose();

            }
            RefreshWorkers();
            
        }

        private void listView_Person_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_showList_XX_Click(object sender, EventArgs e)
        {
            
                MessageBox.Show("workers Loaded");
            

        }

        private void RefreshWorkers()
        {
            dataGridView_Persons.Rows.Clear();

            foreach (Position pos in personList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView_Persons);
                row.Cells[0].Value = pos.ReturnId();
                row.Cells[1].Value = pos.ReturnFirstName();
                row.Cells[2].Value = pos.ReturnSecondName();
                row.Cells[3].Value = pos.ReturnPersonPosition();
                dataGridView_Persons.Rows.Add(row);
            }
        }

        private void btn_DeleteWorker_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.Owner = this;
            try
            {
                deleteForm.ShowDialog();
            }
            finally
            {
                deleteForm.Dispose();

            }
            RefreshWorkers();
        }

        private void btn_SearchWorker_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Owner = this;
            try
            {
                searchForm.ShowDialog();
            }
            finally
            {
                searchForm.Dispose();

            }
        }
    }
}