using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    [TestClass]

    public class StudentTests
    {
        [TestMethod]

        public void AdicionarAssinatura()
        {
            var subscription = new Subscription(null);
            var student = new Student("Vinicius", "Passos", "12345678974", "vinicius.pmp19@gmail.com");
            student.AddSubscription(subscription);
        }
    }
}