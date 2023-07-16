/*// Task 1. Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int StepNumber(int number, int degree)
{
    int num = 1;
    for(int i = 0; i < degree; i++)
    {
        num *= number;
    }
    return num;
}

bool FalseStep(int degree)
{
    if(degree < 0)
    {
        Console.WriteLine("the degree cannot be less than 0 !");
        return false;
    }
    else return true;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a degree of the number: ");
int degree = Convert.ToInt32(Console.ReadLine());

if(FalseStep(degree))
{
    Console.WriteLine("Результат = {0}", StepNumber(number, degree));
}
*/

/*// Task 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//           452 -> 11
//           82 -> 10
//           9012 -> 12

int Count(int number)
{
    int result = 0;
    while(number > 0)
    {
        result += number %10;
        number = number /10;
    }
    return result;
}

Console.Write("Input a random number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("the sum of the digits in the number = {0}", Count(number));
*/

/*// Task 3. Напишите программу, которая задаёт массив из m элементов и выводит их на экран. 
// Разработать метод CreateArray(int size), генерирующий массив на основе данных, вводимых пользователем.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int size)
{
    int[] array = new int[size];

    Console.WriteLine("Input a Array Elements: ");

    for(int i = 0; i < size; i++)
    {
        Console.Write("{0}, ", i);
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");

    Console.WriteLine("]");
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(length);
ShowArray(myArray);
*/

