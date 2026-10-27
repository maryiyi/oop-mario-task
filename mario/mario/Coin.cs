namespace mario;

public class Coin
{
    private int Value;
    private bool Taken = false;

    public Coin(int value)
    {
        Value = value;
    }

    public int Take()
    {
        if (Taken == true)
        {
            return 0;
        }
        return Value;
    }

    
    
}