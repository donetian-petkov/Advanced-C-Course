namespace DefiningClasses
{
    public class Tire
    {
        public Tire() {}

        public Tire(double pressure, int age)
        {
            this.Age = age;
            this.pressure = pressure;
        }
        
        private int age;
        private double pressure;
        
        public int Age
        {
            get => age;
            set => age = value;
        }

        public double Pressure
        {
            get => pressure;
            set => pressure = value;
        }
    }
}