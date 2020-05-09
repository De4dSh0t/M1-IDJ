using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace QuestSystem
{
    public class Quest
    {
        private string name;
        private string description;
        private int time;
        private bool isMain;
        private List<string> requirements;
        private Status questStatus;
        private Reward reward;

        /// <summary>
        /// Quest Name/Title Property
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public string Name
        {
            get => name;
            set => name = value;
        }

        /// <summary>
        /// Quest Description Property
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public string Description
        {
            get => description;
            set => description = value;
        }

        /// <summary>
        /// Quest Duration/Timer Property
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public int Time
        {
            get => time;
            set
            {
                if (value > 0 && QuestStatus == Status.ACTIVE)
                {
                    QuestTimer();
                }

                time = value;
            }
        }

        /// <summary>
        /// Property that defines if the quest is either a Main Quest or a Side Quest
        /// </summary>
        public bool IsMain
        {
            get => isMain;
            set => isMain = value;
        }
        
        /// <summary>
        /// Quest Requirements Property (Class/Item/Level)
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public List<string> Requirements
        {
            get => requirements;
            set => requirements = value;
        }

        /// <summary>
        /// Quest Status Property (If it is "INACTIVE", "ACTIVE", "DONE" or "CANCELLED")
        /// </summary>
        public Status QuestStatus
        {
            get => questStatus;
            set => questStatus = value;
        }

        /// <summary>
        /// Quest Reward Property
        /// </summary>
        public Reward Reward
        {
            get => reward;
            set => reward = value;
        }


        public Quest()
        {
            Name = "";
            Description = "";
        }
        
        public Quest(string name, string description)
        {
            Name = name;
            Description = description;
        }
        
        public Quest(string name, string description, int time, List<string> requirements, Status questStatus)
        {
            Name = name;
            Description = description;
            Time = time;
            Requirements = requirements;
            QuestStatus = questStatus;
        }

        /// <summary>
        /// Method used to control the time of the quest
        /// </summary>
        public void QuestTimer()
        {
            Timer timer = new Timer();

            timer.Interval = time; //Adds quest time to the Timer interval
            timer.Elapsed += Event; //When that interval ends, the "Event()" occurs
            timer.Enabled = true;

            if (questStatus == Status.COMPLETED || questStatus == Status.CANCELLED)
            {
                timer.Stop();
            }
        }
        
        /// <summary>
        /// Event called when the timer ends, changing the quest status to "CANCELLED"
        /// </summary>
        /// <param name="source"></param>
        /// <param name="eventArgs"></param>
        private void Event(object source, ElapsedEventArgs eventArgs)
        {
            questStatus = Status.CANCELLED;
        }

        /// <summary>
        /// Check if certain character features match the pre-defined requirements
        /// </summary>
        /// <param name="features"></param>
        /// <exception cref="ArgumentException"></exception>
        public void CheckRequirements(List<string> features)
        {
            //If the "features" list is shorter than the "requirements" list, than it's immediately canceled
            if (features.Count < requirements.Count)
            {
                throw new ArgumentException("The player doesn't have the features required!");
            }

            //Organizes lists in alphabetical/ascending order
            requirements.Sort();
            features.Sort();

            //Verifies if the "features" list doesn't contain a variable equal to the "requirements" list
            if (features.SequenceEqual(requirements, StringComparer.OrdinalIgnoreCase) == false)
            {
                throw new ArgumentException("The player can't do this quest.");
            }
        }
    }
}