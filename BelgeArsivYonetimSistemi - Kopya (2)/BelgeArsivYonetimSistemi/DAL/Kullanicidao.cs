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
            (new MySqlCommand("insert into kullanicilar (kullaniciadi,kullanicisifre,kullanicigorevi) values ('" + gKullanici.Kadı + "' , '" + gKullanici.Sifre + "' , '" + gKullanici.Gorev + "')", (new dbbaglanti()).baglantiGetir())).ExecuteNonQuery();
        }

        public void kullaniciGuncelle(Kullanici gKullanici)
        {

            new MySqlCommand("update kullanicilar set kullaniciadi = '" + gKullanici.Kadı + "' , kullanicisifre = '" + gKullanici.Sifre + "' , kullanicigorevi = '" + gKullanici.Gorev + "'where id = '" + gKullanici.Id + "'", (new dbbaglanti()).baglantiGetir()).ExecuteNonQuery();
        }

        internal void kullaniciSil(Kullanici gKullanici)
        {
            new MySqlCommand("delete from kullanicilar where id=" + gKullanici.Id, (new dbbaglanti()).baglantiGetir()).ExecuteNonQuery();
        }

    }
}
