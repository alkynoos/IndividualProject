using IndividualProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.BusinessLogic
{
    class SyntheticData
    {
        
        private static List<Trainer> SyntheticDataTrainer() 
        {
            List.trainers.Add(new Trainer("Aadam", "English", "Java"));
            List.trainers.Add(new Trainer("Cassius", "Mathews", "C#"));
            List.trainers.Add(new Trainer("Derry", "Livingston", "JavaScript"));
            List.trainers.Add(new Trainer("Lucie", "Solomon", "Java"));
            List.trainers.Add(new Trainer("Emilis", "Robbins", "C#"));
            List.trainers.Add(new Trainer("Ishika", "Suarez", "JavaScript"));
            List.trainers.Add(new Trainer("Macie", "Brandt", "PHP"));
            List.trainers.Add(new Trainer("Tayyibah", "Mckenna", "PHP"));
            List.trainers.Add(new Trainer("Victor", "Schaefer", "Python"));
            List.trainers.Add(new Trainer("Jed", "Howarth", "Python"));

            return (List.trainers);
        }

        protected internal static List<Student> SyntheticDataStudent()
        {                
            List.students.Add(new Student("Francesco", "Chaney", Convert.ToDateTime("15/01/1996"), "Java", "Full Time", 2500));
            List.students.Add(new Student("Georgia", "Sanchez", Convert.ToDateTime("02/01/1992"), "Java", "Part Time", 2250));
            List.students.Add(new Student("Naomi", "Chan", Convert.ToDateTime("26/04/2001"), "Java", "Online", 2250));
            List.students.Add(new Student("Kloe", "Hagan", Convert.ToDateTime("11/10/1991"), "Java", "Hybrid Full Time", 2500));
            List.students.Add(new Student("Alice", "Hutton", Convert.ToDateTime("05/11/1988"), "Java", "Hybrid Part Time", 2150));
            List.students.Add(new Student("Nana", "Markham", Convert.ToDateTime("15/04/1996"), "Java", "Full Time", 2500));
            List.students.Add(new Student("Che", "Downs", Convert.ToDateTime("02/02/1992"), "Java", "Part Time", 2250));
            List.students.Add(new Student("Brax", "Odling", Convert.ToDateTime("26/10/2000"), "Java", "Online", 2250));
            List.students.Add(new Student("Ammaar", "Lynn", Convert.ToDateTime("11/12/1990"), "Java", "Hybrid Full Time", 2500));
            List.students.Add(new Student("Susie", "Kline", Convert.ToDateTime("05/09/1986"), "Java", "Hybrid Part Time", 2150));
            List.students.Add(new Student("Ollie", "Randall", Convert.ToDateTime("06/12/1997"), "C#", "Full Time", 2000));
            List.students.Add(new Student("Chaim", "Bridges", Convert.ToDateTime("24/09/1998"), "C#", "Part Time", 2250));
            List.students.Add(new Student("Katherine", "Mclaughlin", Convert.ToDateTime("28/02/2001"), "C#", "Online", 2250));
            List.students.Add(new Student("Manahil", "Buckley", Convert.ToDateTime("13/03/1991"), "C#", "Hybrid Full Time", 2500));
            List.students.Add(new Student("Everett", "Pena", Convert.ToDateTime("05/05/1988"), "C#", "Hybrid Part Time", 2150));
            List.students.Add(new Student("Zeynep", "Stamp", Convert.ToDateTime("03/08/1997"), "C#", "Full Time", 2000));
            List.students.Add(new Student("Zena", "Chang", Convert.ToDateTime("28/04/1996"), "C#", "Part Time", 2250));
            List.students.Add(new Student("Lilliana", "Lees", Convert.ToDateTime("24/04/1998"), "C#", "Online", 2250));
            List.students.Add(new Student("Aislinn", "Webb", Convert.ToDateTime("13/01/1999"), "C#", "Hybrid Full Time", 2500));
            List.students.Add(new Student("Hadiya", "Cabrera", Convert.ToDateTime("27/10/1989"), "C#", "Hybrid Part Time", 2150));
            List.students.Add(new Student("Mahima ", "Shields", Convert.ToDateTime("05/07/1995"), "JavaScript", "Full Time", 2500));
            List.students.Add(new Student("May", "Davila", Convert.ToDateTime("11/01/1995"), "JavaScript", "Part Time", 2250));
            List.students.Add(new Student("Tate", "Vargas", Convert.ToDateTime("15/04/1998"), "JavaScript", "Online", 2250));
            List.students.Add(new Student("Harvey", "Bowler", Convert.ToDateTime("11/03/1988"), "JavaScript", "Hybrid Full Time", 2500));
            List.students.Add(new Student("Giorgio", "Vazquez", Convert.ToDateTime("14/11/1990"), "JavaScript", "Hybrid Part Time", 2150));
            List.students.Add(new Student("Frankie", "Regan", Convert.ToDateTime("15/12/1997"), "JavaScript", "Full Time", 2500));
            List.students.Add(new Student("Pawel", "Davey", Convert.ToDateTime("18/02/2000"), "JavaScript", "Part Time", 2250));
            List.students.Add(new Student("Grace", "Keeling", Convert.ToDateTime("16/03/1993"), "JavaScript", "Online", 2250));
            List.students.Add(new Student("Francesco", "Chaney", Convert.ToDateTime("15/01/1996"), "JavaScript", "Hybrid Full Time", 2500));
            List.students.Add(new Student("April", "Sadler", Convert.ToDateTime("13/10/1986"), "JavaScript", "Hybrid Part Time", 2150));
            List.students.Add(new Student("Madihah  ", "Whyte", Convert.ToDateTime("05/01/1985"), "PHP", "Full Time", 2500));
            List.students.Add(new Student("Erica", "Webster", Convert.ToDateTime("03/02/2000"), "PHP", "Part Time", 2250));
            List.students.Add(new Student("Esmee", "Lambert", Convert.ToDateTime("15/05/1994"), "PHP", "Online", 2250));
            List.students.Add(new Student("Artur", "Hogan", Convert.ToDateTime("07/07/1991"), "PHP", "Hybrid Full Time", 2500));
            List.students.Add(new Student("Aneeka", "Ferreira", Convert.ToDateTime("22/09/1997"), "PHP", "Hybrid Part Time", 2150));
            List.students.Add(new Student("Thiago", "Santos", Convert.ToDateTime("29/12/1988"), "PHP", "Full Time", 2500));
            List.students.Add(new Student("Kobe", "Dyer", Convert.ToDateTime("28/12/1984"), "PHP", "Part Time", 2250));
            List.students.Add(new Student("Khadijah", "Burton", Convert.ToDateTime("11/09/1983"), "PHP", "Online", 2250));
            List.students.Add(new Student("Nana", "Markham", Convert.ToDateTime("15/04/1996"), "PHP", "Hybrid Full Time", 2500));
            List.students.Add(new Student("Atlanta", "Marriott", Convert.ToDateTime("13/11/2001"), "PHP", "Hybrid Part Time", 2150));
            List.students.Add(new Student("Macie", "Brandt", Convert.ToDateTime("12/11/1986"), "Python", "Full Time", 2500));
            List.students.Add(new Student("Tayyibah", "English", Convert.ToDateTime("07/02/1989"), "Python", "Part Time", 2250));
            List.students.Add(new Student("Katie", "Vang", Convert.ToDateTime("22/03/2000"), "Python", "Online", 2250));
            List.students.Add(new Student("Eshal", "Mckenna", Convert.ToDateTime("20/07/1999"), "Python", "Hybrid Full Time", 2500));
            List.students.Add(new Student("Victor", "Schaefer", Convert.ToDateTime("29/06/1995"), "Python", "Hybrid Part Time", 2150));
            List.students.Add(new Student("Ria", "Obrien", Convert.ToDateTime("30/01/1991"), "Python", "Full Time", 2500));
            List.students.Add(new Student("Usmaan", "Leblanc", Convert.ToDateTime("01/09/1987"), "Python", "Part Time", 2250));
            List.students.Add(new Student("Pawel", "Davey", Convert.ToDateTime("18/02/2000"), "Python", "Online", 2250));
            List.students.Add(new Student("Kenneth", "Watts", Convert.ToDateTime("24/08/2000"), "Python", "Hybrid Full Time", 2500));
            List.students.Add(new Student("Jed", "Howarth", Convert.ToDateTime("23/12/1997"), "Python", "Hybrid Part Time", 2150));
            return (List.students);
        }

        protected internal static List<Assignment> SyntheticDataAssignment() 
        {
            List.assignments.Add(new Assignment("Java", "Full Time",        "Personal Project 1", "Scool Managing App", Convert.ToDateTime("10/11/2020"), 5.5f, 4.5f));
            List.assignments.Add(new Assignment("Java", "Part Time",        "Personal Project 1", "Scool Managing App", Convert.ToDateTime("15/12/2020"), 5.5f, 4.5f));
            List.assignments.Add(new Assignment("Java", "Online",           "Personal Project 1", "Scool Managing App", Convert.ToDateTime("10/11/2020"), 5.5f, 4.5f));
            List.assignments.Add(new Assignment("Java", "Hybrid Full Time", "Personal Project 1", "Scool Managing App", Convert.ToDateTime("10/11/2020"), 5.5f, 4.5f));
            List.assignments.Add(new Assignment("Java", "Hybrid Part Time", "Personal Project 1", "Scool Managing App", Convert.ToDateTime("15/12/2020"), 5.5f, 4.5f));

            List.assignments.Add(new Assignment("C#", "Full Time",          "Personal Project 1", "Hotel Managing App", Convert.ToDateTime("10/11/2020"), 4.5f, 5.5f));
            List.assignments.Add(new Assignment("C#", "Part Time",          "Personal Project 1", "Hotel Managing App", Convert.ToDateTime("15/12/2020"), 4.5f, 5.5f));
            List.assignments.Add(new Assignment("C#", "Online",             "Personal Project 1", "Hotel Managing App", Convert.ToDateTime("10/11/2020"), 4.5f, 5.5f));
            List.assignments.Add(new Assignment("C#", "Hybrid Full Time",   "Personal Project 1", "Hotel Managing App", Convert.ToDateTime("10/11/2020"), 4.5f, 5.5f));
            List.assignments.Add(new Assignment("C#", "Hybrid Part Time",   "Personal Project 1", "Hotel Managing App", Convert.ToDateTime("15/12/2020"), 4.5f, 5.5f));

            List.assignments.Add(new Assignment("JavaScript", "Full Time",          "Personal Project 1", "Travel Managing App", Convert.ToDateTime("10/11/2020"), 4.5f, 5.1f));
            List.assignments.Add(new Assignment("JavaScript", "Part Time",          "Personal Project 1", "Travel Managing App", Convert.ToDateTime("15/12/2020"), 4.5f, 5.1f));
            List.assignments.Add(new Assignment("JavaScript", "Online",             "Personal Project 1", "Travel Managing App", Convert.ToDateTime("10/11/2020"), 4.5f, 5.1f));
            List.assignments.Add(new Assignment("JavaScript", "Hybrid Full Time",   "Personal Project 1", "Travel Managing App", Convert.ToDateTime("10/11/2020"), 4.5f, 5.1f));
            List.assignments.Add(new Assignment("JavaScript", "Hybrid Part Time",   "Personal Project 1", "Travel Managing App", Convert.ToDateTime("15/12/2020"), 4.5f, 5.1f));

            List.assignments.Add(new Assignment("JavaScript", "Full Time",          "Personal Project 1", "Taxi Company Managing App", Convert.ToDateTime("10/11/2020"), 5.5f, 4.5f));
            List.assignments.Add(new Assignment("JavaScript", "Part Time",          "Personal Project 1", "Taxi Company Managing App", Convert.ToDateTime("15/12/2020"), 5.5f, 4.5f));
            List.assignments.Add(new Assignment("JavaScript", "Online",             "Personal Project 1", "Taxi Company Managing App", Convert.ToDateTime("10/11/2020"), 5.5f, 4.5f));
            List.assignments.Add(new Assignment("JavaScript", "Hybrid Full Time",   "Personal Project 1", "Taxi Company Managing App", Convert.ToDateTime("10/11/2020"), 5.5f, 4.5f));
            List.assignments.Add(new Assignment("JavaScript", "Hybrid Part Time",   "Personal Project 1", "Taxi Company Managing App", Convert.ToDateTime("15/12/2020"), 5.5f, 4.5f));

            List.assignments.Add(new Assignment("PHP", "Full Time",         "Personal Project 1", "Employee Managing App", Convert.ToDateTime("10/11/2020"), 4.5f, 5.5f));
            List.assignments.Add(new Assignment("PHP", "Part Time",         "Personal Project 1", "Employee Managing App", Convert.ToDateTime("15/12/2020"), 4.5f, 5.5f));
            List.assignments.Add(new Assignment("PHP", "Online",            "Personal Project 1", "Employee Managing App", Convert.ToDateTime("10/11/2020"), 4.5f, 5.5f));
            List.assignments.Add(new Assignment("PHP", "Hybrid Full Time",  "Personal Project 1", "Employee Managing App", Convert.ToDateTime("10/11/2020"), 4.5f, 5.5f));
            List.assignments.Add(new Assignment("PHP", "Hybrid Part Time",  "Personal Project 1", "Employee Managing App", Convert.ToDateTime("15/12/2020"), 4.5f, 5.5f));

            List.assignments.Add(new Assignment("Python", "Full Time",          "Personal Project 1", "Ship Managing App", Convert.ToDateTime("10/11/2020"), 5.5f, 4.5f));
            List.assignments.Add(new Assignment("Python", "Part Time",          "Personal Project 1", "Ship Managing App", Convert.ToDateTime("15/12/2020"), 5.5f, 4.5f));
            List.assignments.Add(new Assignment("Python", "Online",             "Personal Project 1", "Ship Managing App", Convert.ToDateTime("10/11/2020"), 5.5f, 4.5f));
            List.assignments.Add(new Assignment("Python", "Hybrid Full Time",   "Personal Project 1", "Ship Managing App", Convert.ToDateTime("10/11/2020"), 5.5f, 4.5f));
            List.assignments.Add(new Assignment("Python", "Hybrid Part Time",   "Personal Project 1", "Ship Managing App", Convert.ToDateTime("15/12/2020"), 5.5f, 4.5f));

            return (List.assignments);
        }

        protected internal static List<Course> SyntheticDataCourse()
        {
            List.courses.Add(new Course(12, "Jave", "Full Time",        Convert.ToDateTime("05/10/2020"), Convert.ToDateTime("28/01/2021")));
            List.courses.Add(new Course(12, "Jave", "Part Time",        Convert.ToDateTime("05/10/2020"), Convert.ToDateTime("10/05/2021")));
            List.courses.Add(new Course(12, "Jave", "Online",           Convert.ToDateTime("05/10/2020"), Convert.ToDateTime("28/01/2021")));
            List.courses.Add(new Course(12, "Jave", "Hybrid Full Time", Convert.ToDateTime("05/10/2020"), Convert.ToDateTime("28/01/2021")));
            List.courses.Add(new Course(12, "Jave", "Hybrid Part Time", Convert.ToDateTime("05/10/2020"), Convert.ToDateTime("10/05/2021")));

            List.courses.Add(new Course(12, "C#", "Full Time",          Convert.ToDateTime("05/10/2020"), Convert.ToDateTime("28/01/2021")));
            List.courses.Add(new Course(12, "C#", "Part Time",          Convert.ToDateTime("05/10/2020"), Convert.ToDateTime("10/05/2021")));
            List.courses.Add(new Course(12, "C#", "Online",             Convert.ToDateTime("05/10/2020"), Convert.ToDateTime("28/01/2021")));
            List.courses.Add(new Course(12, "C#", "Hybrid Full Time",   Convert.ToDateTime("05/10/2020"), Convert.ToDateTime("28/01/2021")));
            List.courses.Add(new Course(12, "C#", "Hybrid Part Time",   Convert.ToDateTime("05/10/2020"), Convert.ToDateTime("10/05/2021")));

            List.courses.Add(new Course(12, "C#", "Full Time",          Convert.ToDateTime("05/10/2020"), Convert.ToDateTime("28/01/2021")));
            List.courses.Add(new Course(12, "C#", "Part Time",          Convert.ToDateTime("05/10/2020"), Convert.ToDateTime("10/05/2021")));
            List.courses.Add(new Course(12, "C#", "Online",             Convert.ToDateTime("05/10/2020"), Convert.ToDateTime("28/01/2021")));
            List.courses.Add(new Course(12, "C#", "Hybrid Full Time",   Convert.ToDateTime("05/10/2020"), Convert.ToDateTime("28/01/2021")));
            List.courses.Add(new Course(12, "C#", "Hybrid Part Time",   Convert.ToDateTime("05/10/2020"), Convert.ToDateTime("10/05/2021")));

            List.courses.Add(new Course(12, "JaveScript", "Full Time",          Convert.ToDateTime("05/10/2020"), Convert.ToDateTime("28/01/2021")));
            List.courses.Add(new Course(12, "JaveScript", "Part Time",          Convert.ToDateTime("05/10/2020"), Convert.ToDateTime("10/05/2021")));
            List.courses.Add(new Course(12, "JaveScript", "Online",             Convert.ToDateTime("05/10/2020"), Convert.ToDateTime("28/01/2021")));
            List.courses.Add(new Course(12, "JaveScript", "Hybrid Full Time",   Convert.ToDateTime("05/10/2020"), Convert.ToDateTime("28/01/2021")));
            List.courses.Add(new Course(12, "JaveScript", "Hybrid Part Time",   Convert.ToDateTime("05/10/2020"), Convert.ToDateTime("10/05/2021")));

            List.courses.Add(new Course(12, "PHP", "Full Time",         Convert.ToDateTime("05/10/2020"), Convert.ToDateTime("28/01/2021")));
            List.courses.Add(new Course(12, "PHP", "Part Time",         Convert.ToDateTime("05/10/2020"), Convert.ToDateTime("10/05/2021")));
            List.courses.Add(new Course(12, "PHP", "Online",            Convert.ToDateTime("05/10/2020"), Convert.ToDateTime("28/01/2021")));
            List.courses.Add(new Course(12, "PHP", "Hybrid Full Time",  Convert.ToDateTime("05/10/2020"), Convert.ToDateTime("28/01/2021")));
            List.courses.Add(new Course(12, "PHP", "Hybrid Part Time",  Convert.ToDateTime("05/10/2020"), Convert.ToDateTime("10/05/2021")));

            return (List.courses);
        }

        protected internal static void SendSyntheticDataToMemu()
        {
            SyntheticDataTrainer();
            SyntheticDataStudent();
            SyntheticDataAssignment();
            SyntheticDataCourse();
        }
    }      
    
}
