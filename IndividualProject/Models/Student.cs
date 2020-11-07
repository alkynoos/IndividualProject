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
        private string _studentStream;
        private string _streamType;
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
        
        public DateTime DateOfBirth
        {
            get { return (this._dateofbirth); }
            set { this._dateofbirth = value; }  //-->date time format !!
        }


        public string StudentStream
        {
            get { return (this._studentStream); }
            set { this._studentStream = value; }
        }


        public string StreamType
        {
            get { return (this._streamType); }
            set { this._streamType = value; }
        }

        public double TuitionFees
        {
            get { return (this._tuitionfees); }
            set { this._tuitionfees = value; } // --> decimal formating
        }


        //------------Enter viriable for course section!!!!!!!!

        public override string ToString()
        {
            return ($"First Name: {_firstname}" +
                    $"\tLast Name: {_lastname}" +
                    $"\tDate of Berth: {_dateofbirth.ToString("dd/MM/yyyy")}" +
                    $"\tCourse: {_studentStream} {_streamType}"+
                    $"\tTuition Fees: {_tuitionfees}");
        }
    }
}
