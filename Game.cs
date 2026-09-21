class Game
{
    bool isRunning=true;
    Player player=new(2,0); // Starting position.
    Map map=new();
    Menu menu=new();
    
    public void Start()
    {
        // Game start
        Console.WriteLine("Emporia Amnesia");
        while(isRunning)
        {
            PlayTurn();

        }
   
   
    }
    Location CurrentLocation()
    {
        return map.GetLocation(player.Row,player.Col);
    }
    void PlayTurn()
    {
        Location location= CurrentLocation();

        Console.WriteLine($"\n === {location.Name}===");
        Console.WriteLine(location.Description);
    }
}