using System;
public class MenuInputItem<T> : MenuItem
{
    public MenuInputItem(String displayText, String id) : base(displayText, id)
    {
        this.id = "";
    }
}