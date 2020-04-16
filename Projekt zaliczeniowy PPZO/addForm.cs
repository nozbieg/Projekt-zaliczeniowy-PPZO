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
    public partial class addForm : Form
    {
        public addForm()
        {
            InitializeComponent();
        }

        private void btn_addWorker_Click(object sender, EventArgs e)
        {
            var mainViewForm = (MainView)this.Owner;
            Position pos = new Position(txtBox_FirstName.Text, txtBox_SecondName.Text, txtBox_PersonPosition.Text);
            mainViewForm.personList.Add(pos);
            
            this.Close();
        }
    }
}
