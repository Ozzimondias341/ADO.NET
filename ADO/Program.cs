using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connector;

using System.Data.SqlClient;


namespace ADO
{
    internal class Program
    {

        static void Main(string[] args)
        {

            string connection_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Movies_PV_521;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


            Connector.Connector connector = new Connector.Connector(connection_string);

            //connector.Insert($@"INSERT Directors (director_id ,first_name,last_name) VALUES ({connector.GetNextPrimaryKey("Directors")},N'Guy', N'Richie');");

            //string cmd = "SELECT movie_id,title,release_date,first_name,last_name FROM Movies, Directors WHERE director = director_id";

            //connector.Select(cmd);

            connector.Insert
                (
                "Directors",
                "director_id, first_name, last_name",
                $"{connector.GetNextPrimaryKey("Directors")},John,Singleton"
                );


            connector.Select("*", "Directors");

            Console.WriteLine($"Количество записей: {connector.Scalar("SELECT COUNT(*) FROM Directors")}");

            //connector.Select("title,release_date,first_name,last_name", "Movies,Directors", "director=director_id");

            //Console.WriteLine($"Количество записей: {connector.Scalar("SELECT COUNT(*) FROM Movies")}");


            Console.WriteLine( connector.GetPrimaryKeyColumnName("Movies"));



            //command.CommandText = "SELECT COUNT(*) FROM Movies";
            //Console.WriteLine($"Количество записей:\t {command.ExecuteScalar()}");


        }
       
    }
}
