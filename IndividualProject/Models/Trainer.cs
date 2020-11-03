using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class Trainer
    {
        private string _firstname; //{ get; set; } // _name it for us so we now that this variables are private
        private string _lastname;
        private string _subject;

        public string FirstName
        {                                    // this gives as the ability to "set" a value from "outside" for private string firstName, 
           get { return (this._firstname); } //but when we "get" the value we can formated as we like from "inside"
           set { this._firstname = value.ToUpper(); } 
        }

        //propfull --> out generate the above
        public string LastName 
        { 
            get { return (this._firstname); }           // getter needs return
            set { this._lastname = value.ToUpper(); }
        }

        public string Subject
        {
            get { return (this._subject); }
            set { this._subject = value; }
        }



        //public override bool Equals(object obj)
        //{
        //    return base.Equals(obj);
        //}

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}

        public override string ToString()
        {
            return ($"First Name: {_firstname}\tLast Name: {_lastname}\tSubject: {_subject}");
        }
    }
}
