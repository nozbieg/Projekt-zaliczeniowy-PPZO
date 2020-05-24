using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_zaliczeniowy_PPZO
{
    // Głowna klasa abstrakcyjna (istnieje ale nie można stworzyć obiektu tej klasy, służy tylko do dziedziczenia po niej) Employee ( Pracownicy )
    public abstract class Employee
    {
        
        //prywatne pole trzymające ID do słuzy do inkrementacji
        private static int currentId;

        //pola wykorzystywane w klasie Pracownik -
         public int ID { get; set; } //Nadawane w auto inkrementacji
         public string FirstName { get; set; } //imie
         public string SecondName { get; set; } //nazwisko
         public int Age { get; set; } //wiek
         public double Salary { get; set; } //wypłata
         public string Position { get; set; } //stanowisko

        //Konstruktor domyślny
        public Employee()
        {
            this.ID = 0;
            this.FirstName = "Brak";
            this.SecondName = "Brak";
            this.Age = 0;
            this.Salary = 0;
            this.Position = "Brak";
        }

        //konstruktor przeciazony
        public Employee(string imie, string nazwisko, int age, double salary, string pos)
        {
            this.ID = GetNextId();
            this.FirstName = imie;
            this.SecondName = nazwisko;
            this.Age = age;
            this.Salary = salary;
            this.Position = Position;
        }

        //Wywołanie pola current id przy wywołaniu konstruktora
        static Employee() => currentId = 0;
        //Metoda autoinkrementująca ID
        protected int GetNextId() => ++currentId;

        //Metoda virtualna przyznająca bonus do wypłaty dla pracownika
        public virtual void GiveBonus(int bonus)
        {
            this.Salary += bonus;
        }

    }
}
