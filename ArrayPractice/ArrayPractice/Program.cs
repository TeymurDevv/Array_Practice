#region task1
using System.Diagnostics.Metrics;

int[] numbers = { 1,4,5,10,30 };
int sum = 0;
int actualValue = 0;
for (int i = 0; i <= numbers.Length-1; i++)
{
    actualValue = numbers[i];
    sum = sum + actualValue;
}
Console.WriteLine(sum);
#endregion
#region task2
int[] nums = { 11, 20, 1, 2, 5, 30 };
int isBiggerFromTen = 0;
foreach (int number in nums)
{
    if (number>10)
    {
        isBiggerFromTen++;
    }
}
Console.WriteLine(isBiggerFromTen);
#endregion
#region task3
int midCounter = 0;
int calculation = 0;
int[] mid = { 11, 20, 1, 2, 5, 30 };
foreach (var number in mid)
{
    midCounter++;
    calculation += number;
}
Console.WriteLine(calculation/midCounter);
#endregion
# region task4
string[] months = { "yanvar", "fevral", "mart", "aprel", "may", "iyun", "iyul", "avqust", "sentyabr", "oktyabr", "noyabr", "dekabr" };
foreach (var month in months)
{
    if (month == "yanvar" || month == "fevral" || month == "mart")
    {
        Console.WriteLine($"{month} ayı qış fəslinə aiddir...");
    }



}

#endregion