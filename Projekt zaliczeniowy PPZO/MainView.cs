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
        public List<Employee> personList = new List<Employee>();

        public MainView()
        {
            InitializeComponent();
           
        }

        private void PrintList(Employee item)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridView_Persons);
            row.Cells[0].Value = item.ID;
            row.Cells[1].Value = item.FirstName;
            row.Cells[2].Value = item.SecondName;
            row.Cells[3].Value = item.Age;
            row.Cells[4].Value = item.Salary;
            dataGridView_Persons.Rows.Add(row);
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

            foreach (Employee pos in personList)
            {
                PrintList(pos);
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
            dataGridView_Persons.Rows.Clear();
            List<Employee> found = personList.FindAll(x => x.FirstName == textBox_SearchBox.Text);
            foreach (Employee f in found)
            {
                PrintList(f);
            }



            
        }

        private void btn_ClearSearch_Click(object sender, EventArgs e)
        {
            RefreshWorkers();
        }

        private void btn_GiveBonus_Click(object sender, EventArgs e)
        {
            BonusForm bonusForm = new BonusForm();
            bonusForm.Owner = this;
            try
            {
                bonusForm.ShowDialog();
            }
            finally
            {
                bonusForm.Dispose();

            }
            RefreshWorkers();
        }
    }
}
