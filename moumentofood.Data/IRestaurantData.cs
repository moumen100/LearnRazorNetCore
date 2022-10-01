
using MoumenToFood.Core;

namespace moumentofood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        IEnumerable<Restaurant> GetRestaurantByName(string? name);

    }
    public class InMemoryRestaurantData : IRestaurantData 
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData() {
                restaurants = new List<Restaurant>
                {
                new Restaurant { Id = 1, Name = "Scott's Pizza", Location="Maryland", Cuisine=CuisineTypes.Italian},
                new Restaurant { Id = 2, Name = "Cinnamon Club", Location="London", Cuisine=CuisineTypes.Italian},
                new Restaurant { Id = 3, Name = "La Costa", Location = "California", Cuisine=CuisineTypes.Mexican}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
                return from r in restaurants orderby r.Name select r;
        }
            public IEnumerable<Restaurant> GetRestaurantByName(string? name) {
                return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
            }


    }
}