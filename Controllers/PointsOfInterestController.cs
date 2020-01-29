using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Controllers
{
	[ApiController]
	[Route("api/cities/{cityId}/pointsofinterest")]
	public class PointsOfInterestController : ControllerBase
	{
		[HttpGet]
		public IActionResult GetPointsOfInterest(int cityId)
		{
			var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

			if(city == null)
			{
				return NotFound();
			}

			return Ok(city.PointsOfInterest);
		}
	}
}
