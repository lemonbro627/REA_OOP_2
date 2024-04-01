using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REA_OOP_2
{
    internal class Worker : Employee
    {
        public override string ToString()
        {
            return base.ToString() + " (офисный работяга)";
        }

        public Worker(string? firstname, string? lastname, int age, bool sex, int stage, string profession) : base(firstname, lastname, age, sex, stage, profession) { }

        public Worker(int stage, string profession) : base(stage, profession) { }

        public Worker() : base(1, "Просто офисный работник") { }
    }
}
