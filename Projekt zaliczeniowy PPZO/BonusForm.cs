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
    public partial class BonusForm : Form
    {
        public BonusForm()
        {
            InitializeComponent();
        }

        private void btv_Bonus_Click(object sender, EventArgs e)
        {
            var mainViewForm = (MainView)this.Owner;
            try
            {

                var item = mainViewForm.personList.SingleOrDefault(x => x.ID == int.Parse(txtBox_EmployeeID.Text));
                if (item != null)
                {
                    item.GiveBonus(int.Parse(txtBox_Bonus.Text));
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
