using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodieSite.Models
{
    public class Restaurant
    {
        //read only
        public int Rank { get; private set; }
        public string rName { get; set; }
        //optional -- default value "It's all tasty!"
        public string rFavDish { get; set; } = "It's all tasty!";
        public string rAddress { get; set; }
        //optional
        public string? rPhone { get; set; }
        //optional -- default value "Website coming soon"
        public string rLink { get; set; } = "Coming Soon";

        public static Restaurant[] GetRestaurants()
        {
            //create Restaurant objects of top 5 restaurants, then put into array
            Restaurant r1 = new Restaurant
            {
                Rank = 1,
                rName = "K's Kitchen",
                rFavDish = "katsudon",
                rAddress = "322 W Center St. Provo, Utah 84601",
                rPhone = "(385)201-7523",
                rLink = "https://ksjapanesekitchen.com/"
            };

            Restaurant r2 = new Restaurant
            {
                Rank = 2,
                rName = "Silver Dish",
                rFavDish = "Drunken Noodles",
                rAddress = "278 W Center St, Provo, UT 84601, US",
                rPhone = "(801)373-9540",
                rLink = "https://silverdishthaicuisine.com/"
            };

            Restaurant r3 = new Restaurant
            {
                Rank = 3,
                rName = "Cubby's",
                rFavDish = "Bibimbop",
                rAddress = "1175 N Canyon Rd #3420, Provo, UT 84604, United States",
                rPhone = "(801)850-4358",
            };

            Restaurant r4 = new Restaurant
            {
                Rank = 4,
                rName = "Koko Lunchbox",
                rAddress = "1258 N State Street, Provo, UT 84601, USA",
                rPhone = "(801)919-3023",
                rLink = "https://cubbys.co/"
            };

            Restaurant r5 = new Restaurant
            {
                Rank = 5,
                rName = "Noodle King",
                rAddress = "163 N University Ave, Provo, UT 84601, USA",
                rPhone = "(801)818-1028",
                rLink = "https://noodlekingprovo.wixsite.com/website"
            };

            //return array in rank order
            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
