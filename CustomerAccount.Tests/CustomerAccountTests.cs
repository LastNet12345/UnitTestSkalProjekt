using System;
using Xunit;
using UnitTestSkalProjekt;

namespace UnitTestSkalProjekt.Tests
{
    public class CustomerAccountTests
    {
        //[Fact]
        //public void CreateNewAccount()
        //{
        //    throw new NotImplementedException();
        //}

        [Fact]
        public void SpendCustomerPoints_ReducePointBalance()
        {
            // Arrange
            var startingBalance = 10;
            var spendingAmount = 5;
            var expected = 5;
            var account = new CustomerAccount("Test Testsson", startingBalance);

            // Act
            account.SpendPoints(spendingAmount);

            // Assert
            var actual = account.PointBalance;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SpendCustomerPoints_AmountIsLessThanZero_ThrowsArgumentOutOfRange()
        {
            // Arrange
            var startingBalance = 10;
            var spendingAmount = -5;
            var account = new CustomerAccount("Test Testsson", startingBalance);

            // Act and assert
            Assert.Throws<ArgumentOutOfRangeException>(() => account.SpendMoney(spendingAmount));
        }

        [Fact]
        public void SpendCustomerPoints_AmountIsMoreThanBalance_ThrowsArgumentOutOfRange()
        {
            // Arrange
            var startingBalance = 5;
            var spendingAmount = 10;
            var account = new CustomerAccount("Test Testsson", startingBalance);
            var expected = "Account does not have that many points.";

            // Act and Assert
            var error = Assert.Throws<ArgumentOutOfRangeException>(() => account.SpendPoints(spendingAmount));
            Assert.Equal(expected, error.Message);


        }

        [Fact]
        public void SpendMoney_AmountIsLessThanZero_ThrowsArgumentOutOfRange()
        {
            // Arrange
            var startingBalance = 5;
            var spendingAmount = -100.0;
            var account = new CustomerAccount("Test Testsson", startingBalance);

            // Act and assert
            Assert.Throws<ArgumentOutOfRangeException>(() => account.SpendMoney(spendingAmount));
        }

        [Fact]
        public void SpendMoney_ShouldIncreasePointBalance()
        {
            // Arrange
            var startingBalance = 5;
            var spendingAmount = 500.0;
            var expected = 10;
            var account = new CustomerAccount("Test Testsson", startingBalance);

            // Act
            account.SpendMoney(spendingAmount);

            // Assert
            var actual = account.PointBalance;
            Assert.Equal(expected, actual);
            
        }

    }
}
