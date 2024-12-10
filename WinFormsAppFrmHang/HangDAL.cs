using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppFrmHang
{
    internal class HangDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public HangDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllHang()
        {
            //B1: Tạo câu lệnh SQ; để lấy toàn bộ sinh viên
            string sql = "SELECT * FROM Hang";
            //B2: Tạo một kết nối đến SQL
            SqlConnection con = dc.GetConnection();
            //B3: Khởi tạo đối tượng của lớp SQLDataAdapter
            da = new SqlDataAdapter(sql, con);
            //B4 Mở kết nối
            con.Open();
            //B5: Đổ dữ liệu từ SqlDataAdapter vào DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            //B6: đóng kết nối
            con.Close();
            return dt;
        }

        public bool InsertHang(Hang H)
        {
            string sql = "INSERT INTO Hang(MaH, TenH, DonGia) VALUES(@MaH, @TenH, @DonGia)";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaH", SqlDbType.VarChar).Value = H.MaH;
                cmd.Parameters.Add("@TenH", SqlDbType.NVarChar).Value = H.TenH;
                cmd.Parameters.Add("@DonGia", SqlDbType.Money).Value = H.DonGia;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool UpdateHang(Hang H)
        {
            string sql = "UPDATE Hang SET MaH = @MaH, TenH = @TenH, DonGia = @DonGia WHERE MaH = @MaH ";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaH", SqlDbType.VarChar).Value = H.MaH;
                cmd.Parameters.Add("@TenH", SqlDbType.NVarChar).Value = H.TenH;
                cmd.Parameters.Add("@DonGia", SqlDbType.Money).Value = H.DonGia;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool DeleteHang(Hang H)
        {
            string sql = "DELETE Hang  WHERE MaH = @MaH ";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaH", SqlDbType.VarChar).Value = H.MaH;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable findMaHang(string hang)
        {
            string sql = "SELECT * FROM Hang WHERE MaH like  '%" + hang + "%' OR TenH like N'%" + hang + "%'";
            //B2: Tạo một kết nối đến SQL
            SqlConnection con = dc.GetConnection();
            //B3: Khởi tạo đối tượng của lớp SQLDataAdapter
            da = new SqlDataAdapter(sql, con);
            //B4 Mở kết nối
            con.Open();
            //B5: Đổ dữ liệu từ SqlDataAdapter vào DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            //B6: đóng kết nối
            con.Close();
            return dt;
        }
        public string GetNewMaH()
        {
            string newMaH = string.Empty;
            string sql = "spNew_MaH"; // Tên thủ tục trong SQL
            SqlConnection con = dc.GetConnection();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con)
                {
                    CommandType = CommandType.StoredProcedure // Gọi thủ tục
                };

                // Thêm tham số OUTPUT cho thủ tục
                SqlParameter outputParam = new SqlParameter("@new_MaH", SqlDbType.VarChar, 9)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputParam);

                con.Open();
                cmd.ExecuteNonQuery();

                // Lấy giá trị của tham số OUTPUT
                newMaH = outputParam.Value.ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                Console.WriteLine("Error in GetNewMaH: " + ex.Message);
            }
            return newMaH;
        }


        public bool IsHangExists(string tenHang)
        {
            using (SqlConnection conn = dc.GetConnection()) // Sử dụng dc.GetConnection()
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT dbo.fTonTai(@tenHang)", conn);
                    cmd.Parameters.AddWithValue("@tenHang", tenHang);

                    var result = cmd.ExecuteScalar();
                    return result != null && result.ToString() == "1";
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi cho người dùng
                    MessageBox.Show("Đã xảy ra lỗi khi kiểm tra dữ liệu. Vui lòng thử lại sau.",
                                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Ném lại lỗi để xử lý thêm ở nơi gọi phương thức này (nếu cần)
                    throw;
                }
                finally
                {
                    conn.Close(); // Đảm bảo kết nối được đóng, dù có lỗi xảy ra hay không
                }
            }
        }

    }

}
