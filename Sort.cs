using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REA_OOP_2
{
    public class SortByFirstName: IComparer
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
