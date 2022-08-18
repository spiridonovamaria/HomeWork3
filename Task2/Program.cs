int Prompt(string message)
{
System.Console.Write(message); // Вывести сообщение
string readValue = Console.ReadLine(); // Считавает с консоли строку
int result = int.Parse(readValue); // Преобрадует строку в целое число
return result; // Возвращает результат
}

// Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.


int aX = Prompt("Введите координату aX> ");
int aY = Prompt("Введите координату aY> ");
int aZ = Prompt("Введите координату aZ> ");
int bX = Prompt("Введите координату bX> ");
int bY = Prompt("Введите координату bY> ");
int bZ = Prompt("Введите координату bZ> ");

double result= Math.Sqrt((aX-bX)*(aX-bX)+(aY-bY)*(aY-bY)+(aZ-bZ)*(aZ-bZ));
System.Console.WriteLine($"Длина отрезка между точками в 3D пространстве равно {result}");