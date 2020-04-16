using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_zaliczeniowy_PPZO
{
    public class Person
    {
        

        private static int currentId;

         protected int ID { get; set; }
         protected string FirstName { get; set; }
         protected string SecondName { get; set; }

        public Person()
        {
            this.ID = 0;
            this.FirstName = "Brak";
            this.SecondName = "Brak";
        }

        public Person(string imie, string nazwisko)
        {
            this.ID = GetNextId();
            this.FirstName = imie;
            this.SecondName = nazwisko;
        }
        static Person() => currentId = 0;
        protected int GetNextId() => ++currentId;

        public void Update(string firstName, string secondName)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
        }
      public string ReturnFirstName()
        {
            return this.FirstName;
       }
        public string ReturnSecondName()
        {
            return this.SecondName;
        }
        public int ReturnId()
        {
            return this.ID;
        }
        public void SetId(int id)
        {
            this.ID = id;
        }


    }
}
