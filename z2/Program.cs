Console.Clear();
Console.Write("Введите число: ");
string inputLineNumber = Console.ReadLine()??"";
int inputNumber = int.Parse(inputLineNumber);
int VariantChar()
{
//int numberLength = 0;
//char[] array = inputLineNumber.ToCharArray();
//numberLength = array.Length;
return inputLineNumber.ToCharArray();
}
      int VariantSimple()
{
 int numberLength = 0;
 int digits =1;
while(digits<inputNumber)
{
digits= digits*10;
numberLength++;
}
return numberLength;
}
int VariantLog10()
{
return (int) Math.Log10(inputNumber);
}
int result = 0;
timePoint = DateTime.Now;
result = VariantChar();
  Console.WriteLine(result);
  Console.WriteLine(DateTime.Now- timePoint);
result = VariantSimple ();
  Console.WriteLine(result);
  Console.WriteLine(DateTime.Now- timePoint);
result = VariantLog10();
  Console.WriteLine(result);
  Console.WriteLine(DateTime.Now- timePoint);

