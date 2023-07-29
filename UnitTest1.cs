using BankCharge.Services;
using NUnit.Framework;

namespace Lab1Test
{
    public class Tests
    {
        private static UserService userService;
        [SetUp]
        public void Setup()
        {
            userService = new UserService();
        }

        [Test]
        public void TestCheckFee()
        {
            double fee = userService.CheckFee(20);
            Assert.AreEqual(1.6,fee);
        }

        [Test]
        public void TestTotalFees()
        {
            double fee = userService.TotalFees(20, 300.0);
            Assert.AreEqual(26.6, fee);
        }

        [Test]
        public void TestFreightFee()
        {
            double fee = userService.FreightFee(20.0, 400);
            Assert.AreEqual(4.8, fee,0.1);
        }
        [Test]
        public void TestAfterDaysPopulation()
        {
            double people = UserService.AfterDaysPopulation(100, 0.03, 100);
            Assert.AreEqual(103, people);
        }

    }
}