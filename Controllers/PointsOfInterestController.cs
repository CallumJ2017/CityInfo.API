﻿using Microsoft.AspNetCore.Mvc;
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

		[HttpGet("{id}")]
		public IActionResult GetPointOfInterest(int cityId, int id)
		{
			var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

			// First check to see if we have a city.
			if (city == null)
			{
				return NotFound();
			}

			// Get the point of interest from the selected City.
			var pointOfInterest = city.PointsOfInterest.FirstOrDefault(c => c.Id == id);

			if(pointOfInterest == null)
			{
				return NotFound();
			}

			return Ok(pointOfInterest);
		}
	}
}
