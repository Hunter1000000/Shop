using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Shop
{
    class ConnectDTLogin
    {
        public string email, password1, password2;
        public ConnectDTLogin(string email, string password1)
        {
            this.email = email;
            this.password1 = password1;
            string connectionString = @"Data Source=SQL8001.site4now.net;Initial Catalog=db_a856f4_egorchaplygin;User Id=db_a856f4_egorchaplygin_admin;Password=12341234gG;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute("INSERT INTO Users (email, password1) VALUES(@email,@password)");
            }
        }
        public ConnectDTLogin(string email, string password1, string password2)
        {
            this.email = email;
            this.password1 = password1;
            this.password2 = password2;
            if(password1 == password2)
            {
                string connectionString = @"Data Source=SQL5080.site4now.net;Initial Catalog=db_a8323e_itstep011;User Id=db_a8323e_itstep011_admin;Password=passitstep011;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Execute("INSERT INTO Users (email, password) VALUES(@email,@password)");
                }
            }
        }
    }
}
