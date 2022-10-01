
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using moumentofood.Data;
using MoumenToFood.Core;
namespace RazorTraining.Pages.Restaurants
{
    public class RestaurantsModel : PageModel
    {
            private readonly IConfiguration config;
            private readonly IRestaurantData restaurantData;
            public  IEnumerable<Restaurant>  RestaurantList {get;set;}
            [BindProperty(SupportsGet =true)]
            public  string  SearchTerm {get;set;}
        public RestaurantsModel(IConfiguration config, IRestaurantData restaurantData) {
            this.config = config;
            this.restaurantData = restaurantData;
        }
        public void OnGet()
        {
             this.RestaurantList = this.restaurantData.GetRestaurantByName(SearchTerm);
        }
    }
}
