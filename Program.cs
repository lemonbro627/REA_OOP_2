// See https://aka.ms/new-console-template for more information
using REA_OOP_2;

Console.WriteLine("Hello, World!");

Person[] arr = new Person[3];
arr[0] = new Person("Анатолий", "Первый", 33, false);
arr[1] = new Engineer("Екатерина", "Вторая", 23, true, 3, "Испытатель");
arr[2] = new Worker("Андрей", "Аршавин", 40, false, 15, "Офисный сотрудник");
Console.WriteLine("Сортировка по Имени");
Array.Sort(arr, new SortByFirstName());
foreach (Person p in arr)
{
    Console.WriteLine(p.ToString());
}
Console.WriteLine("Сортировка по Фамилии");

Array.Sort(arr, new SortByLastName());
foreach (Person p in arr)
{
    Console.WriteLine(p.ToString());
}
Console.WriteLine("Сортировка по Возрасту");

Array.Sort(arr, new SortByAge());
foreach (Person p in arr)
{
    Console.WriteLine(p.ToString());
}
Console.WriteLine("Сортировка по Полу");

Array.Sort(arr, new SortBySex());
foreach (Person p in arr)
{
    Console.WriteLine(p.ToString());
}