using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SpeedBids.Entities;
using SpeedBids.Entities.Enums;

namespace SpeedBids.Data
{
	public class SpeedBidsDbInitializer
	{
		public static void Seed(IApplicationBuilder applicationBuilder)
		{
			using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
			{
				var context = serviceScope.ServiceProvider.GetService<SpeedBidsDbContext>();

				if (!context.Products.Any())
				{
					context.Products.AddRange(new Product()
					{
						CarMake = ECarMake.Lexus,
						CarModel = "LX",
						CarType = ECarType.SUV,
						Color = EColor.Gray,
						YearModel = 2023,
						ProductDescription = "Lexus LX 2023",
						ProductPrice = 50000,
						ProductImage = "https://di-uploads-pod8.dealerinspire.com/dallasdodgechryslerjeepram/uploads/2020/09/2020-Dodge-Durango-EVice-White.png"
					},
					new Product()
					{
						CarMake = ECarMake.Ford,
						CarModel = "Mustang Mach-E",
						CarType = ECarType.SUV,
						Color = EColor.Red,
						YearModel = 2023,
						ProductDescription = "Ford Mustang Mach-E 2023 (Electric)",
						ProductPrice = 66778,
						ProductImage = "https://www.topgear.com/sites/default/files/2022/07/9_1.jpg"
					},
					new Product()
					{
						CarMake = ECarMake.Hyundai,
						CarModel = "Kona",
						CarType = ECarType.Crossover,
						Color = EColor.Yellow,
						YearModel = 2021,
						ProductDescription = "Hyundai Kona 201",
						ProductPrice = 55667,
						ProductImage = "https://images.hgmsites.net/hug/2021-hyundai-kona_100755129_h.jpg"
					},
					new Product()
					{
						CarMake = ECarMake.Chevrolet,
						CarModel = "Malibu",
						CarType = ECarType.Sedan,
						Color = EColor.Red,
						YearModel = 2023,
						ProductDescription = "Chevrolet Malibu 2023",
						ProductPrice = 45678,
						ProductImage = "https://www.chevrolet.ca/content/dam/chevrolet/global/us/english/index/cars/2023-malibu/01-images/mov/01-images/colorizer/2023-malibu-1sp-gnt-colorizer.jpg?imwidth=960"
					},
					new Product()
					{
						CarMake = ECarMake.Tesla,
						CarModel = "LX",
						CarType = ECarType.SUV,
						Color = EColor.Gray,
						YearModel = 2023,
						ProductDescription = "Tesla LX 2023",
						ProductPrice = 78901,
						ProductImage = "https://cars.usnews.com/static/images/Auto/izmo/i159615553/2023_tesla_model_x_angularfront.jpg"
					},
					new Product()
					{
						CarMake = ECarMake.Honda,
						CarModel = "HR-V",
						CarType = ECarType.Crossover,
						Color = EColor.Gray,
						YearModel = 2023,
						ProductDescription = "Honda HR-V 2023",
						ProductPrice = 56789,
						ProductImage = "https://www.motortrend.com/uploads/2022/07/2023-Honda-HR-V-front-three-quarter-2.jpg?fit=around%7C875:492.1875g"
					},
					new Product()
					{
						CarMake = ECarMake.Honda,
						CarModel = "Civic",
						CarType = ECarType.Hatchback,
						Color = EColor.Black,
						YearModel = 2023,
						ProductDescription = "Honda Civic 2023",
						ProductPrice = 34567,
						ProductImage = "https://s3.us-east-2.amazonaws.com/dealer-inspire-vps-vehicle-images/f319-11001847/19XFL2H50PE008839/331e3c8add0bfb19bc2525c6b7117b58.jpg"
					},
					new Product()
					{
						CarMake = ECarMake.Jeep,
						CarModel = "Rubicon",
						CarType = ECarType.SUV,
						Color = EColor.Black,
						YearModel = 2023,
						ProductDescription = "Jeep Rubicon",
						ProductPrice = 67890,
						ProductImage = "https://cars.usnews.com/static/images/Auto/izmo/i159614897/2022_jeep_wrangler_angularfront.jpg"
					},
					new Product()
					{
						CarMake = ECarMake.Ferrari,
						CarModel = "488 Pista",
						CarType = ECarType.SportsCar,
						Color = EColor.Red,
						YearModel = 2019,
						ProductDescription = "Ferrari 488 Pista 2019",
						ProductPrice = 123456,
						ProductImage = "https://di-uploads-pod15.dealerinspire.com/lakeforestsportscars/uploads/2018/06/488-Pista-2.jpeg"
					});

					context.SaveChanges();
				}
			}
		}
	}
}
