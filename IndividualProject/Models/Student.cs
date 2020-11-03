using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class Student
    {
        private string _firstname;
        private string _lastname;
        private DateTime _dateofbirth;
        private double _tuitionfees;

        public string FirstName
        {
            get { return (this._firstname); }
            set { this._firstname = value; }
        }
       
        public string LastName
        {
            get { return (this._lastname); }
            set { this._lastname = value; }
        }
        
        public DateTime DateOfBerth
        {
            get { return (this._dateofbirth); }
            set { this._dateofbirth = value; }  //-->date time format !!
        }

        public double TuitionFees
        {
            get { return (this._tuitionfees); }
            set { this._tuitionfees = value; } // --> decimal formating
        }

        public override string ToString()
        {
            return ($"First Name: {_firstname}\tLast Name: {_lastname}\tDate of Berth: {_dateofbirth.ToString("dd/MM/yyyy")}\tTuition Fees: {_tuitionfees}");
        }
    }
}
