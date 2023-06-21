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
        internal void emanetciKaydet(string gAd, string gSoyad, string gİletişim, string gEvrakid)
        {
            (new Emanetcidao()).emanetKaydet(new Emanetci(gAd, gSoyad, gİletişim, gEvrakid ));
        }

        internal void emanetGuncelle(int gId, string gAd, string gSoyad, string gİletişim, string gEvrakid)
        {
            (new Emanetcidao()).emanetGuncelle(new Emanetci(gId, gAd, gSoyad, gİletişim, gEvrakid));
        }

        internal void emanetciSil(int gId, string gAd, string gSoyad, string gİletişim, string gEvrakid)
        {
            (new Emanetcidao()).emanetSil(new Emanetci(gId, gAd, gSoyad, gİletişim, gEvrakid));
        }
    }
}
