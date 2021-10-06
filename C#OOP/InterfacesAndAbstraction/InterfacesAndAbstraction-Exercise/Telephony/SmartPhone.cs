using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class SmartPhone : ISmartPhone
    {

        public void Browse(string website)
        {
            Console.WriteLine($"Browsing: {website}!");
        }

        public void CallPhone(string number)
        {
            Console.WriteLine($"Calling... {number}");
        }
    }
}
