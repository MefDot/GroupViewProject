using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;

namespace GroupViewProject
{
    class Main
    {

        string strConnection = @"Data Source=DESKTOP-MU6UFKI\SQLEXPRESS;Initial Catalog=groupall;Integrated Security=True";
        public void AddGroup (Group group)
        {
            string SqlCmd = $"INSERT INTO [dbo].[group] ([NameGroup],[NumberGroup],[CuratorGroup]) " +
                $"VALUES ({group.NameGroup},{group.NumberGroup},{group.CuratorGroup})";

            try
            {
                using (SqlConnection connection = new SqlConnection(strConnection))
                {

                    connection.Open();
                    SqlCommand cmd = new SqlCommand(SqlCmd, connection);

                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

    }



    class Group
    {
        public int idGroup { get; set; }

        public string  NameGroup { get; set; }

        public string NumberGroup { get; set; }

        public string  CuratorGroup { get; set; }
    }
}
