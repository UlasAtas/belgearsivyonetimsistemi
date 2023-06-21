using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelgeArsivYonetimSistemi.DOMAIN
{
    public class Emanetci
    {
        public Emanetci(string gAd, string gSoyad, string gİletişim, string gEvrakid)
        {
            
            this.Ad = gAd;
            this.Soyad = gSoyad;
            this.İletişim = gİletişim;
            this.Evrakid = gEvrakid;
            
        }

        public Emanetci(int gId, string gAd, string gSoyad, string gİletişim, string gEvrakid)
        {
            this.Id = gId;
            this.Ad = gAd;
            this.Soyad = gSoyad;
            this.İletişim = gİletişim;
            this.Evrakid= gEvrakid;
            
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

        string evrakid;

        public string Evrakid
        {
            get { return evrakid; }
            set { evrakid = value; }
        }
        

    }
}
