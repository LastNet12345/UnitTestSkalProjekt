namespace UnitTestSkalProjekt
{
    public class Account
    {
        public string Name { get; init; }
        public int PointBalance { get; private set; }

        public Account(string name, int startingPoints)
        {
            Name = name;

            if (startingPoints < 0)
            {
                PointBalance = 0;
            }
            else
            {
                PointBalance = startingPoints;
            }
        }



        public void SpendPoints(int nrOfPoints)
        {
            if (nrOfPoints > PointBalance)
            {
                throw new ArgumentOutOfRangeException(nameof(nrOfPoints), "Account does not have that many points.");
            }
            if (nrOfPoints < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(nrOfPoints));
            }

            PointBalance -= nrOfPoints;
        }

        public void SpendMoney(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            PointBalance += Convert.ToInt32(Math.Floor(amount / 10));
        }
    }
}
