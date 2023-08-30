using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public enum States
{
	captured,
	wild
}
public class State : Pokemon
{
    public States states;
    public State(string name, float weight, int exp, string type, States states) : base(name, weight, exp, type)
    {
        this.states = states;
    }

    public override string ShowDetails()
    {
        return $"{name},{weight},{exp}, {type},{states}";
    }

    public int Probability(Pokeballs pokeballs)
    {
        return pokeballs.probability -= 2;
    }
}