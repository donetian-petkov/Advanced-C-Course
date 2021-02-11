namespace DefiningClasses
{
    public class Cargo
    {
        public Cargo(){}

        public Cargo(int weight, string type)
        {
            this.Weight = weight;
            this.Type = type;

        }

        private int weight;
        private string type;
        
        public int Weight
        {
            get => weight;
            set => weight = value;
        }

        public string Type
        {
            get => type;
            set => type = value;
        }
        
    }
}