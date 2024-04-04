using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    internal class Talker
    {
        public static int BlahBlahBlah(string thingToSay, int numberOfTimes)
        {
            string FinalString = "";
            for (int count = 1; count <= numberOfTimes; count++)
            {
                FinalString = FinalString + thingToSay + "\n";
            }
            MessageBox.Show(FinalString);
            return FinalString.Length;
        }
    }
}
