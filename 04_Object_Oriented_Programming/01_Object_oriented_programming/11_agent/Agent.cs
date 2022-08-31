using System;

public class Agent
{
    public string name;
    public string lastName;
    
    public Agent(string name, string lastName)
    {
        this.name=name;
        this.lastName=lastName;
    }
    public override string ToString()
    {
        return "My name is "+this.lastName+". "+this.name+" "+this.lastName+".";
    }
}