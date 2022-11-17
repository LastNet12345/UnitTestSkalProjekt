namespace UnitTestSkalProjekt
{
    public class AccountHandler
    {
        private const int discountBasic = 0;
        private const int discountGold = 30;
        private const int discountPlatinum = 50;

        private readonly ILevelChecker levelChecker;

        public AccountHandler(ILevelChecker levelChecker)
        {
            this.levelChecker = levelChecker;
        }

        public int GiveDiscount(Account account)
        {

            var customerLevel = levelChecker.CheckLevel(account);

            if (customerLevel == CustomerLevels.Basic)
            {
                return discountBasic;
            }
            if (customerLevel == CustomerLevels.Gold)
            {
                return discountGold;
            }
            else
            {
                return discountPlatinum;
            }

        }

        public int HowManyPointsToNextLevel(Account account)
        {
            var customerLevel = levelChecker.CheckLevel(account);

            if (customerLevel == CustomerLevels.Basic)
            {
                return levelChecker.Gold - account.PointBalance;
            }
            if (customerLevel == CustomerLevels.Gold)
            {
                return levelChecker.Platinum - account.PointBalance;
            }

            return 0;

        }
    }
}
