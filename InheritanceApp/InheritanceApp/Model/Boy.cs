using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Model
{
    class Boy : Man
    {
   

        public override void Play()
        {
            Console.WriteLine("The boy is playing");
        }

        public void Jump()
        {
            Console.WriteLine("The boy is jumping");
        }
    }
}
