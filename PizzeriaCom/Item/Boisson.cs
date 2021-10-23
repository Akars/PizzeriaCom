namespace PizzeriaCom
{
    public class Boisson : Item
    {
        public Boisson(string type, float prix)
        {
            this.Type = type;
            this.Prix = prix;
        }
    }
}