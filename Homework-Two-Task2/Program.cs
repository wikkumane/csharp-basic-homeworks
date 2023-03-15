string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG2 = { "Josko", "Josip", "Luka", "Stojan", "Kiril"};
Console.WriteLine("Enter 1 to show students of G1, enter 2 to show students of G2");
int input = Convert.ToInt32(Console.ReadLine());

if (input == 1)
{
    Console.WriteLine("The students of G1 are:");
        foreach(string student in studentsG1)
    {
        Console.WriteLine(student);
    }
} else if  (input == 2)
{
    Console.WriteLine("The students of G2 are:");
            foreach(string student in studentsG2) 
        {  
            Console.WriteLine(student); 
        }
} else
{
    Console.WriteLine("Wrong input");
}