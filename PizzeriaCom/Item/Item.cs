namespace PizzeriaCom
{
    public class Item
    {
        private string type;
        private float prix;

        public string Type
        {
            get => type;
            set => type = value;
        }

        public float Prix
        {
            get => prix;
            set => prix = value;
        }
    }
}