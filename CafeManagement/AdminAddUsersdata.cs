using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CafeManagementSystem
{
    class AdminAddUsersdata
    {
        //connection kon = new connection();
        //SqlConnection con;
        //connection kon = new connection();
        //SqlConnection con;
        //con = kon.getConnect();

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-MV98GJ7M;Initial Catalog=Cafe;Integrated Security=True;Encrypt=False");

        public int ID { get; set; }
        public string Username { set; get; }
        public string Password { set; get; }

        public string Role {  set; get; }

        public string Status { set; get; }

        public string DataRegistered { set; get; }
        
        public List<AdminAddUsersdata> usersListData()
        {
            List<AdminAddUsersdata> ldata = new  List<AdminAddUsersdata>();

            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();

                    string selData = "SELECT * FROM [Cafe].[dbo].[cafe]";
                    using(SqlCommand cmd = new SqlCommand(selData, con))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            AdminAddUsersdata data = new AdminAddUsersdata();
                            data.ID = (int)dr["id"];
                            data.Username = dr["Username"].ToString();
                            data.Password = dr["Password"].ToString();
                            data.Role = dr["role"].ToString();
                            data.Status = dr["status"].ToString();
                            data.DataRegistered = dr["date_reg"].ToString();

                            ldata.Add(data);


                        }
                    }

                } catch (Exception ex)
                {
                    Console.WriteLine("Connection Failed: " + ex);
                }finally
                {
                    con.Close();
                }
            }
            return ldata;
        }

    }
}
