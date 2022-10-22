//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine();

Console.WriteLine("Введите число, соответстующему дню недели, по порядку от 1 до 7: ");
int dayNumber = Convert.ToInt32(Console.ReadLine()??"0");

string[] Days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
string txtResult = "";

if (dayNumber > 5) txtResult = $". Ура! Это выходной день!";
else txtResult = $", рабочий день.";

Console.WriteLine();
Console.WriteLine($"{dayNumber}-й день недели - это {Days[dayNumber - 1]}{txtResult}");
Console.WriteLine();