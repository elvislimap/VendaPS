using System.Collections.Generic;
using VendaPS.Domain.Entities;
using VendaPS.Domain.ValueObjects;

namespace VendaPS.Domain.Validations
{
    public static class ProductValidation
    {
        public static bool IsValid(this Product product, out List<ValidationError> validationErrors)
        {
            validationErrors = new List<ValidationError>();

            if (string.IsNullOrWhiteSpace(product?.Ean))
            {
                validationErrors.Add(new ValidationError("Ean", "Ean is invalid"));
                return false;
            }

            if (string.IsNullOrWhiteSpace(product.Description))
            {
                validationErrors.Add(new ValidationError("Description", "Description is invalid"));
                return false;
            }

            return true;
        }
    }
}