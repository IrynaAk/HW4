// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


using System;
using static System.Console;
Clear();

WriteLine("Please type a number");

WriteLine($"The sum is {GetSum(Convert.ToInt32(ReadLine()))}");


int GetSum(int N)
{
 int answer =0;
    while(N>0 )
    {
        answer = answer + N%10;
        N/=10;
    } 
 return answer;
}

