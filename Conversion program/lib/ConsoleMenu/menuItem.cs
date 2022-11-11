using System;

public class MenuItem
{
    public String displayText{get;}
    private String id;
    public MenuItem(String displayText, String id){
        this.displayText = displayText;
        this.id = id;
    }
    public String select(){
        return id;
    }
}