using identity.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace identity.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();//Model içerisindeki Contexi tanımlıyorum
        [HttpGet]
        public IActionResult GirisYap()
        {
            return View();
        }

        public async Task<IActionResult> GirisYap(Admin p) //2. girisyap oluşturuyorum uygun seçenek olunca bu yapıya girmesi adına 
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.Kullanici == p.Kullanici && x.Sifre == p.Sifre);//textte yazılanları Cookiede eşitleme işlemi yapıyorum
            if (bilgiler != null) //Eger textboxlar doluysa ifade içerisine giriyor
            {
                var claims = new List<Claim>//Claim yapımı oluşturuyorum
                {
                    new Claim(ClaimTypes.Name,p.Kullanici)
                };
                var useridentity = new ClaimsIdentity(claims, "Login");//Identity tanımlamamı yapıyorum Loginden aldırıyorum
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);//principal sorgu alanımızdır loginden geleni sorgulatıyorum
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Personel");//principalden gelen veri doğruysa personel controlleri içindeki Index actionuna git diyorum

            }
            return View();
        }

    }
}
