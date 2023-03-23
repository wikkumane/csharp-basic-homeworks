//Task 1 

Console.WriteLine("Enter a sentence longer than 5 characters, this will print the last 5 letters of the sentence");
string InputSentence = Console.ReadLine();  

if (InputSentence.Length < 5)
{
    Console.WriteLine("Enter a sentence longer than 5 characters!");
} else
{
    string LastFive = InputSentence.Substring(InputSentence.Length - 5);
    Console.WriteLine(LastFive);
}

//Task 2 

Console.WriteLine("Enter any sentence, this will split the sentence with a space between every letter");
string InputSentenceTwo = Console.ReadLine();

string[] TaskTwoSplit = InputSentenceTwo.Split(" ");

// Task 3 

