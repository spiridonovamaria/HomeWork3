int Prompt(string message)
{
System.Console.Write(message); // Вывести сообщение
string readValue = Console.ReadLine(); // Считавает с консоли строку
int result = int.Parse(readValue); // Преобрадует строку в целое число
return result; // Возвращает результат
}

// Напишите программу, которая принимает на вход пятизначное число
//и проверяет, является ли оно палиндромом.


void NumberCheck(int num)
{
int num1 = num / 10000;
num = num % 10000;
int num2 = num / 1000;
num = num % 1000;
num = num % 100;
int num4 = num / 10;
num = num % 10;

if (num1 == num && num2 == num4)
{
Console.WriteLine($"Данное число - палиндром.");
}
else Console.WriteLine($"Данное число - не палиндром.");
}

int num = Prompt("Введите пятизначное число> ");

if (num > 9999 && num < 100000)
{
NumberCheck(num);
}
else Console.WriteLine($"Число не пятизначное");