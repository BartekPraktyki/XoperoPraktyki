using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfejsTallGuy
{
    public interface IClown
    {
        string FunnyThingIHave
        {
            get { return "duże buty";  }
        }
        public void Honk() 
        {
            Console.WriteLine("Tut tuut!");
        } 
    }
}
