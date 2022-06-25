//Дано двузначное натуральное число.
//Верно ли, что квадрат суммы его цифр больше самого числа

//Console.WriteLine("Введите число");
//int  = Convert.ToInt32(Console.ReadLine());
//if (


//Дана строка. Подсчитать количество содержащихся в ней цифр
//string newString = "125_tywerd_ef125we";

string newString;
newString = Console.ReadLine();
if (newString != null)
{
    int count = 0;

    foreach (var i in newString) if (char.IsDigit(i)) count++;
    Console.WriteLine(count);
}