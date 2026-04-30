using System;

namespace Review
{
    internal class SnakeAndLadder
    {
        int position = 0;
        int diceCount = 0;
        Random random = new Random();

        public void Play()
        {
            while (position < 100)
            {
                int dice = random.Next(1, 7);   // 1 to 6
                int option = random.Next(0, 3); // 0=NoPlay, 1=Ladder, 2=Snake

                diceCount++;
                Console.WriteLine($"Dice: {dice}");

                switch (option)
                {
                    case 0:
                        Console.WriteLine("No Play");
                        break;

                    case 1:
                        Console.WriteLine("Ladder");
                        position += dice;
                        break;

                    case 2:
                        Console.WriteLine("Snake");
                        position -= dice;
                        if (position < 0)
                            position = 0;
                        break;
                }

                if (position > 100)
                    position -= dice;

                Console.WriteLine($"Current Position: {position}\n");
            }

            Console.WriteLine($"🎉 You won in {diceCount} dice rolls!");
        }
    }
}