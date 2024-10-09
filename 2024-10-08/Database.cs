using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace _2024_10_08
{
    public static class Database
    {
        static MySqlConnection Connection;
        public static void OpenConnection()
        {
            string host = "localhost";
            string user = "root";
            string password = "";
            Connection = new MySqlConnection($"Host={host};User={user};Password={password}");
            try
            {
                Connection.Open();
                new MySqlCommand("CREATE DATABASE IF NOT EXISTS `cats`", Connection).ExecuteNonQuery();
                new MySqlCommand("USE `cats`", Connection).ExecuteNonQuery();
                new MySqlCommand("CREATE TABLE IF NOT EXISTS `cats` (`id` INT AUTO_INCREMENT PRIMARY KEY, `name` VARCHAR(50), `age` INT)", Connection).ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ShowError(e);
            }
        }
        static void ShowError(Exception e) => MessageBox.Show(e.Message, "Database error");
        public static List<Cat> GetCats()
        {
            List<Cat> cats = new List<Cat>();
            try
            {
                MySqlDataReader reader = new MySqlCommand("SELECT * FROM `cats`", Connection).ExecuteReader();
                while (reader.Read()) cats.Add(new Cat
                {
                    Id = reader.GetInt32("id"),
                    Name = reader.GetString("name"),
                    Age = reader.GetInt32("age")
                });
                reader.Close();
            }
            catch (Exception e)
            {
                ShowError(e);
            }
            return cats;
        }
        public static void DeleteById(int id)
        {
            try
            {
                new MySqlCommand($"DELETE FROM `cats` WHERE `id`={id}", Connection).ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ShowError(e);
            }
        }
        public static void DeleteAll()
        {
            try
            {
                new MySqlCommand($"DELETE FROM `cats`", Connection).ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ShowError(e);
            }
        }
        public static void InsertCat(Cat cat)
        {
            try
            {
                new MySqlCommand($"INSERT INTO `cats` (`name`, `age`) VALUES ('{cat.Name}', {cat.Age})", Connection).ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ShowError(e);
            }
        }
        public static void UpdateCat(Cat cat)
        {
            try
            {
                new MySqlCommand($"UPDATE `cats` SET `name`='{cat.Name}', `age`={cat.Age} WHERE `id`={cat.Id}", Connection).ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ShowError(e);
            }
        }
    }
}
