// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//!!! НЕ СОВСЕМ ПОНЯТНО УСЛОВИЕ ЗАДАЧИ, ПОЭТОМУ НЕ УВЕРЕНА, ЧТО СДЕЛАЛА ТО ЧТО НУЖНО. МАССИВ ИЗ 8 ЭЛЕМЕНТОВ ЗАПОЛНЯЕТСЯ 
//РАНДОМНЫМИ ЦИФРАМИ, МИН И МАКС ЗНАЧЕНИЯ ВВОДЯТСЯ ПОЛЬЗОВАТЕЛЕМ

using System;
using static System.Console;
Clear();

WriteLine("Please type a min value");
int numMin = Convert.ToInt32(ReadLine());

WriteLine("Please type a max value");
int numMax = Convert.ToInt32(ReadLine());

int[] newArr = new int [8];
FillArr(newArr, numMin, numMax);

WriteLine(String.Join(",",FillArr(newArr, numMin, numMax)));


int[] FillArr(int[] array, int minV, int maxV)
{
    int[] filledArr = new int[array.Length];
    for (int i=0; i<array.Length; i++)
    {
        filledArr[i] = new Random().Next(minV,maxV+1);
    }
    return filledArr;

}


