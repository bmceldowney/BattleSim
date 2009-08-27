using System;

namespace ChaosMules
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (ChaosMules game = new ChaosMules())
            {
                game.Run();
            }
        }
    }
}

