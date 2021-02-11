namespace DefiningClasses
{
    public class Engine
    {
        public Engine() {}

        public Engine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;

        }
        private int speed;
        private int power;
        
        public int Speed
        {
            get => speed;
            set => speed = value;
        }

        public int Power
        {
            get => power;
            set => power = value;
        }
    }
}