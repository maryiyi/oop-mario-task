namespace mario;
public class Player
{
    private string Name;
    private int Score = 0;

    public Player(string name)
    {
        Name = name;
    }

    public void Collect(Coin coin)
    {
        int value = coin.Take();
        if (value > 0)
        {
            Score += value;
            Console.WriteLine($"{Name} collected {value}, score = {Score}");
        }

        if (value == 0)
        {
            Console.WriteLine($"{Name}: coin already taken");
        }
        else
        {
            Console.WriteLine("error");
        }
    }
    
    public int GetScore()
    {
        return Score;
    }
    
}

