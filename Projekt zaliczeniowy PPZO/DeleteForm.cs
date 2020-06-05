using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Autor: Norbert Olesiak-Zbieg, GL01, Informatyka 2 semestr - zaocznie
namespace Projekt_zaliczeniowy_PPZO
{
    //Formularz kasowania obiektu z listy
    public partial class DeleteForm : Form
    {
        
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_DeleteWorker_Click(object sender, EventArgs e)
        {

            var mainViewForm = (MainView)this.Owner;
            try
            {
                //kasuje element o podanym id z listy
                var item = mainViewForm.personList.SingleOrDefault(x => x.ID == int.Parse(textBox_WorkerId.Text));
                if (item != null)
                {
                    mainViewForm.personList.Remove(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            this.Close();
        }
    }
}
