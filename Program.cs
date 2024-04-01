// See https://aka.ms/new-console-template for more information
using REA_OOP_2;

Console.WriteLine("Hello, World!");

string razdel = "==============================";

Person[] arr =
[
    new Person("Анатолий", "Первый", 33, false),
    new Engineer("Екатерина", "Вторая", 23, true, 3, "Испытатель"),
    new Worker("Андрей", "Аршавин", 40, false, 15, "Офисный сотрудник"),
    new Worker(),
    new Engineer(),
    new Person(),
    new Employee(7, "Мангуст"),
    new Employee(),
    new Worker(5, "Тестировщик"),
    new Engineer(3, "Тестировщик"),
    new Person(),
    new Person(),
];


//поверхностное клонирование позволяет скопировать целиком объект класса, даже если это наследник класса, а поверхностное копирование описано в родительском
//Clone() из IClonable возвращает новый объект который создаётся заново из полей объект который мы копируем. Это не позволяет перенести некоторые поля если копируем класс наследник
arr[10] = (Person)arr[1].Clone();
arr[11] = arr[1].ShallowCopy();

Console.WriteLine(razdel);
Console.WriteLine("До всех сортировок, свежесозданный массив");
foreach (Person p in arr)
{
    Console.WriteLine(p.ToString());
}
Console.WriteLine(razdel);
Console.WriteLine("Сортировка по Имени");
Array.Sort(arr, new SortByFirstName());
foreach (Person p in arr)
{
    Console.WriteLine(p.ToString());
}
Console.WriteLine(razdel);
Console.WriteLine("Сортировка по Фамилии");
Array.Sort(arr, new SortByLastName());
foreach (Person p in arr)
{
    Console.WriteLine(p.ToString());
}
Console.WriteLine(razdel);
Console.WriteLine("Сортировка по Возрасту");
Array.Sort(arr, new SortByAge());
foreach (Person p in arr)
{
    Console.WriteLine(p.ToString());
}
Console.WriteLine(razdel);
Console.WriteLine("Сортировка по Полу");
Array.Sort(arr, new SortBySex());
foreach (Person p in arr)
{
    Console.WriteLine(p.ToString());
}
Console.WriteLine(razdel);
Console.WriteLine("Фильтр: 1.1 Все мужчины");
foreach (Person p in arr)
{
    if (!p.Sex)
    {
        Console.WriteLine(p.ToString());
    }
}
Console.WriteLine(razdel);
Console.WriteLine("Фильтр: 1.2 Все женщины");
foreach (Person p in arr)
{
    if (p.Sex)
    {
        Console.WriteLine(p.ToString());
    }
}
Console.WriteLine(razdel);
Console.WriteLine("Фильтр: 4 Стаж не меньше заданного");
Console.Write("Задайте стаж для фильтрации: ");
int buf_int = Convert.ToInt32(Console.ReadLine());
foreach (Person p in arr)
{
    if (p is Employee && ((Employee)p).Stage >= buf_int)
    {
        Console.WriteLine(p.ToString());
    }
}
Console.WriteLine(razdel);
Console.WriteLine("Фильтр: 5 Определённая профессия служащего");
Console.Write("Задайте профессию для фильтрации: ");
string buf_str = Console.ReadLine();
foreach (Person p in arr)
{
    if (p is Employee && ((Employee)p).ToString().Contains(buf_str))
    {
        Console.WriteLine(p.ToString());
    }
}
Console.WriteLine(razdel);
Console.WriteLine("Фильтр: 6 Определённая профессия работника");
Console.Write("Задайте профессию для фильтрации: ");
buf_str = Console.ReadLine();
foreach (Person p in arr)
{
    if (p is Worker && ((Worker)p).ToString().Contains(buf_str))
    {
        Console.WriteLine(p.ToString());
    }
}
Console.WriteLine(razdel);
Console.WriteLine("Фильтр: 9 Количество инженеров на заводе");
int counter1 = 0;
foreach (Person p in arr)
{
    if (p is Engineer)
    {
        counter1++;
    }
}
Console.WriteLine($"Инженеров: {counter1} человек");
Console.WriteLine(razdel);
Console.WriteLine("Фильтр: 15.1 Количество мужчин");
int counter2 = 0;
foreach (Person p in arr)
{
    if (!p.Sex)
    {
        counter2++;
    }
}
Console.WriteLine($"Мужчик: {counter2} человек");
Console.WriteLine(razdel);
Console.WriteLine("Фильтр: 15.2 Количество женщин");
int counter3 = 0;
foreach (Person p in arr)
{
    if (p.Sex)
    {
        counter3++;
    }
}
Console.WriteLine($"Мужчик: {counter3} человек");
Console.WriteLine(razdel);
Console.WriteLine("Фильтр: 17 Количество работников со стажем не меньше заданного");
Console.Write("Задайте стаж для фильтрации: ");
buf_int = Convert.ToInt32(Console.ReadLine());
int counter4 = 0;
foreach (Person p in arr)
{
    if (p is Employee && ((Employee)p).Stage >= buf_int)
    {
        counter4++;
    }
}
Console.WriteLine($"Работников со стажем больше {buf_int}: {counter4} человек");