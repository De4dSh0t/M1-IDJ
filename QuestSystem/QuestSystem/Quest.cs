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
        private List<string> requirements;
        private Status questStatus;

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

        public int Duration //Duração da Quest (em milisegundos)
        {
            get => duration;
            set
            {
                if (value <= 0)
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

        public List<string> Requirements //Requesitos da Quest (Item, Nivel, Classe ou outro necessário para realizar a quest)
        {
            get => requirements;
            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("Insert a requirement.");
                }
                
                requirements = value;
            }
        }

        public Status QuestStatus //Status da Quest (Se está "INACTIVE", "ACTIVE", "DONE" ou "CANCELLED")
        {
            get => questStatus;
            set
            {
                if (questStatus == Status.ACTIVE)
                {
                    QuestTimer();
                }

                questStatus = value;
            }
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

        private void QuestTimer()
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

        //O método "Event()" está associado ao método "QuestTimer()" e serve para que, quando o tempo da quest termine,
        //o "Event()" altere o estado da Quest para "CANCELLED"
        private void Event(object source, ElapsedEventArgs eventArgs)
        {
            questStatus = Status.CANCELLED;
        }

        public void CheckRequirements(List<string> features) //Verifica se as características da personagem cumpre os requesitos pre-definidos
        {
            //Se a lista "features" não tiver a mesma quantidade de variáveis que a lista "requirements", é imediatamente cancelada
            if (features.Count != requirements.Count)
            {
                throw new ArgumentException("The character doesn't have the features required!");
            }

            //Organiza a lista por ordem alfabetica/crescente
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