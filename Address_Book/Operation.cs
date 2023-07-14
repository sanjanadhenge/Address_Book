using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    internal class Operation
    {
        public static string connectionstring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AddressBook_Servive_DB";
        SqlConnection connection = new SqlConnection(connectionstring);
        Contacts contact = new Contacts();
        public void GetAllRecords()
        {


            try
            {
                using (this.connection)
                {
                    string query = @"select * from  RecordsDB";
                    SqlCommand command = new SqlCommand(query, this.connection);
                    command.CommandType = System.Data.CommandType.Text;
                    this.connection.Open();
                    SqlDataReader read = command.ExecuteReader();
                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            contact.ID = read.GetInt32(0);
                            contact.FirstName = read.GetString(1);
                            contact.LastName = read.GetString(2);
                            contact.Address = read.GetString(3);
                            contact.City = read.GetString(4);
                            contact.State = read.GetString(5);
                            contact.zip = read.GetString(6);
                            contact.PhoneNumber = read.GetString(7);
                            contact.Email = read.GetString(8);
                            contact.StartDate = read.GetDateTime(9);

                            Console.WriteLine(contact.ID + "\n" + contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.zip + "\n" + contact.PhoneNumber + "\n" + contact.Email + "\n" + contact.StartDate);
                        }

                    }
                    else
                    {
                        Console.WriteLine("No Records avaible");
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void GetDataWithinTimePeriod(DateTime FromDate, DateTime ToDate)
        {
            try
            {
                using (this.connection)
                {
                    string query = @"select * from  RecordsDB";
                    SqlCommand command = new SqlCommand(query, this.connection);
                    command.CommandType = System.Data.CommandType.Text;
                    this.connection.Open();
                    SqlDataReader read = command.ExecuteReader();
                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            contact.ID = read.GetInt32(0);
                            contact.FirstName = read.GetString(1);
                            contact.LastName = read.GetString(2);
                            contact.Address = read.GetString(3);
                            contact.City = read.GetString(4);
                            contact.State = read.GetString(5);
                            contact.zip = read.GetString(6);
                            contact.PhoneNumber = read.GetString(7);
                            contact.Email = read.GetString(8);
                            contact.StartDate = read.GetDateTime(9);
                            if (contact.StartDate >= FromDate && contact.StartDate <= ToDate)
                                Console.WriteLine(contact.ID + "\n" + contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.zip + "\n" + contact.PhoneNumber + "\n" + contact.Email + "\n" + contact.StartDate);
                        }

                    }
                    else
                    {
                        Console.WriteLine("No Records avaible");
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void RetriveDataByCity(string city)
        {
            try
            {
                using (this.connection)
                {
                    string query = @"select * from  RecordsDB";
                    SqlCommand command = new SqlCommand(query, this.connection);
                    command.CommandType = System.Data.CommandType.Text;
                    this.connection.Open();
                    SqlDataReader read = command.ExecuteReader();
                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            contact.ID = read.GetInt32(0);
                            contact.FirstName = read.GetString(1);
                            contact.LastName = read.GetString(2);
                            contact.Address = read.GetString(3);
                            contact.City = read.GetString(4);
                            contact.State = read.GetString(5);
                            contact.zip = read.GetString(6);
                            contact.PhoneNumber = read.GetString(7);
                            contact.Email = read.GetString(8);
                            contact.StartDate = read.GetDateTime(9);
                            if (contact.City.Equals(city))
                                Console.WriteLine(contact.ID + "\n" + contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.zip + "\n" + contact.PhoneNumber + "\n" + contact.Email + "\n" + contact.StartDate);
                        }

                    }
                    else
                    {
                        Console.WriteLine("No Records avaible");
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void RetriveDataByState(string State)
        {
            try
            {
                using (this.connection)
                {
                    string query = @"select * from  RecordsDB";
                    SqlCommand command = new SqlCommand(query, this.connection);
                    command.CommandType = System.Data.CommandType.Text;
                    this.connection.Open();
                    SqlDataReader read = command.ExecuteReader();
                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            contact.ID = read.GetInt32(0);
                            contact.FirstName = read.GetString(1);
                            contact.LastName = read.GetString(2);
                            contact.Address = read.GetString(3);
                            contact.City = read.GetString(4);
                            contact.State = read.GetString(5);
                            contact.zip = read.GetString(6);
                            contact.PhoneNumber = read.GetString(7);
                            contact.Email = read.GetString(8);
                            contact.StartDate = read.GetDateTime(9);
                            if (contact.City.Equals(State))
                                Console.WriteLine(contact.ID + "\n" + contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.zip + "\n" + contact.PhoneNumber + "\n" + contact.Email + "\n" + contact.StartDate);
                        }

                    }
                    else
                    {
                        Console.WriteLine("No Records avaible");
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void AddEmployee(Contacts contact)
        {
            using (this.connection)
            {

                SqlCommand command = new SqlCommand("AddData", this.connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@FirstName", contact.FirstName);
                command.Parameters.AddWithValue("@LastName", contact.LastName);
                command.Parameters.AddWithValue("@Adresss", contact.Address);
                command.Parameters.AddWithValue("@City", contact.City);
                command.Parameters.AddWithValue("@State", contact.State);
                command.Parameters.AddWithValue("@zip", contact.zip);
                command.Parameters.AddWithValue("@Phone", contact.PhoneNumber);
                command.Parameters.AddWithValue("@Email", contact.Email);
                this.connection.Open();
                var result = command.ExecuteNonQuery();
                this.connection.Close();
                if (result != 0)
                {
                    Console.WriteLine("Employee Added Sucessfully");
                }
                else
                {
                    Console.WriteLine("Employee Added UnSucessfully");
                }

            }
        }
        public void DeleteData(int id)
        {
            using (this.connection)
            {

                SqlCommand command = new SqlCommand("DeleteData", this.connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", id);
                this.connection.Open();
                var result = command.ExecuteNonQuery();
                this.connection.Close();
                if (result != 0)
                {
                    Console.WriteLine("Employee deleted Sucessfully");
                }
                else
                {
                    Console.WriteLine("Employee deleted UnSucessfully");
                }


            }
        }
        public void UpdateData(int id, string Email)
        {
            using (this.connection)
            {

                SqlCommand command = new SqlCommand("UpdateData", this.connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmpId", id);
                command.Parameters.AddWithValue("@Email", Email);
                this.connection.Open();
                var result = command.ExecuteNonQuery();
                this.connection.Close();
                if (result != 0)
                {
                    Console.WriteLine("Employee Updated Sucessfully");
                }
                else
                {
                    Console.WriteLine("Employee Updated  UnSucessfully");
                }


            }
        }
    }
}
