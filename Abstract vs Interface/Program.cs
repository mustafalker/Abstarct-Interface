namespace Abstract_vs_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sqlDb = new SqlServerDb();

            sqlDb.ExecuteSql("");

            var PgDb = new PgDb();
            PgDb.ExecuteSql("");

            var car = new Car();     
            car.Go();
            car.Stop();

            var bike = new Bike();  
            bike.Go();  
            bike.Stop();
            bike.Ride();
        }
    }
}