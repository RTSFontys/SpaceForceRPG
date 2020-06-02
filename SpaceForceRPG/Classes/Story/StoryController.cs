using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceForceRPG.Classes.Story
{
    class StoryController
    {
        public StoryController()
        {

        }

        public void AttackUse(string line, string attackName, bool isHeal, int damage = 0)
        {
            if (isHeal)
                Console.WriteLine(line, attackName);
            else
                Console.WriteLine(line, attackName, damage);
        }

        public void WriteLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}
