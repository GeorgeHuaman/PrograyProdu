using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Pokemon
{
    public string name;
    public float weight;
    public int exp;
    public string type;

    public Pokemon(string name, float weight, int exp, string type)
    {
        this.name = name;
        this.weight = weight;
        this.exp = exp;
        this.type = type;
    }

    public abstract string ShowDetails();

}
