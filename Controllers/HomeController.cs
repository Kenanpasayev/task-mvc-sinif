using Microsoft.AspNetCore.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Slider slider = new Slider() 
            {
                Title = "Ab_105",
                Description="ghdhkkjhjhfdjdjfkkenanbdshhfsdfhbhbfhsdgh hdgfhdsf sgh khgfjhgbn hkgsbhjb",
                PhotoUrl="team-1.jpg"

            };
            Slider slider1 = new Slider()
            {
                Title = "Ab_107",
                Description = "ghdhkkjhjhhfdshb dghgdh jhgdshfds jdjfkkenanbdshhfsdfhb bfhsdgh hdgfhdsf sgh khgfjhgbn hkgsbhjb",
                PhotoUrl = "team-2.jpg"

            };

            List<Slider> lists= new List<Slider>();
            lists.Add(slider);
            lists.Add(slider1);

            return View(lists);
        }
    }
}