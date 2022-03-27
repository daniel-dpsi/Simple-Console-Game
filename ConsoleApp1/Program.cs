Random random = new Random();

int pX = random.Next(1, 50);
int pY = random.Next(1, 27);

int score = 0;

ConsoleKeyInfo input;
int x = 50;
int y = 15;
Console.WriteLine("Controls W,A,S,D (Press a button to start) ->");

while (true)
{
        input = Console.ReadKey();
        var output = input.ToString();

        if (input.Key == ConsoleKey.W && y > 1)
        {
            y--;
        }
        if (input.Key == ConsoleKey.S && y < 27)
        {
            y++;
        }
        if (input.Key == ConsoleKey.A && x > 1)
        {                                
            x--;                                      
        }                                
        if (input.Key == ConsoleKey.D && x < 90)
        {
            x++;
        }

        Console.Clear();
        Console.SetCursorPosition(x, y);
        Console.Write("+"); // {x},{y} pos 
        Thread.Sleep(2);

    //Score
    Console.SetCursorPosition(0, 0);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"{score}");
    Console.ForegroundColor = ConsoleColor.Gray;

    scores();

     if (input.Key == ConsoleKey.C)
     {
        Console.Clear();
        Console.WriteLine($"Final score {score}\n");
        Console.WriteLine($"Press any key if you would like to continue playing!");
     }
}

void scores()
{
    Console.SetCursorPosition(pX, pY);
    Console.Write("o");
    if (x == pX && y == pY)
    {
        pX = random.Next(1, 50);
        pY = random.Next(1, 27);
        score++;
    }  
}

