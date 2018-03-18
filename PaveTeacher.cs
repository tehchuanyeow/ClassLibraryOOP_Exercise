using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibExercise
{
    class PAVETeacher : Teacher
    {
        public override string GetOccupation()
        {
            return "PAVE Teacher";
        }
        public PAVETeacher(string pFName, string pLName, string pGender, int pStaffID) : base(pFName, pLName, pGender, pStaffID) { }
    }
}
