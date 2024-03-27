using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;

namespace siked.konfigurasi
{
    class LayananCls : KonfigurasiCls
    {
        MySqlConnection mCon;
        MySqlCommand mCom;
        MySqlDataAdapter mAdp;

        string link = "server=localhost;port=3306;database=siked;uid=root;pwd=";

        //Constructor
        public LayananCls()
        {
            mCon = new MySqlConnection(link);
            mCom = new MySqlCommand();
            mAdp = new MySqlDataAdapter();
        }


        void bukaKoneksi()
        {
            try
            {
                if (mCon.State == ConnectionState.Closed)
                {
                    mCon.Open();
                }
            }
            catch (Exception e) { }
        }

        void tutupKoneksi()
        {
            mCon.Close();
        }
        public override int eksekusiNonQuery(string query)
        {
            int result = -1;
            try
            {
                bukaKoneksi();
                mCom.Connection = mCon;
                mCom.CommandText = query;
                result = mCom.ExecuteNonQuery();
            }
            catch (Exception e) { }
            finally
            {
                tutupKoneksi();
            }
            return result;
        }
        public override DataTable eksekusiQuery(string query)
        {
            DataTable result = new DataTable();

            try
            {
                bukaKoneksi();
                mCom.Connection = mCon;
                mCom.CommandText = query;
                mAdp.SelectCommand = mCom;
                mAdp.Fill(result);
            }
            catch (Exception e) { }
            finally
            {
                tutupKoneksi();
            }
            return result;
        }
    }
}
