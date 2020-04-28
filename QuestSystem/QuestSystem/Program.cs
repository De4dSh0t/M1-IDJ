using System;

namespace QuestSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Quest q = new Quest("Timer Test", 
                "Quest para testar o Timer", 
                10000, "Main Quest", 
                "Dev",
                Status.INACTIVE);
            
            //Testar o Timer
            string input = Console.ReadLine();
            
            if (input == "c")
            {
                q.QuestStatus = Status.ACTIVE;
            }

            while (q.QuestStatus != Status.CANCELLED)
            {
                if (q.QuestStatus == Status.CANCELLED)
                {
                    Console.WriteLine("Quest Terminated!");
                }
            }
        }
    }
}