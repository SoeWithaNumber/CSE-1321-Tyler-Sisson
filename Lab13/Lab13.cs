using System;
class Lab13{
    public static void Main(String[] args){
        BuildingBlueprint buildingOne = new BuildingBlueprint();
        BuildingBlueprint buildingTwo = new BuildingBlueprint(30,30,0.75f);

        Console.WriteLine("Year 2022:");
        Console.WriteLine("Building 1 has {0} floors, {1} apartments, and is {2}% occupied. Full? {3}", buildingOne.stories, buildingOne.apartments, buildingOne.occupancyRate * 100, buildingOne.isFull);
        Console.WriteLine("Building 2 has {0} floors, {1} apartments, and is {2}% occupied. Full? {3}\n", buildingTwo.stories, buildingTwo.apartments, buildingTwo.occupancyRate * 100, buildingTwo.isFull);
        Console.WriteLine("Many years pass.\n");

        //Before docking points, look at the implementation of the BuildingBlueprint class
        buildingOne.occupancyRate = 0f;
        buildingTwo.occupancyRate = 1.0f;

        Console.WriteLine("Year 2043:");
        Console.WriteLine("Building 1 has {0} floors, {1} apartments, and is {2}% occupied. Full? {3}", buildingOne.stories, buildingOne.apartments, buildingOne.occupancyRate * 100, buildingOne.isFull);
        Console.WriteLine("Building 2 has {0} floors, {1} apartments, and is {2}% occupied. Full? {3}\n", buildingTwo.stories, buildingTwo.apartments, buildingTwo.occupancyRate * 100, buildingTwo.isFull);

        Console.WriteLine("Looks like people prefer taller buildings");

    }
}

class BuildingBlueprint
{

    /**
    Before you dock points, attributes can work differently in C#
    Rather than attributes, these are properties. They allow you to use dot-notation to access them outside of the class, but internally they use getters and setters.
    For example, if I made a BuildingBlueprint object called BP1, I could access the apartments property with BP1.apartments; and it would use the getter I define.
    As well, I could use BP1.occupancyRate = 0.12; And it would behave as if I used a setter with 0.12 as the argument.
    However, I could *not* do BP1.apartments = 13; because the setter I have is private. Setters are required, even if unused outside the class.
    The default ones (as used below) just return and set the value as-is. Though, if I wanted to, I could define my own logic. For instance, I could define logic for the occupancy rate setter to clamp the value between 0 and 1.

    Documentation: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties
    */

    public int stories { get; private set;}
    public int apartments { get; private set; }
    public float occupancyRate { get; set; }
    public bool isFull { get; private set; }
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
        this.isFull = isFull;
    }
}