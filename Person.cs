using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REA_OOP_2
{
    internal class Person : IComparable, ICloneable
    {
        protected string? _firstname; // имя
        protected string? _lastname; // фамилия
        protected int _age; // возраст
        protected bool _sex; // пол; false - man; true - woman

        private string[] _firstname_man = ["Дмитрий", "Олег", "Андрей", "Василий", "Пётр", "Владислав", "Иван", "Артемий", "Константин", "Даниил", "Евгений", "Александр"];
        private string[] _lastname_man = ["Иванов", "Петров", "Сидоров", "Великий", "Любимый", "Мац", "Мотуз", "Мудряк", "Бибик", "Трусов"];

        private string[] _firstname_woman = ["Ольга", "Ксения", "Ирина", "Василиса", "Екатерина", "Олеся", "Александра", "Альбина", "София", "Анастасия", "Елизавета", "Мария"];
        private string[] _lastname_woman = ["Иванова", "Петрова", "Сидорова", "Великая", "Любимая", "Мац", "Мотуз", "Мудряк", "Бибик", "Трусова"];

        public Person() {
            Random rnd = new Random();
            this.Sex = rnd.NextDouble() > 0.5;
            if (this.Sex)
            {
                this.Firstname = _firstname_woman[rnd.Next(0, _firstname_woman.Length)];
                this.Lastname = _lastname_woman[rnd.Next(0, _lastname_woman.Length)];
                this.Age = rnd.Next(18, 55);
            }
            else
            {
                this.Firstname = _firstname_man[rnd.Next(0, _firstname_man.Length)];
                this.Lastname = _lastname_man[rnd.Next(0, _lastname_man.Length)];
                this.Age = rnd.Next(18, 65);
            }
        }

        public Person(string? firstname, string? lastname, int age, bool sex)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Age = age;
            this.Sex = sex;
        }

        public string Firstname
        {
            get => _firstname;
            set => _firstname = value;
        }

        public string Lastname
        {
            get => _lastname;
            set => _lastname = value;
        }

        public int Age
        {
            get => _age;
            set
            {
                if ((value >= 18) && (value <= 75))
                {
                    _age = value;
                }
                else
                {
                    _age = 18;
                }
            }
        }

        public bool Sex
        {
            get => _sex;
            set => _sex = value;
        }

        public override string ToString()
        {
            return $"Имя: {_firstname}, Фамилия: {_lastname}, Возраст: {_age}, Пол: {(_sex ? "Женщина" : "Мужчина")}";
        }

        public int CompareTo(object obj)
        {
            Person tmp = (Person)obj;

            if (this.Age > tmp.Age) { return 1; }
            if (this.Age < tmp.Age) { return -1; }
            return 0;
        }

        public object Clone()
        {
            return new Person("Клон " + this.Firstname, this.Lastname, this.Age, this.Sex);
        }
        
        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }
    }

    public class SortByFirstName : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            Person p1 = (Person)x;
            Person p2 = (Person)y;

            return String.Compare(p1.Firstname, p2.Firstname);
        }
    }

    public class SortByLastName : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            Person p1 = (Person)x;
            Person p2 = (Person)y;

            return String.Compare(p1.Lastname, p2.Lastname);
        }
    }

    public class SortByAge : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            Person p1 = (Person)x;
            Person p2 = (Person)y;

            if (p1.Age < p2.Age) { return -1; }
            if (p1.Age > p2.Age) { return 1; }
            return 0;
        }
    }

    public class SortBySex : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            Person p1 = (Person)x;
            Person p2 = (Person)y;

            if (p1.Sex == false && p2.Sex == true) { return -1; }
            if (p1.Sex == true && p2.Sex == false) { return 1; }
            return 0;
        }
    }
}
