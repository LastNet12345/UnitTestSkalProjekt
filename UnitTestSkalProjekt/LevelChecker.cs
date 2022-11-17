namespace UnitTestSkalProjekt
{

    public class LevelChecker : ILevelChecker
    {
        private const int gold = 50;
        private const int platinum = 200;

        public int Gold { get { return gold; } }
        public int Platinum { get { return platinum; } }

        public CustomerLevels CheckLevel(Account account)
        {
            if (account.PointBalance < gold)
            {
                return CustomerLevels.Basic;
            }
            if (account.PointBalance < platinum)
            {
                return CustomerLevels.Gold;
            }
            else
            {
                return CustomerLevels.Platinum;
            }
        }

    }
}