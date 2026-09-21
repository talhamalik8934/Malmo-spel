class Map
{
 private Location?[][] Locations=
    {
        new Location?[5]{null, null , new Escalltor1() , new Roof() , null },
        new Location?[5]{new Foyer() , new Escalltor2() , new CorridorA() , null , null },
        new Location?[5]{new ToiletStall() , null , new OutsideDryCleaner() , new CorridorB() , null },
        new Location?[5]{null , null , new DryCleaner() , new SecurityOffice() , new TaxiStation() }
    };

    public Location GetLocation(int row,int col)
    {
        return Locations[row][col]!;
    }
    
    public bool PositionExists(int row, int col)
    {
        if (row<0 || row>= Locations.Length) //is row out of bounds?
        {
            return false;
        }

        if(col<0 || col>=Locations[row].Length) // is col out of bounds?
        {
            return false;
        }

        if(Locations[row][col]==null) // is position on a null "cell"?
        {
            return false;
        }
        return true;
    }
    

}