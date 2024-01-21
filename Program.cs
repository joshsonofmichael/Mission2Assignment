//using Mission2Assignment;


using Mission2Assignment;

Console.WriteLine("Welcome to the dice throwing simulator!");
Console.WriteLine("How many dice rolls would you like to simulate?");
string input = Console.ReadLine();
int numRolls = int.Parse(input);

//Console.WriteLine(numRolls);
Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
Console.WriteLine("Each '*' represents 1% of the total number of rolls");
Console.WriteLine("Total number of rows = " + numRolls);

RollDice rollDice = new RollDice();

int[] results = rollDice.Roll(numRolls);
for (int i = 0; i < results.Length; i++)
{
    float percent = ((float)results[i] / numRolls) * 100;
    int roundedPercent = (int)Math.Round(percent);
    string numStars = String.Concat(Enumerable.Repeat("*", roundedPercent));
    if (i < 8)
    {
        numStars = " " + numStars;
    }

    Console.WriteLine((i + 2) + ": " + numStars);
}

Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
