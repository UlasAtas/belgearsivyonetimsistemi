using BelgeArsivYonetimSistemi.DOMAIN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace BelgeArsivYonetimSistemi.DAL
{
    internal class Emanetcidao
    {
        public void emanetKaydet(Emanetci gEmanetci)
        {
            (new MySqlCommand("insert into emanetci (ad,soyad,iletisim,evrakid) values ('" + gEmanetci.Ad + "' , '" + gEmanetci.Soyad + "' , '" + gEmanetci.İletişim + "' , '" + gEmanetci.Evrakid + "' )", (new dbbaglanti()).baglantiGetir())).ExecuteNonQuery();
        }

        public void emanetGuncelle(Emanetci gEmanetci)
        {

            new MySqlCommand("update emanetci set ad = '" + gEmanetci.Ad + "' , soyad = '" + gEmanetci.Soyad + "' , iletisim = '" + gEmanetci.İletişim + "' , evrakid = '" + gEmanetci.Evrakid + "'  where id = '" + gEmanetci.Id + "'", (new dbbaglanti()).baglantiGetir()).ExecuteNonQuery();
        }


        internal void emanetSil(Emanetci gEmanetci)
        {
            new MySqlCommand("delete from emanetci where id=" + gEmanetci.Id, (new dbbaglanti()).baglantiGetir()).ExecuteNonQuery();
        }
    }
}
