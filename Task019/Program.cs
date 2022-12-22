// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

Console.Write("Введите, пожалуйста, пятизначное число:  ");
int number = int.Parse(Console.ReadLine());
string str = "";

if (number > 0)
{
    str = number.ToString();

    if (str.Length == 5)
    {
        int[] array = new int[5];

        for (int i = 0; i < 5; i++)
        {
            array[i] = int.Parse(str[i].ToString());
        }

        if (array[0] == array[4] && array[1] == array[3])
            Console.WriteLine($"Число {number} является палиндромом.");

        else Console.WriteLine($"Число {number} НЕ является палиндромом.");
    }
    else Console.WriteLine($"Вы ввели неверное число. Введите, пожалуйста пятизначное число.");
}
else Console.WriteLine("Введите пожалуйста положительное пятизначное число");






// // Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// number = Math.Abs(number);

// string str = number.ToString();
// if (str.Length >= 3)
// {
//     int[] array = new int[str.Length];
//     for (int i = 0; i < str.Length; i++)
//     {
//         array[i] = int.Parse(str[i].ToString());
//     }
//     Console.WriteLine(array[2]);
// }
// else
//     Console.WriteLine("В заданном числе третьей цифры нет");

