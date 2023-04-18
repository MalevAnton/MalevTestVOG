using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MalevTest;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetTicketForAge_ContributionTest1() // проверка взноса членского билета для тех, которому 18 лет
        {
            int rez = 150;

            Calculation calculation = new Calculation();

            int fak = calculation.GetTicketForAge(1, 1, 18);

            Assert.AreEqual(rez, fak);
        }

        [TestMethod]
        public void GetTicketForAge_ContributionTest2() // проверка взноса членского билета для тех, которому 30 лет
        {
            int rez = 100;

            Calculation calculation = new Calculation(); 

            int fak = calculation.GetTicketForAge(1, 2, 30);

            Assert.AreEqual(rez, fak);
        }

        [TestMethod]
        public void GetTicketForAge_ContributionTest3() // проверка взноса членского билета для тех, которому 50 лет
        {
            int rez = 50;

            Calculation calculation = new Calculation();

            int fak = calculation.GetTicketForAge(1, 3, 50);

            Assert.AreEqual(rez, fak);
        }

        [TestMethod]
        public void GetTicketForAge_AnnualFeeTest1() // проверка ежегодной платы членского билета для тех, которому 18 лет
        {
            int rez = 100;

            Calculation calculation = new Calculation();

            int fak = calculation.GetTicketForAge(2, 1, 18);

            Assert.AreEqual(rez, fak);
        }

        [TestMethod]
        public void GetTicketForAge_AnnualFeeTest2() // проверка ежегодной платы членского билета для тех, которому 30 лет
        {
            int rez = 75;

            Calculation calculation = new Calculation();

            int fak = calculation.GetTicketForAge(2, 2, 30);

            Assert.AreEqual(rez, fak);
        }

        [TestMethod]
        public void GetTicketForAge_AnnualFeeTest3() // проверка ежегодной платы членского билета для тех, которому 50 лет
        {
            int rez = 50;

            Calculation calculation = new Calculation();

            int fak = calculation.GetTicketForAge(2, 3, 50);

            Assert.AreEqual(rez, fak);
        }

        [TestMethod]
        public void GetTicketForAge_UpdateTest1() // проверка обновления членского билета для тех, которому исполнилось 30 лет
        {
            int rez = 100;

            Calculation calculation = new Calculation();

            int fak = calculation.GetTicketForAge(3, 1, 30);

            Assert.AreEqual(rez, fak);
        }

        [TestMethod]
        public void GetTicketForAge_UpdateTest2() // проверка обновления членского билета для тех, которому исполнилось 50 лет
        {
            int rez = 50;

            Calculation calculation = new Calculation();

            int fak = calculation.GetTicketForAge(3, 2, 50);

            Assert.AreEqual(rez, fak);
        }
    }
}
