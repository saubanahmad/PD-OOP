using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1.BL;

namespace Problem1.DL
{
    internal class DegreeProgramDL
    {
        public static List<DegreeProgram> programs = new List<DegreeProgram>();

        public static void AddProgram(DegreeProgram program)
        {
            programs.Add(program);
        }

        public static List<DegreeProgram> GetAllPrograms()
        {
            return programs;
        }
    }
}
