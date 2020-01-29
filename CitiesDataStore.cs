using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
	public class CitiesDataStore
	{
		public static CitiesDataStore Current { get; } = new CitiesDataStore();

		public List<CityDto> Cities { get; set; }

		public CitiesDataStore()
		{
			// Initialise dummy data. Thsi will come from a DB in future.
			Cities = new List<CityDto>()
			{
				new CityDto()
				{
					Id = 1,
					Name = "New York City",
					Description = "The one with that big park.",
					PointsOfInterest = new List<PointOfInterestDto>()
					{
						new PointOfInterestDto()
						{
							Id = 1,
							Name = "Central Park",
							Description = "The most visited urban park in the United States."
						},
						new PointOfInterestDto()
						{
							Id = 2,
							Name = "Empire State Building",
							Description = "A 102-story skyscraper located in Midtown Manhatan."
						},
					}
				},
				new CityDto()
				{
					Id = 2,
					Name = "Antwerp",
					Description = "The one with the cathedral that was never really finished.",
					PointsOfInterest = new List<PointOfInterestDto>()
					{
						new PointOfInterestDto()
						{
							Id = 3,
							Name = "Cathedral of Our Lady",
							Description = "Gothic style cathedral."
						},
						new PointOfInterestDto()
						{
							Id = 4,
							Name = "Antwerp Central Station",
							Description = "Railway in Belgium"
						},
					}
				},
				new CityDto()
				{
					Id = 3,
					Name = "Paris",
					Description = "The one with the big tower.",
					PointsOfInterest = new List<PointOfInterestDto>()
					{
						new PointOfInterestDto()
						{
							Id = 5,
							Name = "Eiffel Tower",
							Description = "A wrought iron lattice tower on the Champ de Mars"
						},
						new PointOfInterestDto()
						{
							Id = 6,
							Name = "The Louvre",
							Description = "The worl's largest museum"
						},
					}
				},
			};
		}
	}
}
