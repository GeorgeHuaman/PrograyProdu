using System;

class Type
{
    public string type;
}

public class Pokemon:Type
{
    private string name;
    private float weight;
    private int exp;

    public Pokemon(string name, float weight, int exp,string type) 
    {
        this.name = name;
        this.weight = weight;
        this.exp = exp;
        this.type = type;
    }

}



class program
{
    static void Main(string[] args)
    {
        Pokemon charmander = new Pokemon("Charmander", 8.5f, 1500,"fire");
        
    }
}