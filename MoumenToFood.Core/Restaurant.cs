using System;


namespace MoumenToFood.Core
{
    
    public class Restaurant
    {
        public int Id {get;set;}
        public string? Name {get;set;}
        public string? Location {get;set;}
        public CuisineTypes Cuisine {get;set;}

    }
}