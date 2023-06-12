using Microsoft.AspNetCore.Mvc;
// using cinemaos3.Database;
using cinemaos3.Models;
using System.Diagnostics;

namespace cinemaos3.Controllers
{
    public class HomeController : Controller
    {
        private Dictionary<string, Film> films = new Dictionary<string, Film>()
        {
            { "avatar", new Film("avatar", "Jake Sully woont met zijn nieuwe familie gevormd op de planeet Pandora. Zodra een bekende dreiging terugkeert om af te maken wat eerder was begonnen, moet Jake samenwerken met Neytiri en het leger van het Na'vi-ras om hun planeet te beschermen.", "Images/avatar.jpg" , "cast: Sam Worthington, Zoe Saldana, Sigourney Weaver", "Images/Kijkwijzer16.png") },
            { "johnwick4", new Film("John Wick 4", "John Wick: Chapter 4 is een Amerikaanse neo noir-actiefilm uit 2023, geregisseerd door Chad Stahelski. De film is het vervolg op John Wick: Chapter 3 – Parabellum uit 2019 en het vierde deel in de John Wick-franchise, met Keanu Reeves als het titulaire personage.", "Images/johnwick4.jpg" , "Cast: Keanu Reeves, Donnie Yen, Bill Skarsgård", "Images/Kijkwijzer16.png") },
            { "gotg3", new Film("Guardians of the Galaxy Vol. 3", "Guardians of the Galaxy Vol. 3 is een aankomende Amerikaanse superheldenfilm, gebaseerd op Guardians of the Galaxy van Marvel Comics, geproduceerd door Marvel Studios en gedistribueerd door Walt Disney Studios Motion Pictures. Het is het vervolg op de in 2017 verschenen film Guardians of the Galaxy Vol. 2.", "Images/gotg3.png" , "Cast: Chris Pratt, Chukwudi Iwuji, Bradley Cooper", "Images/Kijkwijzer16.png") },
            { "mario", new Film("The Super Mario Bros. Movie", "De Italiaans-Amerikaanse broers Mario en Luigi zijn onlangs een loodgietersbedrijf begonnen in Brooklyn. Hun vader keurt Mario's beslissing af om zijn vaste baan onder zijn vijandige ex-werkgever Spike op te geven en gelooft dat hij Luigi met zich meesleurt. Na het zien van een aanzienlijk putlek op het nieuws, gaan Mario en Luigi ondergronds om het te repareren, maar worden in een Warp Pipe gezogen en gescheiden.", "Images/mario.jpg" , "Cast: Chris Pratt, Charlie Day, Anya Taylor-Joy, Jack Black", "Images/Kijkwijzer12.png") },
            { "topgun", new Film("Top Gun: Maverick", "Top Gun: Maverick is een Amerikaanse actiefilm uit 2022, geregisseerd door Joseph Kosinski en geschreven door Ehren Kruger, Eric Warren Singer en Christopher McQuarrie naar verhalen van Peter Craig en Justin Marks. De film is een vervolg op de film Top Gun uit 1986. Tom Cruise herneemt zijn hoofdrol als de marinevlieger Maverick. ", "Images/topgun.jpg" , "Cast: Tom Cruise, Val Kilmer, Miles Teller", "Images/Kijkwijzer12.png") },
            { "puss", new Film("Puss in Boots: The Last Wish", "Tijdens het organiseren van een feest in de stad Del Mar, maakt de legendarische held en outlaw Puss in Boots per ongeluk een slapende reus wakker. Hij onderwerpt het wezen, maar wordt verpletterd door een bel. De stadsdokter wordt wakker in een ziekenhuis en vertelt hem dat hij acht van zijn negen levens heeft verloren en stelt voor dat Puss met pensioen moet gaan. Die avond ontmoet Poes in een bar een wolf met zwarte kap, die hem ontwapent en verwondt in een zwaardgevecht.", "Images/puss.jpg" , "Cast: Antonio Banderas, Salma Hayek Pinault", "Images/Kijkwijzer12.png") }



        };


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            /*
             // alle producten ophalen
            var rows = DatabaseConnector.GetRows("select * from cinemaos");

            // lijst maken om alle namen in te stoppen
            List<string> names = new List<string>();

            foreach (var row in rows)
            {
                // elke naam toevoegen aan de lijst met namen
                names.Add(row["naam"].ToString());
            }

            // de lijst met namen in de html stoppen
            return View(names);
            */
            return View();
        }

        [Route("OverOns")]
        public IActionResult OverOns()
        {
            return View();
        }

        [Route("Contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [Route("Contact")]
        public IActionResult Contact(Person person)
        {
            if (ModelState.IsValid)
                return Redirect("/succes");
            
                    return View(person);
        }

        [Route("succes")]
        public IActionResult Succes()
        {
            return View();
        }

        [Route("detail")]
        public IActionResult Detail(string filmName)
        {
            return View(films[filmName]);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
