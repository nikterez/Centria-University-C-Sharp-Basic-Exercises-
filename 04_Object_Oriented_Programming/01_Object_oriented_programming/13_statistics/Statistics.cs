using System;

public class Statistics
{
    public int count{get;set;}
    public int sum{get;set;}

    /*public Statistics()
    {
        this.count=0;
        this.sum=0;
    }*/

    public void AddNumber(int number)
    {
        this.sum+=number;
        this.count++;
    }


}