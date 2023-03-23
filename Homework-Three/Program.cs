int multiply (int FirstNum, int SecondNum) { return FirstNum * SecondNum; }

int divide(int FirstNum, int SecondNum) { return FirstNum / SecondNum; }

void MainCalculator()
{
    Console.WriteLine("Enter your first number");
    int FirstNumInput = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter your desired operator");
    string inputOperator = Console.ReadLine();

    Console.WriteLine("Enter your second number");
    int SecondNumInput = Convert.ToInt32(Console.ReadLine());

    switch (inputOperator)
    {
        case "*":
            Console.WriteLine($"{multiply(FirstNumInput, SecondNumInput)}");
            break;

        case "/":
            if (SecondNumInput == 0)
            {

                Console.WriteLine("You cannot divide with zero");

            }
            else

            {

                Console.WriteLine($"{divide(FirstNumInput, SecondNumInput)}");
            }

            break;


    }



}

MainCalculator();