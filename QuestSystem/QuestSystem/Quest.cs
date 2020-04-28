using System;

namespace QuestSystem
{
    public class Quest
    {
        private string name;
        private string description;
        private TimeSpan duration;
        private string type;
        private string requirements;

        public string Name //Nome da quest
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Insert a name.");
                }

                name = value;
            }
        }

        public string Description //Descrição da Quest
        {
            get => description;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Insert a description.");
                }

                description = value;
            }
        }

        public TimeSpan Duration //Duração da Quest
        {
            get => duration;
            set
            {
                if (value == TimeSpan.Zero)
                {
                    throw new ArgumentException("Seems like there is no duration for this quest...");
                }

                duration = value;
            }
        }

        public string Type //Tipo da Quest (Se é Main Quest, Side Quest ou outro)
        {
            get => type;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Insert a type.");
                }

                type = value;
            }
        }

        public string Requirements //Requesitos da Quest(Item, Nivel, Classe ou outro necessário para realizar a quest)
        {
            get => requirements;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Insert a requirement.");
                }
                
                requirements = value;
            }
        }

        public Quest(string name, string description, TimeSpan duration)
        {
            Name = name;
            Description = description;
            Duration = duration;
        }
    }
}