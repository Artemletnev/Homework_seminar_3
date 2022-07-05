// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
string c = number.ToString();

if (c[0] == c[c.Length - 1])
{
     if (c[1] == c[c.Length - 2])
     {
        Console.WriteLine("The number is a palindrome");
     }

}
else
{
    Console.WriteLine("the number is not a palindrome");
}











