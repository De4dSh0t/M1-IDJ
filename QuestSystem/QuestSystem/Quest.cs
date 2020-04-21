using System;

namespace QuestSystem
{
    public class Quest
    {
        private string name;
        private string description;

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
    }
}