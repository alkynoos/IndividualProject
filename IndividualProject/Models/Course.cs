using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class Course
    {
        private int _titlenumber;
        private string _stream;
        private string _type;
        private DateTime _start_date;
        private DateTime _end_date;

        public int TitleNumber
        {
            get { return (this._titlenumber); }
            set { this._titlenumber = value; } // maybe the value needs formating
        }
        public string Stream
        {
            get { return (this._stream); }
            set { this._stream = value; }
        }
        public string Type
        {
            get { return (this._type); }
            set { this._type = value; }
        }
        public DateTime Start_Date
        {
            get { return (this._start_date); }
            set { this._start_date = value; }  // date need formationg
        }
        public DateTime End_Date
        {
            get { return (this._end_date); }
            set { this._end_date = value; }
        }

        public override string ToString()
        {
            return ($"Course Title: CB{_titlenumber} {_stream} {_type}" +
                    $"\tStream: {_stream}" +
                    $"\tType: {_type}" +
                    $"\tStart Date: {_start_date.ToString("dd/MM/yyyy")}" +
                    $"\tEnd Date: {_end_date.ToString("dd/MM/yyyy")}");
        }
    }
}
