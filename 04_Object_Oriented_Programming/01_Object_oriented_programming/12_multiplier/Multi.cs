using System;

public class Multiplier
{
    public int number;

    public Multiplier(int number)
    {
        this.number=number;
    }

    public int Multiply(int number)
    {
        int valueNum=number*this.number;
        this.number=valueNum;
        return valueNum;
    }
}
