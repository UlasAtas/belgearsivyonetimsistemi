using BelgeArsivYonetimSistemi.DAL;
using BelgeArsivYonetimSistemi.DOMAIN;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelgeArsivYonetimSistemi.SERVICE
{
    internal class Evrakservice
    {
        internal void evrakKaydet(string gAciklama, string gEvrakturu, string gEvrakyeri)
        {
            (new Evrakdao()).evrakKaydet(new Evrak(gAciklama, gEvrakturu, gEvrakyeri));
        }


        internal void evrakGuncelle(int gId,string gAciklama, string gEvrakturu, string gEvrakyeri)
        {
            (new Evrakdao()).evrakGuncelle(new Evrak(gId,gAciklama, gEvrakturu, gEvrakyeri));
        }

        internal void evrakSil(int gId, string gEvrakturu, string gAciklama, string gEvrakyeri)
        {
            (new Evrakdao()).evrakSil(new Evrak(gId, gEvrakturu, gAciklama, gEvrakyeri));
        }

        
    }
}
