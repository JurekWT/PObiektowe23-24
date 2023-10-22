// See https://aka.ms/new-console-template for more information

int sum = 0, temp = 1, count = 0;
while (sum < 100)
{
    sum += temp;
    count++;
    temp++;
}
Console.WriteLine(count);