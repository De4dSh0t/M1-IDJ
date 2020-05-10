using System;

namespace QuestSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Makes the json file and reads it
            JsonWriter jsonWriter = new JsonWriter();
            jsonWriter.Write();
            QuestManager questManager = new QuestManager();
            questManager.ReadJson("quests.json");
            
            //Basic program to test the QuestManager
            //WARNING: Don't change any code. If you change something in "JsonWriter.cs", this "Program.cs" won't work as expected.
            bool end = false;
            while (!end)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                
                Console.WriteLine("-------- QuestSystem --------");
                Console.WriteLine("(1) Quest List");
                Console.WriteLine("(2) Progress");
                Console.WriteLine("(3) Interaction");
                Console.WriteLine("(0) Quit");
                Console.WriteLine("-----------------------------");

                switch (info.KeyChar)
                {
                    case '1':
                    {
                        Console.WriteLine("-------- Quest List --------");
                        Console.WriteLine("(1) List All Quests");
                        Console.WriteLine("(2) List Active Quests");
                        Console.WriteLine("(3) List Inactive Quests");
                        Console.WriteLine("(4) List Completed Quests");
                        Console.WriteLine("(5) List Cancelled Quests");
                        Console.WriteLine("(6) List QuestKill");
                        Console.WriteLine("(7) List QuestEscort");
                        Console.WriteLine("(8) List QuestCollect");
                        Console.WriteLine("(9) List QuestDefend");
                        Console.WriteLine("----------------------------");
                        
                        info = Console.ReadKey();
                        Console.WriteLine("");
                        Console.WriteLine("");

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
                                    Console.WriteLine($"-> Reward: {q.Reward.Type}, {q.Reward.Quantity}");
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
                                    Console.WriteLine($"-> Reward: {q.Reward.Type}, {q.Reward.Quantity}");
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
                                    Console.WriteLine($"-> Reward: {q.Reward.Type}, {q.Reward.Quantity}");
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
                                    Console.WriteLine($"-> Reward: {q.Reward.Type}, {q.Reward.Quantity}");
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
                                    Console.WriteLine($"-> Reward: {q.Reward.Type}, {q.Reward.Quantity}");
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
                                    Console.WriteLine($"-> Reward: {qK.Reward.Type}, {qK.Reward.Quantity}");
                                    Console.WriteLine($"-> Progress: {qK.Progress()} %");
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
                                    Console.WriteLine($"-> Reward: {qE.Reward.Type}, {qE.Reward.Quantity}");
                                    Console.WriteLine($"-> Progress: {qE.Progress()} %");
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
                                    Console.WriteLine($"-> Reward: {qC.Reward.Type}, {qC.Reward.Quantity}");
                                    Console.WriteLine($"-> Progress: {qC.Progress()} %");
                                    Console.WriteLine($"-> Is Completed: {qC.IsCompleted()}");
                                    Console.WriteLine("");
                                }
                        
                                Console.WriteLine("");
                                Console.WriteLine("Press enter to return to Main Menu.");
                                break;
                            }
                            
                            case '9':
                            {
                                int i = 0;
                        
                                foreach (var qD in questManager.ListQuestDefend())
                                {
                                    Console.WriteLine($"({i++}) {qD.Name}");
                                    Console.WriteLine($"-> Description: {qD.Description}");
                                    Console.WriteLine($"-> Is main: {qD.IsMain}");
                                    Console.WriteLine($"-> Requirements: {qD.Requirements[0]}, {qD.Requirements[1]}");
                                    Console.WriteLine($"-> Status: {qD.QuestStatus}");
                                    Console.WriteLine($"-> Reward: {qD.Reward.Type}, {qD.Reward.Quantity}");
                                    Console.WriteLine($"-> Progress: {qD.Progress()} %");
                                    Console.WriteLine($"-> Is Completed: {qD.IsCompleted()}");
                                    Console.WriteLine("");
                                }
                        
                                Console.WriteLine("");
                                Console.WriteLine("Press enter to return to Main Menu.");
                                break;
                            }

                            default:
                            {
                                Console.WriteLine("Error: Wrong input...");
                                break;
                            }
                        }
                        
                        break;
                    }

                    case '2':
                    {
                        Console.WriteLine("-------- Progress --------");
                        Console.WriteLine("(1) Total Progress");
                        Console.WriteLine("(2) Main Quest Progress");
                        Console.WriteLine("(3) Side Quest Progress");
                        Console.WriteLine("--------------------------");
                        
                        info = Console.ReadKey();
                        Console.WriteLine("");
                        Console.WriteLine("");

                        switch (info.KeyChar)
                        {
                            case '1':
                            {
                                Console.WriteLine($"Total Progress: {Math.Round(questManager.TotalProgress(), 2)} %");
                                break;
                            }

                            case '2':
                            {
                                Console.WriteLine($"Main Quest Progress: {Math.Round(questManager.MainProgress(), 2)} %");
                                break;
                            }

                            case '3':
                            {
                                Console.WriteLine($"Side Quest Progress: {Math.Round(questManager.SideProgress(), 2)} %");
                                break;
                            }

                            default:
                            {
                                Console.WriteLine("Error: Wrong input...");
                                break;
                            }
                        }

                        break;
                    }

                    case '3':
                    {
                        int i = 0;
                        
                        foreach (var q in questManager.quest)
                        {
                            Console.WriteLine($"({i++}) {q.Name}");
                            Console.WriteLine($"-> Status: {q.QuestStatus}");
                            Console.WriteLine("");
                        }

                        Console.WriteLine("");
                        Console.WriteLine("Choose one of the above.");

                        info = Console.ReadKey();
                        Console.WriteLine("");
                        Console.WriteLine("");

                        switch (info.KeyChar)
                        {
                            case '0':
                            {
                                Console.WriteLine("-------- Interaction --------");
                                Console.WriteLine("(1) Activate Timer");
                                Console.WriteLine("(2) Check Progress");
                                Console.WriteLine("-----------------------------");
                                
                                info = Console.ReadKey();
                                Console.WriteLine("");
                                Console.WriteLine("");

                                switch (info.KeyChar)
                                {
                                    case '1':
                                    {
                                        if (questManager.ListQuestKill()[0].Time == 0)
                                        {
                                            Console.WriteLine("This quest hasn't a predefined time.");
                                            Console.WriteLine("Please, insert a time in milliseconds:");
                                            int time = Int32.Parse(Console.ReadLine());
                                            questManager.ListQuestKill()[0].Time = time;

                                            Console.WriteLine("Do you want to activate the timer? (y/n)");
                                            string input = Console.ReadLine();
                                            
                                            if (input == "y")
                                            {
                                                questManager.ListQuestKill()[0].QuestStatus = Status.ACTIVE;
                                                questManager.ListQuestKill()[0].QuestTimer();
                                                Console.WriteLine("Activating timer...");
                                                Console.WriteLine("Done!");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Cancelling...");
                                            }
                                            
                                            break;
                                        }
                                        
                                        questManager.ListQuestKill()[0].QuestStatus = Status.ACTIVE;
                                        questManager.ListQuestKill()[0].QuestTimer();
                                        
                                        break;
                                    }

                                    case '2':
                                    {
                                        Console.WriteLine($"{questManager.ListQuestKill()[0].Progress()} %");
                                        break;
                                    }

                                    default:
                                    {
                                        Console.WriteLine("Error: Wrong input...");
                                        break;
                                    }
                                }
                                
                                break;
                            }

                            case '1':
                            {
                                Console.WriteLine("-------- Interaction --------");
                                Console.WriteLine("(1) Activate Timer");
                                Console.WriteLine("(2) Check Progress");
                                Console.WriteLine("-----------------------------");
                                
                                info = Console.ReadKey();
                                Console.WriteLine("");
                                Console.WriteLine("");

                                switch (info.KeyChar)
                                {
                                    case '1':
                                    {
                                        if (questManager.ListQuestCollect()[0].Time == 0)
                                        {
                                            Console.WriteLine("This quest hasn't a predefined time.");
                                            Console.WriteLine("Please, insert a time in milliseconds:");
                                            int time = Int32.Parse(Console.ReadLine());
                                            questManager.ListQuestCollect()[0].Time = time;

                                            Console.WriteLine("Do you want to activate the timer? (y/n)");
                                            string input = Console.ReadLine();
                                            
                                            if (input == "y")
                                            {
                                                questManager.ListQuestCollect()[0].QuestStatus = Status.ACTIVE;
                                                questManager.ListQuestCollect()[0].QuestTimer();
                                                Console.WriteLine("Activating timer...");
                                                Console.WriteLine("Done!");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Cancelling...");
                                            }
                                            
                                            break;
                                        }
                                        
                                        questManager.ListQuestCollect()[0].QuestStatus = Status.ACTIVE;
                                        questManager.ListQuestCollect()[0].QuestTimer();
                                        
                                        break;
                                    }

                                    case '2':
                                    {
                                        Console.WriteLine($"{questManager.ListQuestCollect()[0].Progress()} %");
                                        break;
                                    }

                                    default:
                                    {
                                        Console.WriteLine("Error: Wrong input...");
                                        break;
                                    }
                                }
                                
                                break;
                            }

                            case '2':
                            {
                                Console.WriteLine("-------- Interaction --------");
                                Console.WriteLine("(1) Activate Timer");
                                Console.WriteLine("(2) Check Progress");
                                Console.WriteLine("-----------------------------");
                                
                                info = Console.ReadKey();
                                Console.WriteLine("");
                                Console.WriteLine("");

                                switch (info.KeyChar)
                                {
                                    case '1':
                                    {
                                        if (questManager.ListQuestEscort()[0].Time == 0)
                                        {
                                            Console.WriteLine("This quest hasn't a predefined time.");
                                            Console.WriteLine("Please, insert a time in milliseconds:");
                                            int time = Int32.Parse(Console.ReadLine());
                                            questManager.ListQuestEscort()[0].Time = time;

                                            Console.WriteLine("Do you want to activate the timer? (y/n)");
                                            string input = Console.ReadLine();
                                            
                                            if (input == "y")
                                            {
                                                questManager.ListQuestEscort()[0].QuestStatus = Status.ACTIVE;
                                                questManager.ListQuestEscort()[0].QuestTimer();
                                                Console.WriteLine("Activating timer...");
                                                Console.WriteLine("Done!");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Cancelling...");
                                            }
                                            
                                            break;
                                        }
                                        
                                        questManager.ListQuestEscort()[0].QuestStatus = Status.ACTIVE;
                                        questManager.ListQuestEscort()[0].QuestTimer();
                                        
                                        break;
                                    }

                                    case '2':
                                    {
                                        Console.WriteLine($"{questManager.ListQuestEscort()[0].Progress()} %");
                                        break;
                                    }

                                    default:
                                    {
                                        Console.WriteLine("Error: Wrong input...");
                                        break;
                                    }
                                }
                                
                                break;
                            }

                            case '3':
                            {
                                Console.WriteLine("-------- Interaction --------");
                                Console.WriteLine("(1) Activate Timer");
                                Console.WriteLine("(2) Check Progress");
                                Console.WriteLine("-----------------------------");
                                
                                info = Console.ReadKey();
                                Console.WriteLine("");
                                Console.WriteLine("");

                                switch (info.KeyChar)
                                {
                                    case '1':
                                    {
                                        if (questManager.ListQuestDefend()[0].Time == 0)
                                        {
                                            Console.WriteLine("This quest hasn't a predefined time.");
                                            Console.WriteLine("Please, insert a time in milliseconds:");
                                            int time = Int32.Parse(Console.ReadLine());
                                            questManager.ListQuestDefend()[0].Time = time;

                                            Console.WriteLine("Do you want to activate the timer? (y/n)");
                                            string input = Console.ReadLine();
                                            
                                            if (input == "y")
                                            {
                                                questManager.ListQuestDefend()[0].QuestStatus = Status.ACTIVE;
                                                questManager.ListQuestDefend()[0].QuestTimer();
                                                Console.WriteLine("Activating timer...");
                                                Console.WriteLine("Done!");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Cancelling...");
                                            }
                                            
                                            break;
                                        }
                                        
                                        questManager.ListQuestDefend()[0].QuestStatus = Status.ACTIVE;
                                        questManager.ListQuestDefend()[0].QuestTimer();
                                        
                                        break;
                                    }

                                    case '2':
                                    {
                                        Console.WriteLine($"{questManager.ListQuestDefend()[0].Progress()} %");
                                        break;
                                    }

                                    default:
                                    {
                                        Console.WriteLine("Error: Wrong input...");
                                        break;
                                    }
                                }
                                
                                break;
                            }

                            default:
                            {
                                Console.WriteLine("Error: Wrong input...");
                                break;
                            }
                        }
                        
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
        }
    }
}