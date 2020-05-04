using System;

namespace QuestSystem
{
    public class Reward
    {
        private string type;
        private float quantity; //Representa a quantidade da recompensa

        /// <summary>
        /// Reward Type (Money/Exp/Item)
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public string Type
        {
            get => type;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Insert a type name.");
                }

                type = value;
            }
        }
        
        /// <summary>
        /// Reward Quantity
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public float Quantity
        {
            get => quantity;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Please, insert a quantity above 0.");
                }

                quantity = value;
            }
        }

        public Reward(string type, float quantity)
        {
            Type = type;
            Quantity = quantity;
        }
    }
}