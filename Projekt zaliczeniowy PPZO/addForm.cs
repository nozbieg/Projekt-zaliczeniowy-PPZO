using Projekt_zaliczeniowy_PPZO.Classes;
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
        //Formularz dodawania nowego obiektu klasy Manager lub SalesPerson. Stworzony obiekt dodaje do listy PersonList klasy Employee
        public addForm()
        {
            InitializeComponent();
        }
        
        private void btn_addWorker_Click(object sender, EventArgs e)
        {
            
            var mainViewForm = (MainView)this.Owner;
            try
            {
                //sprawdzam zaznaczony checkbox (wybraną klasę)
                if (rBtn_Manager.Checked == true || rBtn_SalesPerson.Checked == true)
                {
                    if (rBtn_Manager.Checked == true)
                    {
                        Manager menago = new Manager(txtBox_FirstName.Text, txtBox_SecondName.Text, int.Parse(txtBox_Age.Text), int.Parse(textBox_Salary.Text), 0);
                        mainViewForm.personList.Add(menago);
                        this.Close();
                    }
                    if (rBtn_SalesPerson.Checked == true)
                    {
                        SalesPerson seller = new SalesPerson(txtBox_FirstName.Text, txtBox_SecondName.Text, int.Parse(txtBox_Age.Text), int.Parse(textBox_Salary.Text), 0);
                        mainViewForm.personList.Add(seller);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Chose option");
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            
            
        }

        private void addForm_Load(object sender, EventArgs e)
        {

        }

        private void personPosition_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
