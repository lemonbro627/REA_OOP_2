using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REA_OOP_2
{
    internal class Employee : Person
    {
        protected int _stage; // стаж
        protected string? _profession; // профессия

        public Employee() : base() {
            this.Stage = 1;
            this.Profession = "Трудоустроенный";
        }

        public Employee(int stage, string? profession) : base()
        {
            this.Stage = stage;
            this.Profession = profession;
        }

        public Employee(string? firstname, string? lastname, int age, bool sex, int stage, string? profession) : base(firstname, lastname, age, sex)
        {
            this.Stage = stage;
            this.Profession = profession;
        }

        public int Stage
        {
            get => _stage;
            set
            {
                if (value >= 0 && value <= 53)
                    if (_stage > _age - 18)
                    {
                        _stage = _age - 18;
                    }
                    else
                    {
                        _stage = value;
                    }
            }
        }

        public string Profession
        {
            get => _profession;
            set => _profession = value;
        }

        public override string ToString()
        {
            return base.ToString() + $", Стаж: {_stage}, Професия: {_profession}";
        }
    }
}
