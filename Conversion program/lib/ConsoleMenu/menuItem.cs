using System;
public class MenuItem<T>
{
    protected String displayText;
    protected T returnValue;
    public MenuItem(String displayText, T returnValue){
        this.displayText = displayText;
        this.returnValue = returnValue;
    }
}