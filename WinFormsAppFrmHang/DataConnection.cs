using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppFrmHang
{
    internal class DataConnection
    {
        string conStr;
        public DataConnection()
        {
            conStr = "Data Source = LAPTOP-7TG2VR0J\\SQL; Initial Catalog= NhatNamFood2; Integrated Security=true";
        }
        public SqlConnection GetConnection()
        {

            return new SqlConnection(conStr);
        }
    }

}

