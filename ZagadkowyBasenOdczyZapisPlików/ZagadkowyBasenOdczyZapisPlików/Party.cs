using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZagadkowyBasenOdczyZapisPlików
{
    public class Party
    {
        private StreamReader reader;
        public Party(StreamReader reader)
        {
            this.reader = reader;
        }
        public void HowMuch(StreamWriter q)
        {
            q.WriteLine(reader.ReadLine);
            reader.Close();

        }
    }
}
