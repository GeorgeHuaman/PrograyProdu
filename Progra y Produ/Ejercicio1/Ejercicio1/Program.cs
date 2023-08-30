using System;

public class Pokemon
{
    private string name;
    private float weight;
    private int exp;

    public Pokemon(string name, float weight, int exp) 
    {
        this.name = name;
        this.weight = weight;
        this.exp = exp;
    }

}

class program
{
    static void Main(string[] args)
    {
        Pokemon charmander = new Pokemon("Charmander", 8.5f, 1500);

    }
}