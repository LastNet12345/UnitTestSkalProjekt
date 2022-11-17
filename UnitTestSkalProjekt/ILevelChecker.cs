namespace UnitTestSkalProjekt
{
    public interface ILevelChecker
    {
        CustomerLevels CheckLevel(Account account);
        public int Gold { get; }
        public int Platinum { get; }
    }
}
