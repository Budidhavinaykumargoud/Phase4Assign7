using Microsoft.AspNetCore.Mvc;
namespace WebApplAssign.Models
{
    public class PlayerController : Controller
    {
        static List<Player> players = new List<Player>()
        {
            new Player() {PId=1,PName="Viratkohli",PCountry="India",PType="Batsman" },
            new Player() {PId=2,PName="MS Dhoni",PCountry="India",PType="WicketKeeper" },
            new Player() {PId=3,PName="Bumrah",PCountry="India",PType="Bowler" },
            new Player() {PId=4,PName="Jageja",PCountry="India",PType="All-Rounder" },

        };
        public IActionResult Index()
        {
            return View(players);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Player());
        }
        [HttpPost]
        public IActionResult Create(Player pro)
        {
            if (ModelState.IsValid)
            {
                players.Add(pro);
                return RedirectToAction("Index");
            }
            return View(pro);
        }
    }
}
