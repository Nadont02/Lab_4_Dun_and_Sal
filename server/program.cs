Console.Write("Введи имя😊: ");
string name = Console.ReadLine();
Console.Write($"Приветики 🤗: {name}");
Console.WriteLine("Меня зовут Никита🤡, а так же со мной Олеся😻");
Console.WriteLine("Мы из группы ИСП-233");
Console.WriteLine(DateTime.Now);

Console.WriteLine("---------------------");
Console.WriteLine("Меню");
Console.WriteLine("---------------------");
Console.WriteLine("1 — Показать ФИО");
Console.WriteLine("2 — Показать группу");
Console.WriteLine("3 — Показать дату");
Console.WriteLine("4 — Выход");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 1)
{
    Console.WriteLine("Дунюшкин Никита Сергеевич");
}
else if (n == 2)
{
    Console.WriteLine("ИСП-233");
}
else if (n == 3)
{
    Console.WriteLine(DateTime.Now);
}
else if (n == 4)
{
    return;
}
else
{
    Console.WriteLine("Неправильное значение");
}

