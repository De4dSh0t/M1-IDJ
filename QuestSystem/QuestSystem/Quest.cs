using System;

namespace QuestSystem
{
    public class Quest
    {
        private string name;
        private string description;
        private TimeSpan duration;

        protected enum Status
        {
            WAITING,
            CURRENT,
            DONE,
            CANCELLED
        };

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Please, insert a name.");
                }

                name = value;
            }
        }

        public string Description
        {
            get => description;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Please, insert a description.");
                }

                description = value;
            }
        }

        public TimeSpan Duration
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
    }
}