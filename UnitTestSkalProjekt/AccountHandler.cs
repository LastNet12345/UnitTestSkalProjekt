namespace UnitTestSkalProjekt
{
    public class AccountHandler
    {
        private const int discountBasic = 0;

        private readonly ILevelChecker levelChecker;

        public AccountHandler(ILevelChecker levelChecker)
        {
            this.levelChecker = levelChecker;
        }

        public int GiveDiscount(Account account)
        {
            if (levelChecker.CheckLevel(account) == CustomerLevels.Basic)
            {
                return discountBasic;
            }
            if (levelChecker.CheckLevel(account) == CustomerLevels.Gold)
            {
                return 30;
            }
            else
            {
                return 50;
            }

        }
    }
}
