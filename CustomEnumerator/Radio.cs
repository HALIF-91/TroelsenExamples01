using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumerator
{
    public class Radio
    {
        public int Numb { get; set; }
        public Radio(int numb)
        {
            Numb = numb;
        }
        public void TurnOn(bool on)
        {
            if(on)
                Console.WriteLine("Jamming...");
            else
                Console.WriteLine("Quiet time...");
        }
    }
}
