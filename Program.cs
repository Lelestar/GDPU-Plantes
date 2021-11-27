using System;

namespace ClassCartes
{
    class Program
    {
        static void Main(string[] args)
        {

            Choice myChoice = new DefaultChoice("Testing testing");
            Console.WriteLine("Hello World! " + myChoice.description);
        }
    }
    class Carte
    {
        string name = "defaultcard";
        public string description = "defaultcarddescription";
        int id = -1;
        string family;      // Utiliser un ID avec des define pour améliorer les performances ?
                            // familles de cartes débloquées
        Choice[] choices;

        public Carte(int id)
        {
            this.id = id;
        }
    }

    class DefaultCard : Carte
    {
        public DefaultCard()
        {
            base.Carte(0);
        }
    }

    class Choice
    {
        protected string name = "defaultchoice";
        public string description = "defaultchoicedescription";
        protected int id = -1;
        protected int modLove = 0;
        protected int modHum = 0;
        protected int modAir = 0;
        protected int modSoil = 0;
        protected bool deleteOnPick = false;
        // Peut verouiller des cartes
        // Peut ajouter des cartes

        public virtual bool choose(int plant)
        {

            // Opérations standard sur la plante
            // Ajouter amour, modificateur d'air, d'humidité et de sol

            // Retourner deleteOnPick pour dire à l'appelant si la carte doit être supprimée du deck
            return deleteOnPick;
        }

        

    }

    class DefaultChoice : Choice
    {
        public DefaultChoice(string s)
        {
            description = "Error! Choice not found: " + s;
        }

        public override bool choose(int plant)
        {
            // Opérations spéciales sur la plante

            // A la fin on appelle la version de choose appartenant à la classe héritée
            return base.choose(plant);
        }
    }
}
