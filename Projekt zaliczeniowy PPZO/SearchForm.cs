using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_zaliczeniowy_PPZO
{
    public partial class SearchForm : Form
    {
        //private void RefreshWorkers()
        //{
        //    dataGridView_Persons.Rows.Clear();

        //    foreach (Position pos in personList)
        //    {
        //        DataGridViewRow row = new DataGridViewRow();
        //        row.CreateCells(dataGridView_Persons);
        //        row.Cells[0].Value = pos.ReturnId();
        //        row.Cells[1].Value = pos.ReturnFirstName();
        //        row.Cells[2].Value = pos.ReturnSecondName();
        //        row.Cells[3].Value = pos.ReturnPersonPosition();
        //        dataGridView_Persons.Rows.Add(row);
        //    }
        //}

        public SearchForm()
        {
            InitializeComponent();
            var mainViewForm = (MainView)this.Owner;
           // RefreshWorkers();
        }

        private void btn_SearchWorker_Click(object sender, EventArgs e)
        {

        }  
    }
}
