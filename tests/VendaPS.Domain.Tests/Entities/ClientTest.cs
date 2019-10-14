using System.Linq;
using VendaPS.Domain.Entities;
using VendaPS.Domain.Validations;
using Xunit;

namespace VendaPS.Domain.Tests.Entities
{
    public class ClientTest
    {
        [Fact]
        public void Client_IsValidOk()
        {
            var client = new Client
            {
                Cpf = "123456",
                Name = "Fulano da Silva"
            };

            Assert.True(client.IsValid(out var validationErrors));
            Assert.NotNull(validationErrors);
            Assert.Empty(validationErrors);
        }

        [Fact]
        public void Client_IsValidFalse()
        {
            var client = new Client
            {
                Name = "Fulano da Silva"
            };

            Assert.False(client.IsValid(out var validationErrors));
            Assert.NotNull(validationErrors);
            Assert.True(validationErrors.Any());
            Assert.Single(validationErrors);
        }
    }
}