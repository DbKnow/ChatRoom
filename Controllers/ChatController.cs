using Microsoft.AspNetCore.Mvc;

namespace ChatRoom.Controllers
{
    public class ChatController : Controller
    {

        public static Dictionary<int, string> Rooms =
            new Dictionary<int, string>()
            {
                { 1,"SALA DE CHAT 1"}
            };

        public static Dictionary<int, string> RoomPins = new()
{
            { 1, "1234" } 
        };

        [HttpGet]
        public IActionResult EnterPin(int room)
        {
            if (!Rooms.ContainsKey(room))
            {
                return NotFound();
            }

            return View(room);
        }

        [HttpPost]
        public IActionResult EnterPin(int room, string pin)
        {
            if (!Rooms.ContainsKey(room))
            {
                return NotFound();
            }

            if (!RoomPins.TryGetValue(room, out var correctPin))
            {
                return NotFound();
            }

            if (pin != correctPin)
            {
                ViewBag.Error = "El PIN introducido es incorrecto.";
                return View(room);
            }

            HttpContext.Session.SetString(
                $"RoomAccess_{room}",
                "true"
            );

            return RedirectToAction("Room", new { room });
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Room(int room)
        {
            if (!Rooms.ContainsKey(room))
            {
                return NotFound();
            }

            var access = HttpContext.Session.GetString($"RoomAccess_{room}");

            if (access != "true")
            {
                return RedirectToAction("EnterPin", new { room });
            }

            return View(room);
        }
    }
}
