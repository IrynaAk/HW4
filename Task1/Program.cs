// Урок 4. Функции продолжение
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using System;
using static System.Console;
Clear();

WriteLine("Please type a number");
int number = Convert.ToInt32(ReadLine());

WriteLine("Please type a number");
int power = Convert.ToInt32(ReadLine());

WriteLine ($"{number} to degree {power} is {PowerCalc(number, power)}");



int PowerCalc(int a, int b)
{
    int answer;
    answer = Convert.ToInt32(Math.Pow(a, b));
    return answer;
}


//double distance = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));




