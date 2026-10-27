using mario;

Player mario = new Player("Mario");
Coin gold = new Coin(10);
Coin silver = new Coin(5);

mario.Collect(gold);
mario.Collect(silver);
mario.Collect(gold);

Console.WriteLine($"Final score: {mario.GetScore()}");
return 0;
