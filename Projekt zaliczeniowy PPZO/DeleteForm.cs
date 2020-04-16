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
    public partial class DeleteForm : Form
    {
        public bool errorFlag = false;
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

                var item = mainViewForm.personList.SingleOrDefault(x => x.ReturnId() == int.Parse(textBox_WorkerId.Text));
                if (item != null)
                {
                    mainViewForm.personList.Remove(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //MessageBox.Show(pos.ReturnFirstName() + " " + pos.ReturnSecondName() + " " + pos.ReturnPersonPosition());
            this.Close();
        }
    }
}
