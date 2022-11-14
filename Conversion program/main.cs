using System;
class Runner{
    public static void Main(String[] args){
        MenuItem[] items = new MenuItem[3]{
            new MenuItem("String","You selected string"),
            new MenuItem("Ints","You selected int"),
            new MenuItem("Float","You selected float")
        };
        Menu testMenu = new Menu(items, new String[]{"Welcome to the test menu!", "Use arrow keys to navigate and enter to select"});
        Console.WriteLine(testMenu.activateMenu());
    }
}