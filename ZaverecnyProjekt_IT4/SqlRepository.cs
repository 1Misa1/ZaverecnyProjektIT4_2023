﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaverecnyProjekt_IT4
{
    public class SqlRepository
    {
        private static string connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MainData;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        public static SqlConnection Connect()
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            return conn;

        }

        // čtení zaměstnanců z tabulky
        public static List<Employee> EmployeeList()
        {
            SqlConnection conn = Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Employees";
            SqlDataReader reader = cmd.ExecuteReader();
            List<Employee> employee = new List<Employee>();
            while (reader.Read())
            {
                employee.Add(new Employee(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetString(4), reader.GetString(5)));
            }
            reader.Close();
            conn.Close();
            return employee;
        }

        // mazání zaměstnanců
        public static void DeleteEmployeebyId(int id)
        {
            SqlConnection conn = Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Employees WHERE Id=@id";
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // přidávání zaměstnanců
        public static void AddEmployee(Employee employee)
        {
            SqlConnection conn = Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Employees (FirstName, LastName, BirthDate, Email, PhoneNumber) VALUES (@firstname, @lastname, @birthdate, @email, @phonenumber)";
            cmd.Parameters.AddWithValue("firstname", employee.FirstName);
            cmd.Parameters.AddWithValue("lastname", employee.LastName);
            cmd.Parameters.AddWithValue("birthdate", employee.BirthDate);
            cmd.Parameters.AddWithValue("email", employee.Email);
            cmd.Parameters.AddWithValue("phonenumber", employee.PhoneNumber);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // editace zaměstnanců
        public static void EditEmployee(int id, Employee employee)
        {
            SqlConnection conn = Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Employees SET FirstName=@firstname, LastName=@lastname, BirthDate=@birthdate, Email=@email, PhoneNumber=@phonenumber WHERE id=@id";
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("firstname", employee.FirstName);
            cmd.Parameters.AddWithValue("lastname", employee.LastName);
            cmd.Parameters.AddWithValue("birthdate", employee.BirthDate);
            cmd.Parameters.AddWithValue("email", employee.Email);
            cmd.Parameters.AddWithValue("phonenumber", employee.PhoneNumber);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // čtení contractu z tabulky
        public static List<Contract> ContractList()
        {
            SqlConnection conn = Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Contract";
            SqlDataReader reader = cmd.ExecuteReader();
            List<Contract> contracts = new List<Contract>();
            while (reader.Read())
            {
                contracts.Add(new Contract(reader.GetInt32(0),reader.GetString(1), reader.GetString(2)));
            }
            reader.Close();
            conn.Close();
            return contracts;
        }

        // přidávání do contactu 

        public static void AddContract(Contract contract)
        {
            SqlConnection conn = Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Contract (Customer, Description) VALUES (@customer, @description)";
            cmd.Parameters.AddWithValue("customer", contract.Customer);
            cmd.Parameters.AddWithValue("description", contract.Description);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // editování contractu
        public static void EditContract(int id, Contract contract)
        {
            SqlConnection conn = Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Contract SET Customer=@customer, Description=@description WHERE id=@id";
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("customer", contract.Customer);
            cmd.Parameters.AddWithValue("description", contract.Description);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //mazání contractu
        public static void DeleteContractbyId(int id)
        {
            SqlConnection conn = Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Contract WHERE Id=@id";
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // načtení dat z worktypes tabulky 
        public static List<WorkType> WorktypeList()

        {
            SqlConnection conn = Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Worktypes";
            SqlDataReader reader = cmd.ExecuteReader();
            List<WorkType> worktype = new List<WorkType>();
            while (reader.Read())
            {
                worktype.Add(new WorkType(reader.GetInt32(0),reader.GetString(1), reader.GetString(2)));
            }
            reader.Close();
            conn.Close();
            return worktype;
        }

        // přidávíní do tabulky worktype
        public static void AddWorktype(WorkType worktype)
        {
            SqlConnection conn = Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Worktypes (Name, Description) VALUES (@name, @description)";
            cmd.Parameters.AddWithValue("name", worktype.Name);
            cmd.Parameters.AddWithValue("description", worktype.Description);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // editování v tabulce worktype
        public static void EditWorktype(int id, WorkType worktype)
        {
            SqlConnection conn = Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Worktypes SET Name=@name, Description=@description WHERE id=@id";
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("name", worktype.Name);
            cmd.Parameters.AddWithValue("description", worktype.Description);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // mazání z tabulky worktype
        public static void DeleteWorktypebyId(int id)
        {
            SqlConnection conn = Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Worktypes WHERE Id=@id";
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static List<WorkHours> WorkhoursList()
        {
            SqlConnection conn = Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "";
            SqlDataReader reader = cmd.ExecuteReader();
            List<WorkHours> workhours = new List<WorkHours>();
            while (reader.Read())
            {

            }
            reader.Close();
            conn.Close();
            return workhours;
        }
    }
}

