using System;
class Lab13{
    public static void Main(String[] args){
        BuildingBlueprint buildingOne = new BuildingBlueprint();
        BuildingBlueprint buildingTwo = new BuildingBlueprint(30,30,0.75f);

        Console.WriteLine("Year 2022:");
        Console.WriteLine("Building 1 has {0} floors, {1} apartments, and is {2}% occupied. Full? {3}", buildingOne.getStories(), buildingOne.getApartments(), buildingOne.getOccupancyRate() * 100, buildingOne.getIsFull());
        Console.WriteLine("Building 2 has {0} floors, {1} apartments, and is {2}% occupied. Full? {3}\n", buildingTwo.getStories(), buildingTwo.getApartments(), buildingTwo.getOccupancyRate() * 100, buildingTwo.getIsFull());
        Console.WriteLine("Many years pass.\n");

        buildingOne.setOccupancyRate(0f);
        buildingTwo.setOccupancyRate(1f);

        Console.WriteLine("Year 2043:");
        Console.WriteLine("Building 1 has {0} floors, {1} apartments, and is {2}% occupied. Full? {3}", buildingOne.getStories(), buildingOne.getApartments(), buildingOne.getOccupancyRate() * 100, buildingOne.getIsFull());
        Console.WriteLine("Building 2 has {0} floors, {1} apartments, and is {2}% occupied. Full? {3}\n", buildingTwo.getStories(), buildingTwo.getApartments(), buildingTwo.getOccupancyRate() * 100, buildingTwo.getIsFull());

        Console.WriteLine("Looks like people prefer taller buildings");

    }
}

class BuildingBlueprint
{

    private int stories;
    private int apartments;
    private float occupancyRate;
    private bool isFull;
    public BuildingBlueprint()
    {
        this.stories = 10;
        this.apartments = 20;
        this.occupancyRate = 1.0f;
        this.isFull = true;
    }
    public BuildingBlueprint(int stories, int apartments, float occupancyRate)
    {
        this.stories = stories;
        this.apartments = apartments;
        this.occupancyRate = occupancyRate;
        this.isFull = this.occupancyRate == 1f ? true : false;
    }
    public int getStories(){
        return this.stories;
    }
    public int getApartments()
    {
        return this.apartments;
    }
    public float getOccupancyRate()
    {
        return this.occupancyRate;
    }
    public void setOccupancyRate(float newRate)
    {
        this.occupancyRate = newRate;
        this.isFull = this.occupancyRate == 1f ? true : false;
    }
    public bool getIsFull()
    {
        return this.isFull;
    }
}