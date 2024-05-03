using Microsoft.AspNetCore.Mvc;

namespace LabManual.Controllers
{
	[Controller]
	public class ProductInfo : Controller
	{
        public IActionResult Product(int id)
        {
            if (id >= 1 && id <= 100)
            {
                return Content($"Product information for ID: {id}");
            }
            else
            {
                return NotFound();
            }
        }
    }
}

