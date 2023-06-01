using BelgeArsivYonetimSistemi.DAL;
using BelgeArsivYonetimSistemi.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelgeArsivYonetimSistemi.SERVICE
{
    internal class Emanetciservice
    {
        internal void emanetciKaydet(string gAd, string gSoyad, string gİletişim, string gAciklama, string gEvrakturu, string gEvrakyeri)
        {
            (new Emanetcidao()).emanetKaydet(new Emanetci(gAd, gSoyad, gİletişim, gAciklama, gEvrakturu, gEvrakyeri ));
        }

        /*internal void emanetGuncelle(int gId, string gAciklama, string gEvrakturu, string gEvrakyeri)
        {
            (new Emanetcidao()).emanetGuncelle(new Emanetci(gId, gAciklama, gEvrakturu, gEvrakyeri));
        }*/

        internal void emanetciSil(int gId, string gAd, string gSoyad, string gİletişim, string gAciklama, string gEvrakturu, string gEvrakyeri)
        {
            (new Emanetcidao()).emanetSil(new Emanetci(gId, gAd, gSoyad, gİletişim, gAciklama, gEvrakturu, gEvrakyeri));
        }
    }
}
