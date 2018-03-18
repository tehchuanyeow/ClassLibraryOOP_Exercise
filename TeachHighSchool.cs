using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibExercise
{
    class TeachHighSchool : ITeach
    {
        private SecondaryTeacher SecondaryTeacher;
        public string Teach()
        {
            return " Teach high school Brats";
        }
    }
}
