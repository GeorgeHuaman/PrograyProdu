using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Balls
{
    pokeball,
    superball,
    masterball
}
public class Pokeballs
{
    public int probability;
    public Balls balls;

    public Pokeballs(Balls balls)
    {
        switch (balls)
        {
            case Balls.pokeball:
                this.probability = 2;
                break;
            case Balls.superball:
                this.probability = 5; 
                break;
            case Balls.masterball:
                this.probability = 10;
                break;
        }
    }
    
}
