using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Model
{
    class Kid : Man
    {
        public override void Play()
        {
            Console.WriteLine("The kid is playing");
        }
    }
}
