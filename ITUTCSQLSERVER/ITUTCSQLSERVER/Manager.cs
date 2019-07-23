﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ITUTCSQLSERVER
{
    class Manager
    {
        public static void Query(string Command)
        {
            Database.Connection.Open();
            SqlCommand cmd = new SqlCommand(Command, Database.Connection);
            cmd.ExecuteNonQuery();
            Database.Connection.Close();
        }
        public static void InsertActivity(string ACTIVITY_ID, string ACTIVITY_NAME, string ACTIVITY_DATE, string ACTIVITY_STATUS)
        {
            try
            {
                Database.Connection.Open();
                string sqlCommand = @"INSERT INTO tbActivity(ACTIVITY_ID,ACTIVITY_NAME,ACTIVITY_DATE,ACTIVITY_STATUS) VALUES(@ACTIVITY_ID,@ACTIVITY_NAME,@ACTIVITY_DATE,@ACTIVITY_STATUS)";
                SqlCommand Command = new SqlCommand(sqlCommand, Database.Connection);
                Command.Prepare();
                Command.Parameters.AddWithValue("@ACTIVITY_ID", ACTIVITY_ID);
                Command.Parameters.AddWithValue("@ACTIVITY_NAME", ACTIVITY_NAME);
                Command.Parameters.AddWithValue("@ACTIVITY_DATE", ACTIVITY_DATE);
                Command.Parameters.AddWithValue("@ACTIVITY_STATUS", ACTIVITY_STATUS);
                Command.ExecuteNonQuery();

                

            }
            finally
            {
                Database.Connection.Close();
            }
        }
        public static void UpdateActivity(string ACTIVITY_ID, string ACTIVITY_NAME, string ACTIVITY_DATE, string ACTIVITY_STATUS)
        {
            try
            {
                Database.Connection.Open();
                string sqlCommand = "UPDATE tbActivity SET ACTIVITY_NAME=@ACTIVITY_NAME,ACTIVITY_DATE=@ACTIVITY_DATE,ACTIVITY_STATUS=@ACTIVITY_STATUS WHERE ACTIVITY_ID='" + @ACTIVITY_ID + "'";
                SqlCommand Command = new SqlCommand(sqlCommand, Database.Connection);
                Command.Prepare();
                Command.Parameters.AddWithValue("@ACTIVITY_ID", ACTIVITY_ID);
                Command.Parameters.AddWithValue("@ACTIVITY_NAME", ACTIVITY_NAME);
                Command.Parameters.AddWithValue("@ACTIVITY_DATE", ACTIVITY_DATE);
                Command.Parameters.AddWithValue("@ACTIVITY_STATUS", ACTIVITY_STATUS);
                Command.ExecuteNonQuery();
            }
            finally
            {
                Database.Connection.Close();
            }
        }
        public static void DeleteActivity(string ACTIVITY_ID)
        {
            try
            {
                Database.Connection.Open();
                string sqlCommand = @"DELETE FROM tbActivity WHERE ACTIVITY_ID=@ACTIVITY_ID";
                SqlCommand Command = new SqlCommand(sqlCommand, Database.Connection);
                Command.Prepare();
                Command.Parameters.AddWithValue("@ACTIVITY_ID", ACTIVITY_ID);
                Command.ExecuteNonQuery();
            }
            finally
            {
                Database.Connection.Close();
            }
        }
        public static void InsertStudent(string STUDENT_NAME, string STUDENT_LASTNAME, string STUDENT_TEL)
        {
            try
            {
                Database.Connection.Open();
                string sqlCommand = @"INSERT INTO tbStudent(STUDENT_NAME,STUDENT_LASTNAME,STUDENT_TEL) VALUES(@STUDENT_NAME,@STUDENT_LASTNAME,@STUDENT_TEL)";
                SqlCommand Command = new SqlCommand(sqlCommand, Database.Connection);
                Command.Prepare();
                Command.Parameters.AddWithValue("@STUDENT_NAME", STUDENT_NAME);
                Command.Parameters.AddWithValue("@STUDENT_LASTNAME", STUDENT_LASTNAME);
                Command.Parameters.AddWithValue("@STUDENT_TEL", STUDENT_TEL);
                Command.ExecuteNonQuery();
            }
            finally
            {
                Database.Connection.Close();
            }
        }
        public static void UpdateStudent(string STUDENT_NAME, string STUDENT_LASTNAME, string STUDENT_TEL)
        {
            try
            {
                Database.Connection.Open();
                string sqlCommand = "UPDATE tbStudent SET STUDENT_LASTNAME=@STUDENT_LASTNAME,STUDENT_TEL=@STUDENT_TEL WHERE STUDENT_NAME='" + STUDENT_NAME + "'";
                SqlCommand Command = new SqlCommand(sqlCommand, Database.Connection);
                Command.Prepare();
                Command.Parameters.AddWithValue("@STUDENT_NAME", STUDENT_NAME);
                Command.Parameters.AddWithValue("@STUDENT_LASTNAME", STUDENT_LASTNAME);
                Command.Parameters.AddWithValue("@STUDENT_TEL", STUDENT_TEL);
                Command.ExecuteNonQuery();
            }
            finally
            {
                Database.Connection.Close();
            }
        }
        public static void DeleteStudent(string STUDENT_NAME)
        {
            try
            {
                Database.Connection.Open();
                string sqlCommand = @"DELETE FROM tbStudent WHERE STUDENT_NAME=@STUDENT_NAME";
                SqlCommand Command = new SqlCommand(sqlCommand, Database.Connection);
                Command.Prepare();
                Command.Parameters.AddWithValue("@STUDENT_NAME", STUDENT_NAME);
                Command.ExecuteNonQuery();
            }
            finally
            {
                Database.Connection.Close();
            }
        }
    }
}
