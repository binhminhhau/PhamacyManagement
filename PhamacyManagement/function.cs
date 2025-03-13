﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamacyManagement
{
    internal class function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Legion\\OneDrive - Phenikaa University\\Documents\\phamacy.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=True";
            return con;
        }
        public DataSet getData (String query)
        {
            SqlConnection con= new SqlConnection();
            SqlCommand cmd = new SqlCommand(); //3 dòng này có thể thay là
            cmd.Connection = con;       //SqlCommand cmd = new SqlCommand(query,con);
            cmd.CommandText = query;           
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }

        public void setData (String query, String msg)
        {
            SqlConnection con= new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;   
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(msg,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
