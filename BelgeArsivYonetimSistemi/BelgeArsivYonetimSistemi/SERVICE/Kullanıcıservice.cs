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

        internal void kullaniciGuncelle(int gId, string gAciklama, string gEvrakturu, string gEvrakyeri)
        {
            (new Kullanicidao()).kullaniciGuncelle(new Evrak(gId, gAciklama, gEvrakturu, gEvrakyeri));
        }

        internal void kullaniciSil(int gId, string gEvrakturu, string gAciklama, string gEvrakyeri)
        {
            (new Kullanicidao()).kullaniciSil(new Evrak(gId, gEvrakturu, gAciklama, gEvrakyeri));
        }
    }
}
