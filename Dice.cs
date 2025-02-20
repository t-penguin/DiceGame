/* Joseph Collado

UML
Class: Dice 

Fields:
- numSides : int

Properties:
+ Sides : int

Methods:
+ Dice(sides: int)
+ Roll() : int

*/

class Dice
{
    private int numSides;

    public int Sides 
    { 
        get => numSides; 
        private set
        {
            // Ensures the dice has at least one face
            if (value < 1)
                value = 1;
            
            numSides = value;
        } 
    }

    public Dice(int sides = 6) => Sides = sides;

    // Returns a random integer between 1 and the number of sides, inclusive
    public int Roll()
    {
        Random random = new Random();
        return random.Next(0, Sides) + 1;
    }
}