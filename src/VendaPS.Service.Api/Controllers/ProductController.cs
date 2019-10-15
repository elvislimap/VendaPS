using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using VendaPS.Application.Interfaces;
using VendaPS.Domain.Entities;

namespace VendaPS.Service.Api.Controllers
{
    [Route("api/product/v1")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductAppService _productAppService;

        public ProductController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }


        [HttpPost("Add")]
        public StatusCodeResult Add(Product product)
        {
            // TODO: REVISAR...
            var result = _productAppService.Add(product);

            if (result.ValidationErrors.Any())
                return BadRequest();

            return Ok();
        }
    }
}