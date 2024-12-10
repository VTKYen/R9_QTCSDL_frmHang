using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WinFormsAppFrmHang.Hang;

namespace WinFormsAppFrmHang
{
    internal class HangBLL
    {
        HangDAL dalHang;
        public HangBLL()
        {
            dalHang = new HangDAL();
        }
        public DataTable getALLHang()
        {
            return dalHang.getAllHang();
        }
        public bool InsertHang(Hang H)
        {
            return dalHang.InsertHang(H);
        }
        public bool UpdateHang(Hang H)
        {
            return dalHang.UpdateHang(H);
        }
        public bool DeleteHang(Hang H)
        {
            return dalHang.DeleteHang(H);
        }
        public DataTable findMaHang(string hang)
        {
            return dalHang.findMaHang(hang);
        }
        public bool CheckHangExists(string tenHang)
        {
            return dalHang.IsHangExists(tenHang);
        }
        public string GetNewMaH()
        {
            return dalHang.GetNewMaH();
        }
    }


}
