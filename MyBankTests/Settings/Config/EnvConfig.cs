using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankTests.Settings.Config
{
    public class EnvConfig
    {
        public string BaseUrl { get; set; }
        public Users Users { get; set; }
        public SqlConnection sqlConnection { get; set; }
    }

    public class Admin
    {
        public string userName { get; set; }
        public string password { get; set; }
    }

    public class Default
    {
        public string userName { get; set; }
        public string password { get; set; }
    }
}
