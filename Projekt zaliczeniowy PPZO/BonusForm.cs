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
    //Formularz dodawania bonusu pracownikowi
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
                //pobieram id pracownika
                var item = mainViewForm.personList.SingleOrDefault(x => x.ID == int.Parse(txtBox_EmployeeID.Text));
                if (item != null) //jezeli id istnieje
                {
                    //daje bonus uzywając metody GiveBonus (zadeklarowanej w klasach Employee oraz Manager i SalesPerson z innym działaniem
                    item.GiveBonus(int.Parse(txtBox_Bonus.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            this.Close();
        }

        private void BonusForm_Load(object sender, EventArgs e)
        {

        }
    }
}
