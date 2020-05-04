using System;
using System.Collections.Generic;

namespace QuestSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Quest q = new Quest("Timer Test", 
                "Quest para testar o Timer", 
                10000, 
                QuestTypes.MAIN, 
                new List<string> { "DEV", "FARMER", "OFFICER" },
                Status.INACTIVE);
        }
    }
}