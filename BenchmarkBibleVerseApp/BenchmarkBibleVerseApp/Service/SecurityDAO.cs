using BenchmarkBibleVerseApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BenchmarkBibleVerseApp.Service
{
    public class SecurityDAO
    {
        public SecurityDAO() { }

        public bool AddEntryToDb(VerseEntryModel model)
        {
            try
            {
                using(var conn = ConnectToDb())
                {
                    conn.Open();

                    string sql = "Insert into dbo.Verses(BOOKNAME, CHAPTERNUMBER, VERSENUMBER, VERSETEXT) values(@BOOKNAME, @CHAPTERNUMBER, @VERSENUMBER, @VERSETEXT)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("BOOKNAME", model.BookName);
                        cmd.Parameters.AddWithValue("CHAPTERNUMBER", model.ChapterNumber);
                        cmd.Parameters.AddWithValue("VERSENUMBER", model.VerseNumber);
                        cmd.Parameters.AddWithValue("VERSETEXT", model.VerseText);

                        if(cmd.ExecuteNonQuery() > 0)//Success
                        {
                            return true;
                        }
                        else//Fail
                        {
                            return false;
                        }
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }

        public VerseEntryModel SearchEntryFromDb(VerseSearchModel search)
        {
            try
            {
                using(var conn = ConnectToDb())
                {
                    conn.Open();

                    String sql = "Select * from dbo.Verses where BOOKNAME = @BOOKNAME and CHAPTERNUMBER = @CHAPTERNUMBER and VERSENUMBER = @VERSENUMBER";
                    using(SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("BOOKNAME", search.BookName);
                        cmd.Parameters.AddWithValue("CHAPTERNUMBER", search.ChapterNumber);
                        cmd.Parameters.AddWithValue("VERSENUMBER", search.VerseNumber);

                        using(SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow))
                        {
                            if (dr.Read())
                            {
                                VerseEntryModel entry = new VerseEntryModel((String)dr["BookName"], (int)dr["ChapterNumber"], (int)dr["VerseNumber"], (String)dr["VerseText"]);
                                return entry;
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

            return null;
        }


        public SqlConnection ConnectToDb()
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BenchmarkDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            return conn;
        }
    }
}