// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.

// Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.

// Для остальных чисел вернуть True или False.
// int number = 12821;
// Console.WriteLine((number/1000)%10);
// как работает тут в вс код
// if(number/10000 >= 9 || number/10000 <= 0)
// {
//     Console.WriteLine($"Число не пятизначное \n{false}");
// }
// else
// {
//     Console.WriteLine("число пятизначное");
// }
// else if(number/10000 == number%10 && (number/1000)%10 == (number%100)/10)
// {
//     // Console.WriteLine($"{true}");
// }
// else
// {
//     Console.WriteLine($"{false}");
// }

// как в ответе в примере на проверку
// if(number/10000 >= 9 || number/10000 <= 0)
//       {
//         Console.WriteLine($"Число не пятизначное \n");
//         return false;
//       }
//       else if(number/10000 == number%10 && (number/1000)%10 == (number%100)/10)
//       {
//         //Console.WriteLine($"{true}");
//         return true;
//       }
//       else
//       {
//         //Console.WriteLine($"{false}");
//         return false;}

// task 2
// Внутри класса Answer напишите метод DistanceBetweenPoints, который принимает на вход координаты двух 
// точек pointA и pointB в виде массива целых чисел, и возвращает расстояние между ними в 3D пространстве.



// Task 3
// Внутри класса Answer напишите метод ShowCube, который принимает на вход число 
// (N) и выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.
int number = new Random().Next(0,10);
Console.WriteLine(number);
int n = 1;
while(n != number + 1)
{
    Console.WriteLine(n*n*n);
    n += 1;
}


