using System.Collections.Generic;
using VendaPS.Domain.Entities;
using VendaPS.Domain.ValueObjects;

namespace VendaPS.Domain.Validations
{
    public static class ClientValidation
    {
        public static bool IsValid(this Client client, out List<ValidationError> validationErrors)
        {
            validationErrors = new List<ValidationError>();

            if (string.IsNullOrWhiteSpace(client?.Cpf))
            {
                validationErrors.Add(new ValidationError("Cpf", "CPF is invalid"));
                return false;
            }

            if (string.IsNullOrWhiteSpace(client.Name))
            {
                validationErrors.Add(new ValidationError("Cpf", "Name is invalid"));
                return false;
            }

            return true;
        }
    }
}