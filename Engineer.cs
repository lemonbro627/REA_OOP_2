using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REA_OOP_2
{
    internal class Engineer : Employee
    {
        public override string ToString()
        {
            return base.ToString() + " (заводской инженер)";
        }

        public Engineer(string? firstname, string? lastname, int age, bool sex, int stage, string profession) : base(firstname, lastname, age, sex, stage, profession) { }

        public Engineer(int stage, string profession) : base(stage, profession) { }

        public Engineer() : base(1, "Просто инженер") { }
    }
}
