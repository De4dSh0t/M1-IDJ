using System;

namespace QuestSystem
{
    public class Reward
    {
        private float quantity; //Representa a quantidade da recompensa

        public float Quantity
        {
            get => quantity;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Please, insert a quantity above 0");
                }

                quantity = value;
            }
        }
    }
}