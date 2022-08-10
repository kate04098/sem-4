Console.Write("Введите число: ");
String? inputLine = Console.ReadLine();
int inputNum = int.Parse(inputLine);
Console.WriteLine(sumNums(inputNum));
int sumNums(int num)
{ int sum = 1;
for (int i = 1; i <= inputNum; i++)
{ 
//sum *=1;
sum=sum*1;
}
return sum;
}

