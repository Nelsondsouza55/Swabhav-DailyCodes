using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Model
{
    class Man
    {
        public void Read()
        {
            Console.WriteLine("The man is reading");
        }

        public virtual void Play()
        {
            Console.WriteLine("The man is playing");
        }

        public void Walk()
        {
            Console.WriteLine("The man is walking");
        }
    }
}
