bool exit = false;
State charmander = new State("Charmander", 8.5f, 1500, "fire",States.wild);
Pokeballs masterball = new Pokeballs(Balls.masterball);
while (!exit)
{
    Console.WriteLine(charmander.ShowDetails());
    string selection = Console.ReadLine();
    switch (selection)
    {
        case "1":
            break;
        case "2":
            break;
        case "3":
            break;
        default:
            break;
    }
    exit = true;
}