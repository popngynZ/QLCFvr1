using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Data.SqlClient;
namespace QLCF.Module.BusinessObjects.database
{

    public partial class Doanhthu
    {
        public Doanhthu(Session session) : base(session) { }
        public override void AfterConstruction() 
        { 
            base.AfterConstruction();
            
        }
        public void UpdateThuvaoFromHoadonCT(Doanhthu doanhthu, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT SUM(Thanhtien) FROM HoadonCT JOIN Hoadon on Hoadon.Mahoadon = HoadonCT.MaHDCT HAVING Ngaytao=Ngay";
                SqlCommand command = new SqlCommand(query, connection);
                decimal thanhtien = (decimal)command.ExecuteScalar();
                Console.WriteLine("Thanh bun 123 " + thanhtien);
                this.Thuvao = thanhtien;
            }
        }
        public void UpdateNgayFromHoadon(Doanhthu doanhthu, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Ngaytao FROM Hoadon ";
                SqlCommand command = new SqlCommand(query, connection);
                DateTime ngay = (DateTime)command.ExecuteScalar();
                this.Ngay = ngay;
            }
        }
    }

}
