//Real Calculator

Console.WriteLine("Enter your first number");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your operand(- + / *)");
string operand = Convert.ToString(Console.ReadLine());

Console.WriteLine("Enter your second number");
int secondNum = Convert.ToInt32(Console.ReadLine());

if (operand == "+")
{
    Console.WriteLine($"The result is {firstNum + secondNum}");
}
else if (operand == "-")
{
    Console.WriteLine($"The result is {firstNum - secondNum}");
}
else if (operand == "*")
{
    Console.WriteLine($"The result is {firstNum * secondNum}");
}
else if (operand == "/")
{
    Console.WriteLine($"The result is {firstNum / secondNum}");
}
else
{
    Console.WriteLine("Wrong input");    
}
