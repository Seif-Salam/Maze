namespace Maze
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Maze maze = new Maze(60, 20);// Construct a new maze with specified width and height
            Console.WriteLine("Welcome to the Maze Game!");
            Console.WriteLine("Use Arrows Key To Move The Player");

            
            while (true)
            {
                
                maze.DrawMaze(); // Draw the maze
                maze.movePlayer(); // Move the player
            }

        }
    }

}
