using System;

namespace QuestSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonWriter jsonWriter = new JsonWriter();
            jsonWriter.Write();
            QuestManager questManager = new QuestManager();
            questManager.ReadJson("quests.json");

            bool end = false;
            
            //Basic program to test the QuestManager
            while (!end)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                
                Console.WriteLine("-------- QuestSystem --------");
                Console.WriteLine("(1) List All Quests");
                Console.WriteLine("(2) List Active Quests");
                Console.WriteLine("(3) List Inactive Quests");
                Console.WriteLine("(4) List Completed Quests");
                Console.WriteLine("(5) List Cancelled Quests");
                Console.WriteLine("(6) List QuestKill");
                Console.WriteLine("(7) List QuestEscort");
                Console.WriteLine("(8) List QuestCollect");
                Console.WriteLine("(9) Total Progress");
                Console.WriteLine("(0) Quit");
                Console.WriteLine("-----------------------------");

                switch (info.KeyChar)
                {
                    case '1':
                    {
                        int i = 0;
                        
                        foreach (var q in questManager.quest)
                        {
                            Console.WriteLine($"({i++}) {q.Name}");
                            Console.WriteLine($"-> Description: {q.Description}");
                            Console.WriteLine($"-> Is main: {q.IsMain}");
                            Console.WriteLine($"-> Requirements: {q.Requirements[0]}, {q.Requirements[1]}");
                            Console.WriteLine($"-> Status: {q.QuestStatus}");
                            Console.WriteLine("");
                        }

                        Console.WriteLine("");
                        Console.WriteLine("Press enter to return to Main Menu.");
                        break;
                    }

                    case '2':
                    {
                        int i = 0;
                        
                        foreach (var q in questManager.ActiveQuests())
                        {
                            Console.WriteLine($"({i++}) {q.Name}");
                            Console.WriteLine($"-> Description: {q.Description}");
                            Console.WriteLine($"-> Is main: {q.IsMain}");
                            Console.WriteLine($"-> Requirements: {q.Requirements[0]}, {q.Requirements[1]}");
                            Console.WriteLine($"-> Status: {q.QuestStatus}");
                            Console.WriteLine("");
                        }
                        
                        Console.WriteLine("");
                        Console.WriteLine("Press enter to return to Main Menu.");
                        break;
                    }

                    case '3':
                    {
                        int i = 0;
                        
                        foreach (var q in questManager.InactiveQuests())
                        {
                            Console.WriteLine($"({i++}) {q.Name}");
                            Console.WriteLine($"-> Description: {q.Description}");
                            Console.WriteLine($"-> Is main: {q.IsMain}");
                            Console.WriteLine($"-> Requirements: {q.Requirements[0]}, {q.Requirements[1]}");
                            Console.WriteLine($"-> Status: {q.QuestStatus}");
                            Console.WriteLine("");
                        }
                        
                        Console.WriteLine("");
                        Console.WriteLine("Press enter to return to Main Menu.");
                        break;
                    }

                    case '4':
                    {
                        int i = 0;
                        
                        foreach (var q in questManager.CompletedQuests())
                        {
                            Console.WriteLine($"({i++}) {q.Name}");
                            Console.WriteLine($"-> Description: {q.Description}");
                            Console.WriteLine($"-> Is main: {q.IsMain}");
                            Console.WriteLine($"-> Requirements: {q.Requirements[0]}, {q.Requirements[1]}");
                            Console.WriteLine($"-> Status: {q.QuestStatus}");
                            Console.WriteLine("");
                        }
                        
                        Console.WriteLine("");
                        Console.WriteLine("Press enter to return to Main Menu.");
                        break;
                    }

                    case '5':
                    {
                        int i = 0;
                        
                        foreach (var q in questManager.CancelledQuests())
                        {
                            Console.WriteLine($"({i++}) {q.Name}");
                            Console.WriteLine($"-> Description: {q.Description}");
                            Console.WriteLine($"-> Is main: {q.IsMain}");
                            Console.WriteLine($"-> Requirements: {q.Requirements[0]}, {q.Requirements[1]}");
                            Console.WriteLine($"-> Status: {q.QuestStatus}");
                            Console.WriteLine("");
                        }
                        
                        Console.WriteLine("");
                        Console.WriteLine("Press enter to return to Main Menu.");
                        break;
                    }

                    case '6':
                    {
                        int i = 0;
                        
                        foreach (var qK in questManager.ListQuestKill())
                        {
                            Console.WriteLine($"({i++}) {qK.Name}");
                            Console.WriteLine($"-> Description: {qK.Description}");
                            Console.WriteLine($"-> Is main: {qK.IsMain}");
                            Console.WriteLine($"-> Requirements: {qK.Requirements[0]}, {qK.Requirements[1]}");
                            Console.WriteLine($"-> Status: {qK.QuestStatus}");
                            Console.WriteLine($"-> Progress: {qK.Progress()}");
                            Console.WriteLine($"-> Is Completed: {qK.IsCompleted()}");
                            Console.WriteLine("");
                        }
                        
                        Console.WriteLine("");
                        Console.WriteLine("Press enter to return to Main Menu.");
                        break;
                    }

                    case '7':
                    {
                        int i = 0;
                        
                        foreach (var qE in questManager.ListQuestEscort())
                        {
                            Console.WriteLine($"({i++}) {qE.Name}");
                            Console.WriteLine($"-> Description: {qE.Description}");
                            Console.WriteLine($"-> Is main: {qE.IsMain}");
                            Console.WriteLine($"-> Requirements: {qE.Requirements[0]}, {qE.Requirements[1]}");
                            Console.WriteLine($"-> Status: {qE.QuestStatus}");
                            Console.WriteLine($"-> Progress: {qE.Progress()}");
                            Console.WriteLine($"-> Is Completed: {qE.IsCompleted()}");
                            Console.WriteLine("");
                        }
                        
                        Console.WriteLine("");
                        Console.WriteLine("Press enter to return to Main Menu.");
                        break;
                    }

                    case '8':
                    {
                        int i = 0;
                        
                        foreach (var qC in questManager.ListQuestCollect())
                        {
                            Console.WriteLine($"({i++}) {qC.Name}");
                            Console.WriteLine($"-> Description: {qC.Description}");
                            Console.WriteLine($"-> Is main: {qC.IsMain}");
                            Console.WriteLine($"-> Requirements: {qC.Requirements[0]}, {qC.Requirements[1]}");
                            Console.WriteLine($"-> Status: {qC.QuestStatus}");
                            Console.WriteLine($"-> Progress: {qC.Progress()}");
                            Console.WriteLine($"-> Is Completed: {qC.IsCompleted()}");
                            Console.WriteLine("");
                        }
                        
                        Console.WriteLine("");
                        Console.WriteLine("Press enter to return to Main Menu.");
                        break;
                    }

                    case '9':
                    {
                        Console.WriteLine($"{Math.Round(questManager.TotalProgress(), 2)} %");
                        break;
                    }

                    case '0':
                    {
                        end = true;
                        break;
                    }

                    default:
                    {
                        Console.WriteLine("Choose one of the numbers above.");
                        break;
                    }
                }
            }

            // Console.WriteLine("(1) Change Status");
            // Console.WriteLine("(2) Activate Timer");
            // Console.WriteLine("(3) Progress");
            // Console.WriteLine("(4) Check Completion");
            // Console.WriteLine("(0) Return to main menu");
            //
            // switch (info.KeyChar)
            // {
            //     case '1':
            //     {
            //         Console.WriteLine($"Current Status: {questManager.quest[i]}");
            //         break;
            //     }
            //
            //     case '2':
            //     {
            //         break;
            //     }
            //
            //     case '3':
            //     {
            //         break;
            //     }
            //
            //     case '4':
            //     {
            //         break;
            //     }
            //
            //     case '0':
            //     {
            //         break;
            //     }
            //
            //     default:
            //     {
            //         Console.WriteLine("Choose one of the numbers above.");
            //         break;
            //     }
            // }
            //
            // if (info.KeyChar == '0')
            // {
            //                 
            // }
            // break;
            // var questKill = (QuestKill) questManager.quest[0];
            // questKill.Entities[0].IsDead = true;
            // questKill.Entities[1].IsDead = true;
            // questKill.Entities[2].IsDead = true;
            // Console.WriteLine(questKill.Progress());
            // Console.WriteLine(questKill.IsCompleted());
            // Console.WriteLine(questManager.InactiveQuests().Count);
            // Console.WriteLine(questManager.CompletedQuests().Count);
        }
    }
}