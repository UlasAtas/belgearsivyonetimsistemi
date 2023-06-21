using BelgeArsivYonetimSistemi.DAL;
using BelgeArsivYonetimSistemi.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelgeArsivYonetimSistemi.SERVİCE
{
    internal class Kullanıcıservice
    {
        internal void kullaniciKaydet(string gKullaniciad, string gKullanicisifre, string gKullanicigorev)
        {
            (new Kullanicidao()).kullaniciKaydet(new Kullanici(gKullaniciad, gKullanicisifre, gKullanicigorev));
        }

        internal void kullaniciGuncelle(int gId, string gKullaniciad, string gKullanicisifre, string gKullanicigorev)
        {
            (new Kullanicidao()).kullaniciGuncelle(new Kullanici(gId, gKullaniciad, gKullanicisifre, gKullanicigorev));
        }

        internal void kullaniciSil(int gId, string gKullaniciad, string gKullanicisifre, string gKullanicigorev)
        {
            (new Kullanicidao()).kullaniciSil(new Kullanici(gId, gKullaniciad, gKullanicisifre, gKullanicigorev));
        }
    }
}
