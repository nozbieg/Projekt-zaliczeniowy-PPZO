using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_zaliczeniowy_PPZO
{
    //Autor: Norbert Olesiak-Zbieg, GL01, Informatyka 2 semestr - zaocznie
    //Klasa Manager dziedzicząca
    public class Manager : Employee
    {
        //pole Stock - Tylko dla Managera - ilości dostępnych marketów*       
        public int StockOptions {get; set;}
        //Konstruktor przeciążony
        public Manager(string imie, string nazwisko, int age, double salary, int stock) 
        {
            
            this.ID = GetNextId();
            this.FirstName = imie;
            this.SecondName = nazwisko;
            this.Age = age;
            this.Salary = salary;
            this.StockOptions = stock;
            this.Position = "Manager";
        }
        //Kontruktor domyslny
        public Manager()
        {
            this.ID = GetNextId();
            this.FirstName = "Brak";
            this.SecondName = "Brak";
            this.Age = 0;
            this.Salary = 0;
            this.StockOptions = 0;
            this.Position = "Manager";
        }
        //Metoda GiveBonus polimorfująca bazową metodę. Sposób liczenia bonusu dla Managera jest inny niż dla klasy employee lub sales person
        public override void GiveBonus(int bonus)
        {
            // Random r = new Random();
            this.StockOptions += 50; //r.Next(500);
            base.GiveBonus(bonus + (this.StockOptions*2));               
        }
        

              
       





    }
}
