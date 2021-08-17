﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using WebApplication2.Models;

namespace WebApplication2.Repository
{
    public class common
    {
        private SqlConnection con;



        private void Connection()
        {
            string _conString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            con = new SqlConnection(_conString);

        }

        public List<AppRefData> GetAppRefData(int parentId)
        {
            List<AppRefData> appRefDataList = new List<AppRefData>();
            Connection();
            SqlCommand cmd = new SqlCommand("GetAppRefData_Training_Nisarg", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@parentId", SqlDbType.Int);
            cmd.Parameters["@parentId"].Value = parentId;
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                appRefDataList.Add(
                    new AppRefData { KeyId = Convert.ToInt32(reader["KeyId"]), KeyName = reader["KeyName"].ToString() }
                    );
            }

            reader.Close();
            con.Close();

            return appRefDataList;
        }

        public List<Projlist> GetRecr()
        {
            List<Projlist> appRefDataList = new List<Projlist>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_ActRec_Nisarg", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                appRefDataList.Add(
                    new Projlist { Id = Convert.ToInt32(reader["EmployeeDetails_Id"]), Name = reader["Full_Name"].ToString() }
                    );
            }

            reader.Close();
            con.Close();

            return appRefDataList;
        }
            public List<Projlist> GetLocation()
            {
                List<Projlist> appRefDataList = new List<Projlist>();
                Connection();
                SqlCommand cmd = new SqlCommand("Get_LocationGroup_Nisarg", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    appRefDataList.Add(
                        new Projlist { Id = Convert.ToInt32(reader["LOCATION_ID"]), Name = reader["LOCATION_NAME"].ToString() }
                        );
                }

                reader.Close();
                con.Close();

                return appRefDataList;

            }
        public List<Projlist> GetTimesheet()
        {
            List<Projlist> appRefDataList = new List<Projlist>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_TimesheetRep_Nisarg", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                appRefDataList.Add(
                    new Projlist { Id = Convert.ToInt32(reader["EmployeeDetails_Id"]), Name = reader["TimeSheetRepresentative"].ToString() }
                    );
            }

            reader.Close();
            con.Close();

            return appRefDataList;

        }

        public List<Projlist> GetDomain()
        {
            List<Projlist> appRefDataList = new List<Projlist>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_SubDomain_Nisarg", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                appRefDataList.Add(
                    new Projlist { Id = Convert.ToInt32(reader["KeyId"]), Name = reader["KeyName"].ToString() }
                    );
            }

            reader.Close();
            con.Close();

            return appRefDataList;

        }

        public List<Projlist> GetSalesper()
        {
            List<Projlist> appRefDataList = new List<Projlist>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_SalesPerson_Nisarg", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                appRefDataList.Add(
                    new Projlist { Id = Convert.ToInt32(reader["EmployeeDetails_Id"]), Name = reader["SalesPerson"].ToString() }
                    );
            }

            reader.Close();
            con.Close();

            return appRefDataList;

        }

        public List<Projlist> GetPayrollState()
        {
            List<Projlist> appRefDataList = new List<Projlist>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_PayrollState_Nisarg", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                appRefDataList.Add(
                    new Projlist { Id = Convert.ToInt32(reader["State_Id"]), Name = reader["Payroll_State"].ToString() }
                    );
            }

            reader.Close();
            con.Close();

            return appRefDataList;

        }
    }
}