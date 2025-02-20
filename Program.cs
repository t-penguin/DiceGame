/*
1. Create two dice objects, roll both dice and compare which one is bigger
2. Repeat the above task 5 times and compare which dice wins more
3. Implement a method to check if an array tracking the top side after rolling N=5 times contains a given number
4. Implement a method to create an array of unique numbers by rolling a dice (as many times as needed)
*/

// Task 1
Dice d1 = new Dice();
Dice d2 = new Dice();

int d1Roll = d1.Roll();
int d2Roll = d2.Roll();

Console.WriteLine($"Single Round:\nDice 1: {d1Roll}\nDice2: {d2Roll}");
if (d1Roll > d2Roll)
    Console.WriteLine("Dice 1 beat Dice 2!");
else if (d1Roll < d2Roll)
    Console.WriteLine("Dice 2 beat Dice 1!");
else
    Console.WriteLine("It's a tie!");

// Task 2
int count = 0;
Console.WriteLine("\nBest of 5 round: ");
for (int i = 1; i < 6; i++)
{
    d1Roll = d1.Roll();
    d2Roll = d2.Roll();

    Console.Write($"Round {i}: ");
    if (d1Roll > d2Roll)
    {
        Console.WriteLine("Dice 1 beat Dice 2!");
        count++;
    }
    else if (d1Roll < d2Roll)
    {
        Console.WriteLine("Dice 2 beat Dice 1!");
        count--;
    }
    else
        Console.WriteLine("It's a tie!");
}

if (count > 0)
    Console.WriteLine("Dice 1 wins!");
else if (count < 0)
    Console.WriteLine("Dice 2 wins!");
else
    Console.WriteLine("It's a tie!");