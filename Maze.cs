namespace Maze
{
    public class Maze 
    {

        private int _Width;
        private int _Height;
        private Player _Player;
        private Imazeobject[,] _MazeobjectArray;
       
        public Maze(int width, int height)
        {
            _Width = width;
            _Height = height;
            _MazeobjectArray = new Imazeobject[width, height];
            _Player = new Player() { X = 1, Y = 1 }; // Initialize player position
        }
        public void DrawMaze()
        {
            Console.Clear();


            for (int y = 0; y < _Height; y++)
            {

                for (int x = 0; x < _Width; x++)
                {
                    
                     if (x == _Width - 2 && y == _Height - 1) //Ending Point
                    {
                        _MazeobjectArray[x, y] = new Emptyspace();
                        Console.Write(_MazeobjectArray[x, y].icon);


                    }
                   
                    

                    else if (x == 0 || x == _Width - 1 || y == 0 || y == _Height - 1) //Outer Wall
                    {

                        _MazeobjectArray[x, y] = new Wall();
                        Console.Write(_MazeobjectArray[x, y].icon);

                    }

                    else if (x % 2 == 0 && y % 2 != 0) //Inner Wall
                    {
                        _MazeobjectArray[x, y] = new Wall();
                        Console.Write(_MazeobjectArray[x, y].icon);
                    }



                    else if (x % 5 == 0 && y % 3 == 0) //Inner Wall
                    {
                        _MazeobjectArray[x, y] = new Wall();
                        Console.Write(_MazeobjectArray[x, y].icon);
                    }
                    else if (x == _Player.X && y == _Player.Y)//Player
                    {
                        Console.Write(_Player.icon);
                    }


                    else // Empty space
                    {
                            _MazeobjectArray[x, y] = new Emptyspace();
                            Console.Write(_MazeobjectArray[x, y].icon);
                        



                    }




                }
                Console.WriteLine();
            }

        }
        public void movePlayer()
        {
            ConsoleKeyInfo userInput = Console.ReadKey(true);
            ConsoleKey key = userInput.Key;
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    updatePlayer(0, -1);
                    // Move player up
                    break;
                case ConsoleKey.DownArrow:
                    updatePlayer(0, 1);
                    // Move player down
                    break;
                case ConsoleKey.LeftArrow:
                    updatePlayer(-1, 0);
                    // Move player left
                    break;
                case ConsoleKey.RightArrow:
                    updatePlayer(1, 0);
                    // Move player right
                    break;
                default:
                    Console.WriteLine("Invalid key. Use arrow keys to move!!!");
                    break;
            }

        }
        private void updatePlayer(int dx, int dy)
        {
            int newX = _Player.X + dx;
            int newY = _Player.Y + dy;
            if (newX < _Width && newX >= 0 && newY < _Height && newY >= 0 && _MazeobjectArray[newX, newY].isSolid == false)
            {
                _Player.X = newX;
                _Player.Y = newY;
                DrawMaze();

                if (newX == _Width - 2 && newY == _Height - 1)
                {
                    Console.Clear();
                    Console.WriteLine("You have reached the end of the maze!");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

            }

            

        }
    }
}
