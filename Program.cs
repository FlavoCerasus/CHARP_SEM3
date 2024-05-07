// Семинар по массивам

/* Задача 1 - Задайте массив. Напишите программу, которая определяет, присутствует 
ли заданное число в массиве. Программа должна выдать ответ: Да/Нет.
Примеры:
[1 3 4 19 3], 8 => Нет
[-4 3 4 1], 3 => Да
*/
/*
int [] arrayTask1 =  [1, 18, 4, 19, 3, 17];
int elemToFind = 18;

bool isFound = false;
foreach (int currentVal in arrayTask1)
{
    if (currentVal == elemToFind)
    {
        isFound = true;
        break;
    }
}
if (isFound)
{
    Console.WriteLine("Да");
}
else {Console.WriteLine("Нет");}
*/

/* Задача 2 - Задайте массив из 10 элементов, заполненный числами из 
промежутка [-10, 10]. Замените отрицательные элементы на положительные, 
а положительные на отрицательные.
Пример:
[1 -5 6] => [-1 5 -6]
*/
/*
int [] arrayTask2 = new int [10];
for (int i = 0; i < arrayTask2.Length; i++)
{
    arrayTask2[i]= new Random().Next(-10, 11);
    Console.Write($"{arrayTask2[i]} ");
}
Console.WriteLine();
Console.WriteLine("Измененный массив:");

for (int i = 0; i < arrayTask2.Length; i++)
{
    arrayTask2[i] *= -1;
    Console.Write($"{arrayTask2[i]} ");
}
*/

/* Задача 3 - Найдите произведения пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новый массив.
Пример:
[1 3 2 4 2 3] => [3 6 8]
[2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)
*/
/*
int size = 10;
int minVal = -15;
int maxVal = 20;
int [] arrayTask3 = new int [size]; // исходный массив
int [] optArrayT3 = new int [arrayTask3.Length/2];

for (int i = 0; i < arrayTask3.Length; i++)
{
    arrayTask3[i]= new Random().Next(minVal, maxVal);
    Console.Write($"{arrayTask3[i]} ");
}
Console.WriteLine();

for (int i = 0; i < arrayTask3.Length/2; i++)
{
    optArrayT3[i] = arrayTask3[i] * arrayTask3[arrayTask3.Length -1 - i];
    Console.Write($"{optArrayT3[i]} ");
}
*/

/* Задача 4 - Дано натуральное трёхзначное число. Создайте массив, 
состоящий из цифр этого числа. Младший разряд числа должен 
располагаться на 0-м индексе массива, старший – на 2-м.
Пример
456 => [6 5 4] 
781 => [1 8 7]
*/
/*
int number = 456;
int [] digitArr = new int [3];

for (int i = 0; i < 3; i++)
{
    digitArr[i] = number %10;
    number /= 10;
    Console.Write($"{digitArr[i]} ");
}
*/

// Домашняя работа - автотест.

/* Задание 1 - Задайте одномерный массив из 10 целых чисел от 1 до 100. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,90].
Пример:
int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
Выводится: 5
*/
/*
int [] array = new int [10];
int counter =0;
for (int i = 0; i < array.Length; i++)
{
    array[i]= new Random().Next(1, 101);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
for (int i = 0; i<array.Length; i++)
{
    if (array[i] >= 10 && array[i]<=90)
    {
        counter += 1;
    }
}
Console.WriteLine(counter);
*/

/* Задание 2 - Задайте массив на 10 целых чисел. Напишите программу, 
которая определяет количество чётных чисел в массиве.
Пример:
int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
Выводится: 6
*/
/*
int [] array = new int [10];
int counter = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i]= new Random().Next(1, 101);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
for (int i = 0; i<array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        counter ++;
    }
}
Console.WriteLine(counter);
*/

/* Задание 3 - Задайте массив из вещественных чисел с ненулевой дробной частью. 
Найдите разницу между максимальным и минимальным элементов массива.
Пример:
double[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
Выводится: 5.15
*/
/*
double [] array = new double [10];
for (int i = 0; i < array.Length; i++)
{
    array[i]= Math.Round(new Random().NextDouble() *5, 2);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();

double min = array[0];
double max = array[0];

for (int j = 0; j < array.Length; j++)
{
    if (array[j] < min)
    {
        min = array[j];
    }

    if (array[j] > max)
    {
        max = array[j];
    } 
}
double result = Math.Round(max-min, 2);
Console.WriteLine(result);
*/