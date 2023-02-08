using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;
        public DataModel()
        {
            con = new SqlConnection(ConnectionStrings.ConStr);
            cmd = con.CreateCommand();
        }
        #region YONETICI METOTLARI
        public Yonetici adminGiris(string mail, string sifre)
        {
            try
            {
                cmd.CommandText = "SELECT COUNT(*) FROM Yoneticiler WHERE Mail = @mail AND Sifre = @sifre";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("mail", mail);
                cmd.Parameters.AddWithValue("sifre", sifre);
                con.Open();
                int sayi = Convert.ToInt32(cmd.ExecuteScalar());
                if (sayi > 0)
                {
                    cmd.CommandText = "SELECT Y.ID, Y.YoneticiTur_ID,Y.Isim, Y.Soyisim,Y.KullaniciAdi, Y.Sifre,Y.Mail,Y.Durum, YT.Isim FROM Yoneticiler AS Y JOIN YoneticiTurleri AS YT ON Y.YoneticiTur_ID = YT.ID WHERE Y.Mail = @mail AND Y.Sifre = @sifre";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@mail", mail);
                    cmd.Parameters.AddWithValue("@sifre", sifre);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Yonetici y = new Yonetici();
                    while (reader.Read())
                    {
                        y.ID = reader.GetInt32(0);
                        y.yoneticiTurID = reader.GetInt32(1);
                        y.ad = reader.GetString(2);
                        y.soyad = reader.GetString(3);
                        y.kullaniciAdi = reader.GetString(4);
                        y.sifre = reader.GetString(5);
                        y.mail = reader.GetString(6);
                        y.durum = reader.GetBoolean(7);
                        y.yoneticiTur = reader.GetString(8);
                    }
                    return y;
                }
                else
                {

                    return null;
                }
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }

        #endregion
    }
}
