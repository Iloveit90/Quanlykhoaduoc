using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LayerDataAccess
{
    public class actionData
    {
        #region Các hàm thực hiện kết nối, truy xuất và thực hiện các lệnh sql
        private SqlConnection conn;
        private SqlCommand cmm;
        private DataTable data;
        private DataSet dataset;
        private SqlDataAdapter dtAdap;
        public SqlConnection getConnect()
        {
            return new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=DBKHOADUOC;Integrated Security=True");
        }
        // Ket noi toi database
        public DataTable getDataTable(string sql)
        {
            conn = getConnect();
            conn.Open();
            dtAdap = new SqlDataAdapter(sql, conn);
            data = new DataTable();
            dtAdap.Fill(data);
            conn.Close();
            return data;
        }
        // Tra ve mot data table
        public DataSet getDataSet(string sql)
        {
            conn = getConnect();
            conn.Open();
            dtAdap = new SqlDataAdapter(sql, conn);
            dataset = new DataSet();
            dtAdap.Fill(dataset);
            conn.Close();
            return dataset;
        }
        // tra ve mot dataset
        public void ExecuTable(string sql)
        {
            try
            {
                conn = getConnect();
                conn.Open();
                cmm = new SqlCommand(sql, conn);
                cmm.ExecuteNonQuery();
                conn.Close();
                cmm.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }
        }
        // thực hiện câu thủ tục sql insert, update, delete
        public int ExcuteStoredProcedure(string Tenthutuc, string[] cacthamso, object[] giatricacthamso)
        {
            try
            {
                conn = getConnect();
                conn.Open();
                cmm = new SqlCommand(Tenthutuc, conn);
                cmm.CommandType = CommandType.StoredProcedure;
                SqlParameter thamso;
                for (int i = 0; i < cacthamso.Length; i++)
                {
                    thamso = new SqlParameter(cacthamso[i], giatricacthamso[i]);
                    cmm.Parameters.Add(thamso);
                }
                return cmm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                
                return 7;
            }
        }
        // thực hiện thủ tục select trả về một datatable
        public DataTable ExcuteStoredProcedureselect(string Tenthutuc, string[] cacthamso, object[] giatricacthamso)
        {
            try
            {
                conn = getConnect();
                conn.Open();
                cmm = new SqlCommand(Tenthutuc, conn);
                cmm.CommandType = CommandType.StoredProcedure;
                SqlParameter thamso;
                for (int i = 0; i < cacthamso.Length; i++)
                {
                    thamso = new SqlParameter(cacthamso[i], giatricacthamso[i]);
                    cmm.Parameters.Add(thamso);
                }
                SqlDataReader data = cmm.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(data);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        #endregion
        #region Các hàm thực hiện sử lý data
        public DateTime ReturnDate(string ngay)
        {
            DateTime dateTime = new DateTime();
            try
            {
                CultureInfo cu = new CultureInfo("vi-VN");
                cu.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
                cu.DateTimeFormat.DateSeparator = "/";
                cu.NumberFormat.PercentDecimalSeparator = ".";
                dateTime = DateTime.Parse(ngay, new CultureInfo("vi-VN"));
                return dateTime;
            }
            catch
            {
                return dateTime;
            }
        }
        /// thực hiện chuyển kiểu ngày tháng phù hợp với sql
    }
        #endregion
}
