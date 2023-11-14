using Microsoft.AspNetCore.Mvc;
using Project_OOP.Examples;

namespace Project_OOP.Controllers
{
    public class DefaultController : Controller
    {

        void messages()
        {
            ViewBag.m1 = "Merhaba bu bir core projesi";
            ViewBag.m2 = "Merhaba proje çok iyi duruyor";
            ViewBag.m3 = "Selamlar hi hello bonjour";
        }

        public int topla()
        {
            int s1 = 20;
            int s2 = 30;
            int result = s1 + s2;
            return result;
        }

        int cevre()
        {
            int kisa = 10;
            int uzun = 20;
            int cevre = 2 * (kisa + uzun);
            return cevre;
        }

        string cumle()
        {
            string c = "Küçük Hanımlar Küçük Beyler Sizler Hepiniz";

            return c;
        }

        void MessageList(string p)
        {
            ViewBag.v = p;
        }

        void Kullanıcı(string kullanicadi)
        {
            ViewBag.v = kullanicadi;
        }
        public IActionResult Index()

        {
            messages();
            MessageList("Parametre ismi");
            Kullanıcı("mmember123");

            return View();
        }
        public IActionResult Urunler()
        {
            messages();
            ViewBag.t = topla();
            ViewBag.c = cevre();
            Kullanıcı("Murat000");
            return View();
        }
        public IActionResult Musteriler()
        {
            ViewBag.d = cumle();
            Kullanıcı("admin004");
            return View();
        }
        public IActionResult Deneme()
        {
            Sehirler sehirler = new Sehirler();
            sehirler.SehirAd = "Kiev";
            sehirler.SehirID = 1;
            sehirler.Nufus = 10000000;
            sehirler.Ulke = "Ukrayna";
            sehirler.Renk1 = "Mavi"; 


            ViewBag.v1 = sehirler.SehirAd;
            ViewBag.v2 = sehirler.SehirID;
            ViewBag.v3 = sehirler.Nufus;
            ViewBag.v4 = sehirler.Ulke;
            ViewBag.v5 = sehirler.Renk1;
            ViewBag.v6 = sehirler.Renk2;

            sehirler.SehirAd = "Üsküp";
            sehirler.SehirID = 2;
            sehirler.Nufus = 8000000;
            sehirler.Ulke = "Makedonya";
            sehirler.Renk1 = "Kırmızı";
            sehirler.Renk2 = "Sarı";

            ViewBag.z1 = sehirler.SehirAd;
            ViewBag.z2 = sehirler.SehirID;
            ViewBag.z3 = sehirler.Nufus;
            ViewBag.z4 = sehirler.Ulke;
            ViewBag.z5 = sehirler.Renk1;
            ViewBag.z6 = sehirler.Renk2;


            return View();
        }
    }
}
