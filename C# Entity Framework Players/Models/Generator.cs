using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    static public class Generator
    {
        public static int generateScore()
        {
            Random random = new Random();
            return random.Next(1, 10);
        }

        public static int generateMatches()
        {
            Random random = new Random();
            return random.Next(1, 100);
        }

        public static int generateWins(int numberOfMatches)
        {
            Random random = new Random();
            return random.Next(1, numberOfMatches);
        }
    }
}