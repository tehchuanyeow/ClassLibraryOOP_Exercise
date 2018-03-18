using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibExercise
{
    public abstract class Person
    {
        private string fName;
        private string gender;
        private string lName;
        public string FName {
            get { return fName; }
            set { fName = value; }
        }
        public string LName {
            get { return lName; }
            set { lName = value; }
        }
        public string GetGender()
        {
            return gender;
        }
        public virtual string GetOccupation()
        {
            return "Unemployed";
        }
        public Person(string pFName, string pLName, string pGender)
        {
            fName = pFName;
            lName = pLName;
            gender = pGender;

            if (gender != "M" || gender != "F")
                throw new Exception("Invalid Gender Passed to Person Constructor!");
        }
        public Person(string pGender)
        {
            if (pGender == "M")
            {
                fName = "John";
                lName = "Doe";
                gender = pGender;
            }
            else if (pGender == "F")
            {
                fName = "Jane";
                lName = "Doe";
                gender = pGender;

            }
            else
            {
                throw new Exception("Invalid Gender Passed to person constructor!");
            }
        }
        public abstract string Work();
    }
}
