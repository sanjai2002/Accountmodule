using AccountModule.Controllers;
using AccountModule.Model;
using Microsoft.AspNetCore.Http.HttpResults;

namespace AccountTest
{
    public class Tests
    {
        private AccountController accountController;

        [SetUp]
        public void Setup()
        {
            accountController = new AccountController();
        }

        [Test]
        public void TestMethodForGetAccountdetails()
        {
            IEnumerable<Account> Expectoutput = accountController.GetAccountdetails();
            Assert.That(Expectoutput, Is.Not.Null);
            Assert.That(Expectoutput.Count(), Is.EqualTo(0));
        }

        [Test]
        public void TestMethodForPostAccountdtails()
        {
            var AccountTest1 = new Account 
            {
                Account_number=140001000024830,
                Account_holdername="Sanjai",
                Account_type="Current Account",
                Balance_amount=12000,
                Mobile_no=8531086669
            };
            var actionResult = accountController.PostAccount(AccountTest1);
            Assert.That(actionResult, Is.Not.Null);
        }

        [Test]
        public void TestMethodForPostEmployeeNull()
        {
            var AccountTest2 = new Account 
            {
                Account_number = 0,
                Account_holdername = null,
                Account_type = null,
                Balance_amount = 0,
                Mobile_no = 0

            };
            var actionResult = accountController.PostAccount(AccountTest2);
            Assert.IsNotInstanceOf<BadRequest>(actionResult);
        }
    }
}