using System;
public class Menu{
    MenuItem[] items;
    int selectedItem = 0;
    String[] menuText;
    int offset;

    public Menu(MenuItem[] items, String[] menuText){
        this.items = items;
        this.menuText = menuText;
        offset = menuText.Length;
    }

    public String activateMenu(){
        InitializeMenu();
        while(true){
            Console.SetCursorPosition(0, selectedItem + offset);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(items[selectedItem].displayText);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if(keyInfo.Key == ConsoleKey.UpArrow){
                NextItem();
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                PreviousItem();
            }
            else if(keyInfo.Key == ConsoleKey.Enter){
                Cleanup();
                return items[selectedItem].Select();
            }
            
        }
    }

    protected void InitializeMenu(){
        Console.Clear();
        Console.CursorVisible = false;
        Console.Write(String.Join("\n", menuText) + "\n");
        foreach (MenuItem item in items)
        {
            Console.WriteLine("{0}", item.displayText);
        }
    }

    private void Cleanup()
    {
        Console.SetCursorPosition(0, items.Length + menuText.Length);
        Console.CursorVisible = true;
    }

    private void NextItem(){
        Console.CursorLeft = 0;
        Console.Write(items[selectedItem].displayText);
        selectedItem = (((selectedItem - 1) % items.Length) + items.Length) % items.Length;
    }

    private void PreviousItem()
    {
        Console.CursorLeft = 0;
        Console.Write(items[selectedItem].displayText);
        selectedItem = (selectedItem + 1) % items.Length;
    }

}