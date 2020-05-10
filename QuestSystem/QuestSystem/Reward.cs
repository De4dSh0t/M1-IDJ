using System;

namespace QuestSystem
{
    public class Reward
    {
        private object type;
        private float quantity; //Representa a quantidade da recompensa

        /// <summary>
        /// Reward Type (Money/Exp/Item)
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public object Type
        {
            get => type;
            set => type = value;
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

        public Reward(object type, float quantity)
        {
            Type = type;
            Quantity = quantity;
        }
    }
}