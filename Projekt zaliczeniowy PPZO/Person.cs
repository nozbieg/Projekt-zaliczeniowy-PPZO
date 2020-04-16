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

         public int ID { get; set; }
         public string FirstName { get; set; }
         public string SecondName { get; set; }

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

  


    }
}
