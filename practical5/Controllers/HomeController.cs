/* 
PRACTICAL 5: Develop ASP.NET Core MVC web application to display information about
ten different birds in HTML table. Apply a style to the HTML table using
bootstrap.css.

Enrollment No.:- 202203103510223

Branch:- B.Tech (CSE)
*/

using Microsoft.AspNetCore.Mvc;
using practical5.Models;
using System.Collections.Generic;

namespace practical5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var birds = new List<Bird>
            {
                new Bird { Name = "American Robin", Species = "Turdus migratorius", Habitat = "Forests, gardens", Diet = "Insects, fruits", Description = "A common North American songbird." },
                new Bird { Name = "Bald Eagle", Species = "Haliaeetus leucocephalus", Habitat = "Near large bodies of open water", Diet = "Fish, small mammals", Description = "The national bird of the United States." },
                new Bird { Name = "Barn Owl", Species = "Tyto alba", Habitat = "Grasslands, farms", Diet = "Small mammals", Description = "Known for its distinctive heart-shaped face." },
                new Bird { Name = "Blue Jay", Species = "Cyanocitta cristata", Habitat = "Forests, suburban areas", Diet = "Nuts, seeds, insects", Description = "A vibrant blue bird with a loud call." },
                new Bird { Name = "Canada Goose", Species = "Branta canadensis", Habitat = "Wetlands, grassy areas", Diet = "Grasses, grains", Description = "Known for its migratory behavior and honking." },
                new Bird { Name = "Cardinal", Species = "Cardinalis cardinalis", Habitat = "Woodlands, gardens", Diet = "Seeds, fruits", Description = "A bright red bird commonly found in North America." },
                new Bird { Name = "Mallard", Species = "Anas platyrhynchos", Habitat = "Wetlands, lakes", Diet = "Aquatic plants, small invertebrates", Description = "A common wild duck with a distinctive green head." },
                new Bird { Name = "Peregrine Falcon", Species = "Falco peregrinus", Habitat = "Mountains, coastal areas", Diet = "Birds, small mammals", Description = "Known for its incredible speed in flight." },
                new Bird { Name = "Red-tailed Hawk", Species = "Buteo jamaicensis", Habitat = "Open fields, deserts", Diet = "Small mammals, birds", Description = "A widespread bird of prey in North America." },
                new Bird { Name = "Snowy Owl", Species = "Bubo scandiacus", Habitat = "Tundra, open fields", Diet = "Small mammals", Description = "A large white owl often associated with winter." }
            };

            return View(birds);
        }
    }
}