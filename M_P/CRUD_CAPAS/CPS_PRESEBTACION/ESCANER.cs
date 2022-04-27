using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CPS_PRESEBTACION
{
    class ESCANER
    {
        SqlConnection cm;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter da;
        DataRow dr;
        SqlDataReader sqldr;

        public string abrirconxion()
        {
            cm = new SqlConnection("server=DESKTOP-RKVOCO8;database=M_P;user=sa;password=123");
            cm.Open();
            return "conectado";
    }
        public string inseratimagen(string documento,PictureBox escaner)
        {
            string mensaje = "se inserto la imagen";
            cmd = new SqlCommand("insert into escaner(numero_documetno,escaner) values(@numero_documetno,@escaner)", cm);
            cmd.Parameters.Add("@numero_documetno", SqlDbType.NChar);
            cmd.Parameters.Add("@escaner", SqlDbType.Image);

            cmd.Parameters["@numero_documetno"].Value = documento;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();

            escaner.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            cmd.Parameters["@escaner"].Value = ms.GetBuffer();
            cmd.ExecuteNonQuery();
            return mensaje;

        }
        public void verimgen(PictureBox foto , string documento)
        {
            da = new SqlDataAdapter("select escaner from escaner where numero_documetno ='" + documento + "'", cm);
            ds = new DataSet();
            da.Fill(ds, "escaner");
            byte[] datos = new byte[0];
            dr = ds.Tables["escaner"].Rows[0];
            datos = (byte[])dr["escaner"];
            System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
            foto.Image = System.Drawing.Bitmap.FromStream(ms);
        }
        public void caragarfoto(ComboBox cmfoto)
        {
            cmd = new SqlCommand("select numero_documetno from escaner ", cm);
            sqldr = cmd.ExecuteReader();
            while(sqldr.Read())
            {
                cmfoto.Items.Add(sqldr["numero_documetno"]);
            }
            sqldr.Close();


        }

    }

}
