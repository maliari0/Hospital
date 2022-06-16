using App4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4.Services
{
    public interface ILoginService
    {
        GirisYapResponse GirisYap(GirisYapInput girisYapInput);
    }
    public class LoginService :ILoginService
    {
        public GirisYapResponse GirisYap(GirisYapInput girisYapInput)
        {
            var sonuc = new GirisYapResponse();

            if (girisYapInput.Tc == "12345678901"
                && girisYapInput.Sifre == "123")
            {
                sonuc.BasariliMi = true;
            }
            else
            {
                sonuc.Mesaj = "Kullanıcı adınız ya da şifreniz yanlış";
            }

            return sonuc;
        }
    }
}
