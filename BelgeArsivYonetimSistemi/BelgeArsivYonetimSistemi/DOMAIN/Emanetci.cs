using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelgeArsivYonetimSistemi.DOMAIN
{
    public class Emanetci
    {
        public Emanetci(string gAd, string gSoyad, string gİletişim, string gAciklama, string gEvrakturu, string gEvrakyeri)
        {
            
            this.Ad = gAd;
            this.Soyad = gSoyad;
            this.İletişim = gİletişim;
            this.Evraktürü = gEvrakturu;
            this.Açıklama = gAciklama;
            this.Evrakyeri = gEvrakyeri;
        }

        public Emanetci(int gId, string gAd, string gSoyad, string gİletişim, string gAciklama, string gEvrakturu, string gEvrakyeri)
        {
            this.Id = gId;
            this.Ad = gAd;
            this.Soyad = gSoyad;
            this.İletişim = gİletişim;
            this.Evraktürü = gEvrakturu;
            this.Açıklama = gAciklama;
            this.Evrakyeri = gEvrakyeri;
        }

        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        string ad;

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }

        string soyad;

        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }

        string iletişim;

        public string İletişim
        {
            get { return iletişim; }
            set { iletişim = value; }
        }

        string evraktürü;

        public string Evraktürü
        {
            get { return evraktürü; }
            set { evraktürü = value; }
        }

        string açıklama;

        public string Açıklama
        {
            get { return açıklama; }
            set { açıklama = value; }
        }

        string evrakyeri;

        public string Evrakyeri
        {
            get { return evrakyeri; }
            set { evrakyeri = value; }
        }

    }
}
