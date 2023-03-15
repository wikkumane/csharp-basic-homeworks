//Swap Numbers

Console.WriteLine("Enter first number");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int secondNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Before swap first number: {firstNum}, second number: {secondNum}");
int newNum = firstNum;
firstNum = secondNum;
secondNum = newNum;
Console.WriteLine($"After swap first number: {firstNum}, second number: {secondNum}");