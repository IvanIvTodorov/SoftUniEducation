using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : IDialing
    {
        public void CallTelephone(string number)
        {
            Console.WriteLine($"Dialing... {number}");
        }
    }
}
