﻿using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackTUES3
{
    public static class MySQLFunctions
    {
        static private MySqlConnection connection = new MySqlConnection("server=85.11.180.238;port=3307;database=mikrosoft;uid=mikrosoft;pwd=mikrosoft123;");

        static public void RefreshAcc(DataGridView dataGridView)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM accounts", connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        static public void InsertUser(string userName, string password, int _prms)//, DataGridView dataGridView)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand cmdInsrt = new MySqlCommand("INSERT INTO accounts(username,password,permission) VALUES(@username,@password,@prms)", connection);
                cmdInsrt.Parameters.AddWithValue("@username", userName);
                cmdInsrt.Parameters.AddWithValue("@password", password);
                cmdInsrt.Parameters.AddWithValue("@prms", _prms);
                //cmdInsrt.Parameters.AddWithValue("@permission",0);
                cmdInsrt.ExecuteNonQuery();
                cmdInsrt.Parameters.Clear();
                MessageBox.Show("Your account has been successfully added!", "Login Successful!");
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        static public int FindUser(string username, string password)
        {
            int result = -1;
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand cmdSelect = new MySqlCommand("SELECT * FROM accounts WHERE username = @username AND password = @password", connection);
                cmdSelect.Parameters.AddWithValue("@username", username);
                cmdSelect.Parameters.AddWithValue("@password", password);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmdSelect);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0) result = (int)dataTable.Rows[0]["permission"];
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
        static public void ChangePerms(string username, int perms_to)
        {
            try
            {
                if (perms_to < 3 && perms_to >= 0)
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    MySqlCommand cmdChange = new MySqlCommand("UPDATE mikrosoft.accounts SET permission = @perms_to WHERE accounts.username = @username", connection);
                    cmdChange.Parameters.AddWithValue("@username", username);
                    cmdChange.Parameters.AddWithValue("@perms_to", perms_to);
                    cmdChange.ExecuteNonQuery();
                    cmdChange.Parameters.Clear();
                    MessageBox.Show("Permission elevated successfully!", "Done!");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Error!");
            }
        }

        static public void GetDataTable(int Class, int type, DataGridView dgv)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand cmdInsrt = new MySqlCommand("CALL join1(" + Class.ToString() + "," + type.ToString() + ")", connection);
                //cmdInsrt.CommandType = CommandType.StoredProcedure;
                // cmdInsrt.Parameters.AddWithValue("@type",type);
                //  cmdInsrt.Parameters.AddWithValue("@class",Class);
                MySqlDataAdapter msdt = new MySqlDataAdapter(cmdInsrt);
                DataSet dt = new DataSet();
                msdt.Fill(dt);
                dgv.DataSource = dt.Tables[0];

                dgv.Refresh();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
/* 
SELECT * FROM `Calendar`
INNER JOIN `subject` ON `subjectID` = `subject`.`id`
INNER JOIN `classes` ON `classID` = `classes`.`id`
WHERE `classes`.`class` = 9 AND `classes`.`type` = "В"
                                                              */
/*
 * 
 * 
 * */

/*

SELECT `Calendar`.`subjectID`,`subject`.`name` FROM `Calendar`
INNER JOIN `subject` ON `subjectID` = `subject`.`id`
INNER JOIN `classes` ON `classID` = `classes`.`id`
WHERE `classes`.`class` = 9 AND `classes`.`type` = "В"
 * 
 * 
 * 
*/

/*
SELECT `Calendar`.`num_subject`,`Calendar`.`week_day`,`Calendar`.`state`,`subject`.`name` FROM `Calendar`
INNER JOIN `subject` ON `subjectID` = `subject`.`id`
INNER JOIN `classes` ON `classID` = `classes`.`id`
WHERE `classes`.`class` = 9 AND `classes`.`type` = "В"
 
 

*/


/*

SELECT `Calendar`.`num_subject`,`Calendar`.`week_day`,`Calendar`.`state`,`subject`.`name` FROM `Calendar` 
INNER JOIN `subject` ON `subjectID` = `subject`.`id` 
INNER JOIN `classes` ON `classID` = `classes`.`id` 
WHERE `classes`.`class` = 9 AND `classes`.`type` = "В" ORDER BY `Calendar`.`week_day` ASC

SELECT `Calendar`.`num_subject`,`Calendar`.`week_day`,`Calendar`.`state`,`subject`.`name` FROM `Calendar` INNER JOIN `subject` ON `subjectID` = `subject`.`id` INNER JOIN `classes` ON `classID` = `classes`.`id` WHERE `classes`.`class` = 9 AND `classes`.`type` = "В" ORDER BY `Calendar`.`week_day` ASC

*/


/* SELECT * FROM `Calendar`
                                                                INNER JOIN `subject` ON `subjectID` = `subject`.`id`
                                                                INNER JOIN `classes` ON `classID` = `classes`.`id`
                                                                WHERE `classes`.`class` = 9 AND `classes`.`type` = "В"
                                                              */
/*
 * 
 * 
 * */