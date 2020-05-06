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
        private int duration;
        private string type;
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
        public int Duration
        {
            get => duration;
            set
            {
                if (value > 0 && QuestStatus == Status.ACTIVE)
                {
                    QuestTimer();
                }

                duration = value;
            }
        }

        /// <summary>
        /// Quest Type Property (QuestKill/QuestCollect/QuestEscort)
        /// </summary>
        public virtual string Type
        {
            get => type;
            set => type = value;
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
            Type = type;
        }
        
        public Quest(string name, string description, int duration, string type, List<string> requirements, Status questStatus)
        {
            Name = name;
            Description = description;
            Duration = duration;
            Type = type;
            Requirements = requirements;
            QuestStatus = questStatus;
        }

        /// <summary>
        /// Method used to control the time of the quest
        /// </summary>
        public void QuestTimer()
        {
            Timer timer = new Timer();

            timer.Interval = duration; //Adiciona o tempo da quest ao intervalo do Timer
            timer.Elapsed += Event; //Quando esse intervalo terminar, ocorre um evento ("Event()")
            timer.Enabled = true;

            if (questStatus == Status.DONE || questStatus == Status.CANCELLED)
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
            //Se a lista "features" não tiver a mesma quantidade de variáveis que a lista "requirements", é imediatamente cancelada
            if (features.Count != requirements.Count)
            {
                throw new ArgumentException("The character doesn't have the features required!");
            }

            //Organiza as listas por ordem alfabetica/crescente
            requirements.Sort();
            features.Sort();

            //É verificado se a lista "features" não contém uma variável igual à da lista "requirements"
            if (features.SequenceEqual(requirements, StringComparer.OrdinalIgnoreCase) == false)
            {
                throw new ArgumentException("The character can't do this quest.");
            }
        }
    }
}