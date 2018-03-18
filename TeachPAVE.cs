using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibExercise
{
    class TeachPAVE : ITeach
    {
        public PAVETeacher PaveTeacher;
        public string Teach()
        {
            return "Teach Awesome SWD Students";
        }
    }
}
