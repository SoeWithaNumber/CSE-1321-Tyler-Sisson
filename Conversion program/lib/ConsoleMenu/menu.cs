using System;
public class Menu{
    static Menu? currentActiveMenu;
    MenuItem<object>[] items;
    int selectedItem = 0;

    public Menu(MenuItem<object>[] items){
        this.items = items;
    }

    public void activateMenu(){
        Menu.currentActiveMenu = this;
    }

    public void nextItem(){
        selectedItem = (selectedItem + 1) % items.Length;
    }

    public void previousItem()
    {
        selectedItem = (selectedItem - 1) % items.Length;
    }

}