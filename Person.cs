using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REA_OOP_2
{
    internal class Person : IComparable
    {
        protected string? _firstname; // имя
        protected string? _lastname; // фамилия
        protected int _age; // возраст
        protected bool _sex; // пол; false - man; true - woman

        public Person() {
            _firstname = "Иван";
            _lastname = "Петров";
            _age = 22;
            _sex = false;
        }

        public Person(string? firstname, string? lastname, int age, bool sex)
        {
            _firstname = firstname;
            _lastname = lastname;
            _age = age;
            _sex = sex;
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
