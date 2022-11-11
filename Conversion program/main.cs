using System;
class Runner{
    public static void Main(String[] args){
        MenuItem[] items = new MenuItem[3]{
            new MenuItem("Strings","str"),
            new MenuItem("Ints","int"),
            new MenuItem("Float","flt")
        };
        Menu testMenu = new Menu(items);
        testMenu.activateMenu();
    }
}