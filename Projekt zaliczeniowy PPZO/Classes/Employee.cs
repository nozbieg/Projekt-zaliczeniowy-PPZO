using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_zaliczeniowy_PPZO
{
    public abstract class Employee
    {
        

        private static int currentId;

         public int ID { get; set; }
         public string FirstName { get; set; }
         public string SecondName { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public Employee()
        {
            this.ID = 0;
            this.FirstName = "Brak";
            this.SecondName = "Brak";
            this.Age = 0;
            this.Salary = 0;
        }

        public Employee(string imie, string nazwisko, int age, double salary)
        {
            this.ID = GetNextId();
            this.FirstName = imie;
            this.SecondName = nazwisko;
            this.Age = age;
            this.Salary = salary;
        }

        static Employee() => currentId = 0;
        protected int GetNextId() => ++currentId;

  
        public virtual void GiveBonus(int bonus)
        {
            this.Salary += bonus;
        }

    }
}
