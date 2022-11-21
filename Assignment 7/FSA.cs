using System;

public class FSA{
    
    private int state;
    private bool active = true;

    public FSA(){
        this.state = 0;
    }

    public FSA(int state){
        if(state < 0 || state > 3){
            Console.WriteLine("Invalid state. Starting at 0");
            this.state = 0;
        }
        else{
            this.state = state;
        }
    }

    public int goToNextState(){
        state = (state + 1) % 4;
        return state;
    }

    public bool end(){
        if(state != 3){
            Console.WriteLine("You can't stop here; you can only stop at state 3");
            return false;
        }
        else{
            Console.WriteLine("The machine has stopped");
            active = false;
            return true;
        }
    }

    public int showCurrentState(){
        return state;
    }

    public bool isActive(){
        return active;
    }

}