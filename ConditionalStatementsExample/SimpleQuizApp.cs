string Question1 = "What is the capital of France?";
string answer1 = "Paris";

string Question2 = "What is 2 + 2?";
string answer2 = "4";

string Question3 = "What is the largest planet in our solar system?";
string answer3 = "Jupiter";

int score = 0;

Console.WriteLine("Welcome to the Quiz!");

Console.WriteLine(Question1);
string userAnswer1 = Console.ReadLine();
if (userAnswer1.Trim().ToLower() == answer1.ToLower())
{
    score++;
    Console.WriteLine("Correct!");
}
else
{
    Console.WriteLine($"Wrong! The correct answer is {answer1}.");
}

Console.WriteLine(Question2);
string userAnswer2 = Console.ReadLine();
if (userAnswer2.Trim().ToLower() == answer2.ToLower())
{
    score++;
    Console.WriteLine("Correct!");
}
else
{
    Console.WriteLine($"Wrong! The correct answer is {answer2}.");
}

Console.WriteLine(Question3);
string userAnswer3 = Console.ReadLine();
if (userAnswer3.Trim().ToLower() == answer3.ToLower())
{
    score++;
    Console.WriteLine("Correct!");
}
else
{
    Console.WriteLine($"Wrong! The correct answer is {answer3}.");
}
Console.WriteLine($"Your total score is: {score}/3");
Console.WriteLine("Thank you for playing the Quiz!");
Console.ReadKey();
