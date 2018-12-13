using Moq;
using NUnit.Framework;
using TransBank.Domain.Entities;
using TransBank.Domain.Repositories;

namespace TransBank.Domain.Tests
{
    [TestFixture(Author = "Nelson Neto")]
    public class ContaTests
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void Depositar500NumaNovaConta()
        {
            var contaEncontrada = new Conta("A1234", 0.00M);

            Mock<ContaRepository> mock = new Mock<ContaRepository>();
            mock.Setup(m => m.BuscarPorId(It.IsAny<int>())).Returns(contaEncontrada);

            Conta contaBuscada = mock.Object.BuscarPorId(1);
            contaBuscada.Depositar(500.00M);

            Assert.AreEqual(contaBuscada.Numero, contaEncontrada.Numero);
            Assert.AreEqual(contaBuscada.Saldo, 500);
        }
    }
}
