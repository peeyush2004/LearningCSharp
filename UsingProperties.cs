namespace Class1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car("A3", "Audi", false);
            Car bmw = new Car("M5", "BMW", true);

            Console.WriteLine("Enter a brand:");
            //setting


            //getting
            Console.WriteLine($"The brand of the car is: {audi.Brand}");
            Console.WriteLine($"The brand of the car is: {bmw.Brand}");
            Console.ReadKey();
        }
    }

    internal class Car
    {
        //private string _model = "";
        private string _brand = "";

        // private bool _isLuxury;
        public Car(string model, string brand, bool isLuxury)
        {
            Model = model;
            Brand = brand;
            Console.WriteLine($"A {brand} of the model " + model + " has been created");
            IsLuxury = isLuxury;
        }

        // public string Model { get => _model; set => _model = value; }
        public string Model { get; set; }
        public string Brand
        {
            get
            {
                if (IsLuxury)
                {
                    return _brand + " - Luxury Edition";
                }
                else
                {
                    return _brand;


                }
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered nothing");
                    _brand = "DefaultValue";
                }
                else
                {

                    _brand = value;
                }
            }
        }

        public bool IsLuxury { get; set; }
        // public bool IsLuxury { get => _isLuxury; 
        //set => _isLuxury = value; }
    }
}