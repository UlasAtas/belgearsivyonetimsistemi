using BelgeArsivYonetimSistemi.DOMAIN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;

namespace BelgeArsivYonetimSistemi.DAL
{
    internal class Evrakdao 
    {

        public void evrakKaydet(Evrak gEvrak)
        {
            (new MySqlCommand("insert into evraklar (evrakaciklama,evraktipi,evrakyeri) values ('" + gEvrak.Evraktürü + "' , '" + gEvrak.Açıklama + "' , '" + gEvrak.Evrakyeri + "')", (new dbbaglanti()).baglantiGetir())).ExecuteNonQuery();
        }

        public void evrakGuncelle(Evrak gEvrak)
        {
            
            new MySqlCommand("update evraklar set evrakaciklama = '" + gEvrak.Açıklama + "' , evraktipi = '" + gEvrak.Evraktürü + "' , evrakyeri = '" + gEvrak.Evrakyeri + "'where id = '" +gEvrak.Id +"'", (new dbbaglanti()).baglantiGetir()).ExecuteNonQuery();
        }

        internal void evrakSil(Evrak gEvrak)
        {
            new MySqlCommand("delete from evraklar where id=" + gEvrak.Id,(new dbbaglanti()).baglantiGetir()).ExecuteNonQuery();
        }

        
    }
}
