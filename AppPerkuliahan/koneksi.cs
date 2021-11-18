using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerkuliahan
{
    class koneksi
    {
        public static string Koneksi = string.Format
            ("Data Source=XE; User Id=dbperkuliahan;password=123;");
        public static OracleConnection GetConnection()
        {
            return new OracleConnection(Koneksi);
        }

        internal static object GetOracleConnection()
        {
            throw new NotImplementedException();
        }
    }
}
