using System;
class Assignment6C{
    static void printArray(String[][] array){
        for (int row = 0; row < array.Length; row++)
        {
            for (int col = 0; col < array[row].Length; col++)
            {
                Console.Write("|{0}", array[row][col]);
            }
            Console.Write("|\n");
        }
    }
    static void addDisc(String[][] array, int column, string player){
        for (int row = array.Length-1; row >= 0; row--)
        {
            if(array[row][column] != " "){
                continue;
            }
            array[row][column] = player;
            break;
        }
    }
    static bool winHorizontal(String[][] array, string player){
        for (int row = 0; row < array.Length; row++)
        {
            int numInRow = 0;
            for (int col = 0; col < array[row].Length; col++)
            {
                if(array[row][col] == player){
                    numInRow++;
                }
            }
            if(numInRow == 4){
                return true;
            }
        }
        return false;
    }
    static bool winVertical(String[][] array, string player){
        for (int row = 0; row < array.Length; row++)
        {
            int numInRow = 0;
            for (int col = 0; col < array[row].Length; col++)
            {
                if(array[col][row] == player){
                    numInRow++;
                }
            }
            if(numInRow == 4){
                return true;
            }
        }
        return false;
    }
    public static void Main(String[] args){
        String[][] board = new String[4][];
        for (int i = 0; i < board.Length; i++)
        {
            board[i] = new String[4] {" "," "," "," "};
        }

        string turn = "X";

        while (true)
        {
            int playerNum = turn == "X" ? 1 : 2;
            Console.Write("{0}, enter a column: ", playerNum);
            int col = Convert.ToInt32(Console.ReadLine());
            addDisc(board, col, turn);
            printArray(board);
            bool playerWinVert = winVertical(board, turn);
            bool playerWinHor = winHorizontal(board, turn);
            if(playerWinVert || playerWinHor){
                Console.WriteLine("Player {0} wins!", playerNum);
                break;
            }
            turn = turn == "X" ? "O" : "X";

        }
    }
}