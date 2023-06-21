using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelgeArsivYonetimSistemi.DOMAIN
{
    internal class Evrak
    {
        public Evrak(string gAciklama, string gEvrakturu, string gEvrakyeri)
        {

            this.Evraktürü = gEvrakturu;
            this.Açıklama = gAciklama;
            this.Evrakyeri = gEvrakyeri;
        }

        public Evrak(int gId,string gAciklama, string gEvrakturu, string gEvrakyeri)
        {
            this.Id = gId;
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
