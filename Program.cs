namespace CarModelNunit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class Car(int carId, string model, int year, string maufacturer)
    {
        public int CarId => carId;
        public string Model => model;
        public int Year => year;
        public string Manufacturer => maufacturer;

        // 1. Metódus: Visszaadja a gépjármű teljes adatát formázott stringben
        public string GetCarInfo()
        {
            return $"Model: {Model}, Manufacturer: {Manufacturer}, Year: {Year}, CarId: {CarId}";
        }

        // 2. Metódus: Ellenőrzi, hogy a gépjármű gyártási éve a jelenlegi évnél újabb-e
        public bool IsNewCar()
        {
            var currentYear = DateTime.Now.Year;
            return Year >= currentYear;
        }

        // 3. Metódus: Visszaadja a gépjármű életkorát (aktuális év - gyártási év)
        public int GetCarAge()
        {
            var currentYear = DateTime.Now.Year;
            return currentYear - Year;
        }
    }
}
