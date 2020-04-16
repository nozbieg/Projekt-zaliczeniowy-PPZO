using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_zaliczeniowy_PPZO
{
    public class Position : Person
    {
        protected int orginaPersonId { get; set; }

        protected string PersonPosition { get; set; }

        public Position()
        {
           
        }

        public Position(string firstName, string secondName, string personPosition)
        {
            this.ID = GetNextId();
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.PersonPosition = personPosition;
        }
        public string ReturnPersonPosition()
        {
            return this.PersonPosition;
        }





    }
}
