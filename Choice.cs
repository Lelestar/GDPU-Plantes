namespace ClassCartes
{
    class Choice
    {
        protected string _name = "defaultchoice";
        public string _description = "defaultchoicedescription";
        protected int _id = -1;
        protected int _modLove = 0;
        protected int _modHum = 0;
        protected int _modAir = 0;
        protected int _modSoil = 0;
        protected bool _deleteOnPick = false;
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
            _description = "Error! Choice not found: " + s;
        }

        public override bool choose(int plant)
        {
            // Opérations spéciales sur la plante

            // A la fin on appelle la version de choose appartenant à la classe héritée
            return base.choose(plant);
        }
    }
}