using System;
public class Menu{
    static Menu? currentActiveMenu;
    MenuItem[] items;
    int selectedItem = 0;

    public Menu(MenuItem[] items){
        this.items = items;
    }

    public void activateMenu(){
        Menu.currentActiveMenu = this;
        Console.Clear();
        foreach (MenuItem item in items)
        {   
            Console.WriteLine("{0}", item.displayText);
        }
        while(true){
            Console.SetCursorPosition(0, selectedItem);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(items[selectedItem].displayText);

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if(keyInfo.Key == ConsoleKey.UpArrow){
                nextItem();
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                previousItem();
            }
            
        }
    }

    private void nextItem(){
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(0, selectedItem);
        Console.Write(items[selectedItem].displayText);
        Console.WriteLine(selectedItem);
        selectedItem = (selectedItem - 1) % items.Length;
        Console.WriteLine(selectedItem);
    }

    private void previousItem()
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(0, selectedItem);
        Console.Write(items[selectedItem].displayText);
        selectedItem = (selectedItem + 1) % items.Length;
    }

}