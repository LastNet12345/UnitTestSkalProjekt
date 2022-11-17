using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestSkalProjekt;
using Xunit;
using Moq;

namespace UnitTestSkalProjekt.Tests
{
    public class CustomerAccountHandlerTests
    {

        [Fact]
        public void GiveDiscount_BasicCustomer()
        {
            // Arrange
            var account = new CustomerAccount("Test Testsson", 0);
            Mock<ICustomerLevelChecker> mockLevelChecker = new Mock<ICustomerLevelChecker>();
            mockLevelChecker.Setup(x => x.CheckLevel(account)).Returns(CustomerLevels.Basic);
            var handler = new CustomerAccountHandler(mockLevelChecker.Object);

            // Act
            var expected = 0;
            var actual = handler.GiveDiscount(account);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GiveDiscount_GoldCustomer()
        {
            // Arrange
            var account = new CustomerAccount("Test Testsson", 50);
            Mock<ICustomerLevelChecker> mockLevelChecker = new Mock<ICustomerLevelChecker>();
            mockLevelChecker.Setup(x => x.CheckLevel(account)).Returns(CustomerLevels.Gold);
            var handler = new CustomerAccountHandler(mockLevelChecker.Object);

            // Act
            var expected = 30;
            var actual = handler.GiveDiscount(account);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GiveDiscounts_PlatinumCustomer()
        {
            // Arrange
            var account = new CustomerAccount("Test Testsson", 200);
            Mock<ICustomerLevelChecker> mockLevelChecker = new Mock<ICustomerLevelChecker>();
            mockLevelChecker.Setup(x => x.CheckLevel(account)).Returns(CustomerLevels.Platinum);
            var handler = new CustomerAccountHandler(mockLevelChecker.Object);

            // Act
            var expected = 50;
            var actual = handler.GiveDiscount(account);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void HowManyPointsToNextLevel_BasicCustomer()
        {
            // Arrange
            var account = new CustomerAccount("Test Testsson", 0);
            Mock<ICustomerLevelChecker> mockLevelChecker = new Mock<ICustomerLevelChecker>();
            mockLevelChecker.Setup(x => x.Gold).Returns(50);
            var handler = new CustomerAccountHandler(mockLevelChecker.Object);

            // Act
            var expected = 50;
            var actual = handler.HowManyPointsToNextLevel(account);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void VerifyThatLevelCheckerWasCalled()
        {

        }


    }
}
