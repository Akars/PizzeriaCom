namespace PizzeriaCom
{
    public class Pizza : Item
    {
        private int taille;

        public int Taille
        {
            get => taille;
            set => taille = value;
        }
        
        public Pizza(string type, float prix)
        {
            this.Type = type;
            this.Prix = prix;
        }
    }
}