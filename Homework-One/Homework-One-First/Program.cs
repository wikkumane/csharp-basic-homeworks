//Average Number 

Console.WriteLine("Enter your first number");
int firstNum = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Enter second number");
int secondNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third number");
int thirdNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter fourth number");
int fourthNum = Convert.ToInt32(Console.ReadLine());    

decimal avgNumber = (firstNum + secondNum + thirdNum + fourthNum) / 4;
Console.WriteLine($"The average of {firstNum}, {secondNum}, {thirdNum}, {fourthNum} is {avgNumber}");

