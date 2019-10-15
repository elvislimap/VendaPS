using System.Collections.Generic;

namespace VendaPS.Domain.ValueObjects
{
    public class Result
    {
        public Result(object returnn = null, List<ValidationError> validationErrors = null)
        {
            Return = returnn;
            ValidationErrors = validationErrors;
        }

        public object Return { get; set; }
        public List<ValidationError> ValidationErrors { get; set; }
    }
}