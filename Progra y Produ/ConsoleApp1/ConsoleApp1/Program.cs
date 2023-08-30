bool exit = false;
State charmander = new State("Charmander", 8.5f, 1500, "fire",States.wild);
Pokeballs masterball = new Pokeballs(Balls.masterball);
while (!exit)
{
    Console.WriteLine(charmander.ShowDetails());
    if (charmander.states == States.wild)
    {
        Console.WriteLine("Puedes capturarlo");
        Console.WriteLine("1 para capturar, 2 para cerrar el programa");
        string selection = Console.ReadLine();
        switch (selection)
        {
            case "1":
                if (charmander.Probability(masterball) > 4)
                {
                    charmander.states = States.captured;
                    Console.WriteLine(charmander.ShowDetails());
                }
                else
                    Console.WriteLine("Se escapo");
                
                break;
            case "2":
                exit = true;
                break;
            default:
                Console.WriteLine("Intenta otro Numero");
                continue;
        }
        
    }
    exit = true;
}