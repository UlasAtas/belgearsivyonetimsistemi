using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BelgeArsivYonetimSistemi.DOMAIN;
using System.Data.SqlClient;

namespace BelgeArsivYonetimSistemi.DAL
{
    internal class Kullanicidao
    {
        public void kullaniciKaydet(Kullanici gKullanici)
        {
            (new MySqlCommand("insert into kullanicilar (kullaniciadi,kullanicisifre,kullanicitipi) values ('" + gKullanici.Kadı + "' , '" + gKullanici.Sifre + "' , '" + gKullanici.Gorev + "')", (new dbbaglanti()).baglantiGetir())).ExecuteNonQuery();
        }

        public void kullaniciGuncelle(Evrak gEvrak)
        {

            new MySqlCommand("update kullanicilar set kullaniciadi = '" + gEvrak.Açıklama + "' , kullanicisifre = '" + gEvrak.Evraktürü + "' , kullanicitipi = '" + gEvrak.Evrakyeri + "'where id = '" + gEvrak.Id + "'", (new dbbaglanti()).baglantiGetir()).ExecuteNonQuery();
        }

        internal void kullaniciSil(Evrak gEvrak)
        {
            new MySqlCommand("delete from kullanicilar where id=" + gEvrak.Id, (new dbbaglanti()).baglantiGetir()).ExecuteNonQuery();
        }

    }
}
