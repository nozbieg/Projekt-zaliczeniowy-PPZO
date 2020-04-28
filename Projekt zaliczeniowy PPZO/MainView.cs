using System;
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
    //metody głównego formularza
    public partial class MainView : Form
    {
        //Główny formularz tworzy kolekcje klasy Employee służaca do przechowywanie obiektów z klas dziedziczących - Lista przechowuje dodanych managerów i sprzedawców
        public List<Employee> personList = new List<Employee>();

        public MainView()
        {
            InitializeComponent();
           
        }
        //Metoda print list ładująca elementy z listy do widoku DataGrid
        private void PrintList(Employee item)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridView_Persons);
            row.Cells[0].Value = item.ID;
            row.Cells[1].Value = item.FirstName;
            row.Cells[2].Value = item.SecondName;
            row.Cells[3].Value = item.Age;
            row.Cells[4].Value = item.Salary;
            row.Cells[5].Value = item.Position;
            dataGridView_Persons.Rows.Add(row);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Akcja gdy klikamy przycisk btn_addWorker
        private void btn_addWorker_Click(object sender, EventArgs e)
        {
            //Otwieramy nowy formularz AddForm
            addForm addForm = new addForm();
            //Przekazujemy własności głównego formularza (lista PersonList)
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
        //nie używane
        private void btn_showList_XX_Click(object sender, EventArgs e)
        {
            
                MessageBox.Show("workers Loaded");
            

        }
        //metoda odświeżająca listę pracowników i wyśiwetlająca cała aktualną liste pracowników
        private void RefreshWorkers()
        {
            dataGridView_Persons.Rows.Clear();

            foreach (Employee pos in personList)
            {
                PrintList(pos);
            }
        }
        //Akcja wywoływana w momencie kliknięcia btn_DeleteWorker
        private void btn_DeleteWorker_Click(object sender, EventArgs e)
        {
            //Otwieramy formularz DeleteForm
            DeleteForm deleteForm = new DeleteForm();
            //Przekazujemy własności głównego formularza (lista PersonList)
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
        //Akcja wywoływana po kliknięciu btn_Searchworker - Wyszukująca pracownika
        private void btn_SearchWorker_Click(object sender, EventArgs e)
        {
            dataGridView_Persons.Rows.Clear(); //czyszczę aktualny DataGrid
            try
            {
                //tryparse wartośc string z pola textowego do int
                int.TryParse(textBox_SearchBox.Text, out int result);
                List<Employee> found = personList.FindAll(x => x.FirstName == textBox_SearchBox.Text
                                                            || x.SecondName == textBox_SearchBox.Text
                                                            || x.ID == result
                                                            || x.Position == textBox_SearchBox.Text);
                //Tworze nową listę Found = przypisuje do niej wartość z listy personList (Głownej listy pracowników) z metodą FindAll (Metoda klasy LIST).
                //używam lambda expression x=> x.PROPERTY (gdzie x to element listy personList). Możliwe wyszukiwanie według Propek- FirstName, SecondName, ID, Position

                //Pętla foreach wyświetlająca na nowej liscie każdy element z listy Found
                if (found.Count > 0)
                {
                    foreach (Employee fi in found)
                    {
                        PrintList(fi);
                    }
                }              
                else
                {
                    MessageBox.Show("No match in search");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        
        }
        //Akcja po kliknięciu btn_ClearSearch - 'Odświeża' widok DataGrid, ładując tam wszystkich pracowników z listy PersonList
        private void btn_ClearSearch_Click(object sender, EventArgs e)
        {
            RefreshWorkers();
        }
        //Akcja wywoływana po kliknięciu btn_GiveBonus 
        private void btn_GiveBonus_Click(object sender, EventArgs e)
        {
            //Otwieramy nowy formularz BonusForm
            BonusForm bonusForm = new BonusForm();
            //Przekazujemy własności głównego formularza (lista PersonList)
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

        private void dataGridView_Persons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
