using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibExercise
{
    class TeachSpecialNeeds : iTeach
    {
        public SpecialNeedsTeacher specialNeedsTeacher1;
        public string Teach()
        {
            return "Teach Special Needs";
        }
    }
}
