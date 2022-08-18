int Prompt(string message)
{
System.Console.Write(message); // Вывести сообщение
string readValue = Console.ReadLine(); // Считавает с консоли строку
int result = int.Parse(readValue); // Преобрадует строку в целое число
return result; // Возвращает результат
}

// Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.


void takeN(int N)
{
for (int i = 1; i <= N; i++)
{
System.Console.Write(i * i * i + " ");
}
}

takeN(Prompt("Введите число> "));