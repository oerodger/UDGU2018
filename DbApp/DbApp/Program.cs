using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DbConnectionName"];
            if (connectionString == null)
            {
                Console.WriteLine("Нет строки подключения к БД");
                Console.ReadKey();
                return;
            }
            using (var connection = new SqlConnection(connectionString.ConnectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    //Создание новых записей
                    /*using (var tran = connection.BeginTransaction())
                    {
                        try
                        {
                            command.Transaction = tran;
                            command.CommandText = $@"
insert into [User] ([Id], [UserName], [FIO]) 
values ('{Guid.NewGuid()}', 'ivanov', 'Иванов Иван Иванович')";                            
                            command.ExecuteNonQuery();
                           

                            command.CommandText = $@"
insert into [User] ([Id], [UserName], [FIO]) 
values ('{Guid.NewGuid()}', 'petrov', 'Петров Петр Петрович')";
                            command.ExecuteNonQuery();

                            tran.Commit();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            tran.Rollback();
                        }
                    }*/
                    //Чтение данных из БД
                    var userList = new List<User>();
                    command.CommandText = "select [Id], [UserName], [FIO] from [User]";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            userList.Add(new User
                            {
                                Id = reader.GetGuid(0),
                                UserName = reader.GetString(1),
                                FIO = reader.GetString(2)
                            });
                        }
                    }
                    foreach (var user in userList)
                    {
                        Console.WriteLine($"Id: {user.Id}, UserName: {user.UserName}, FIO: {user.FIO}");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
