namespace UnitTestSkalProjekt
{
    public class Program
    {
        static void Main(string[] args)
        {
            var levelChecker = new LevelChecker();
            var customer1 = new Account("Nalle Puh", 0);
            var customer2 = new Account("Pippi Långstrump", 30);
            var customer3 = new Account("Evert Taube", 40);

            customer1.SpendMoney(100);
            Console.WriteLine(customer1.PointBalance);
            Console.WriteLine(levelChecker.CheckLevel(customer1));


            customer1.SpendMoney(1000);
            Console.WriteLine(customer1.PointBalance);
            Console.WriteLine(levelChecker.CheckLevel(customer1));


        }
    }

}
