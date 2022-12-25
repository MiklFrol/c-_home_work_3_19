// Программа принимает 5-ти значное число и проверяет является ли оно полиндромом

Console.Clear();

int getUserNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int GetFirstTwoDigits(int number)
{
    int result = number / 1000;
    return result; 
}

int GetLastTwoDigits(int number)
{
    int result = number % 100;
    return result; 
}

int GetReverseLastDigits( int number)
{
    int tempNumber =  number % 10;
    int tempNumber2 = number / 10;
    int result = tempNumber * 10 + tempNumber2; 
    return result;
    }

int number = getUserNumber("Введите пятизначное число");
int firstDigits = GetFirstTwoDigits(number);
int lastDigits = GetLastTwoDigits(number);
int reverseLastDigits = GetReverseLastDigits(lastDigits);

if (firstDigits == reverseLastDigits)
{
    Console.WriteLine($"Число {number} является палиндромом!");
}
else
{
    Console.WriteLine($"Число {number} не является палиндромом!");
}