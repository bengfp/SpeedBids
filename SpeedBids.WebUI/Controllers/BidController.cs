using Microsoft.AspNetCore.Mvc;
using SpeedBids.Data;
using SpeedBids.WebUI.Models;

namespace SpeedBids.WebUI.Controllers
{
    public class BidController : Controller
    {
        private readonly SpeedBidsDbContext _dbContext;

        public BidController(SpeedBidsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index(int productId)
        {
            var product = _dbContext.Products.FirstOrDefault(p => p.ProductId == productId);

            var bidViewModel = new BidViewModel
            {
                ProductId = productId,
                CarMake = product.CarMake,
                CarModel = product.CarModel,
                CarType = product.CarType,
                Color = product.Color,
                YearModel = product.YearModel,
                ProductPrice = product.ProductPrice,
                ProductImage = product.ProductImage

            };

            return View(bidViewModel);
        }

    }
}
