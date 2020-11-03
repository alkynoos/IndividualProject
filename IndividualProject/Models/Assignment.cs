﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class Assignment
    {
        private string _title;
        private string _description;
        private DateTime _subdatetime;
        private float _oralmark;
        private float _totalmark;

        public string Title
        {
            get { return (this._title); }
            set { this._title = value; }
        }
        public string Description
        {
            get { return (this._description); }
            set { this._description = value; }
        }

        public DateTime SubDateTime
        {
            get { return (this._subdatetime); }
            set { this._subdatetime = value; }
        }

        public float OralMark
        {
            get { return (this._oralmark); }
            set { this._oralmark = value; }
        }
        public float TotalMark
        {
            get { return (this._totalmark); }
            set { this._totalmark = value; }
        }

        public override string ToString()
        {
            return ($"Title: {_title}\tDescription: {_description}\tSubmission Date & Time: {_subdatetime.ToString("dd/MM/yyyy HH:mm")}\tOral Mark: {_oralmark}\tTotal Mark: "); // --> date time check correct format
        }
    }
}
