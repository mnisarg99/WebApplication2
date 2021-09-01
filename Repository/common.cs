using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using WebApplication2.Models;
using System.Web.Mvc;


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

        public List<Projlist> GetPayrollState(int countryId)
        {
            List<Projlist> appRefDataList = new List<Projlist>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_PayrollState_Nisarg", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@countryId", SqlDbType.Int);
            cmd.Parameters["@countryId"].Value = countryId;

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

        public List<Project> GetProjectsList()
        {
            DataSet ds = new DataSet();
            List<Project> SelectListNew = new List<Project>();
            Connection();
            SqlCommand cmd = new SqlCommand("ProjectList_Nisarg_Training", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(ds);
            }
            if (ds.Tables.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Project obj = new Project();
                    obj.CustomerName = Convert.ToString(ds.Tables[0].Rows[i]["CustomerName"]);
                    obj.ProjectName = Convert.ToString(ds.Tables[0].Rows[i]["ProjectName"]);
                    obj.ProjectId = Convert.ToString(ds.Tables[0].Rows[i]["ProjectId"]);
                    obj.StartDate = Convert.ToDateTime(ds.Tables[0].Rows[i]["StartDate"]);
                    obj.EndDate = Convert.ToDateTime(ds.Tables[0].Rows[i]["EndDate"]);
                    obj.ProjectStatus = Convert.ToString(ds.Tables[0].Rows[i]["ProjectStatus"]);
                    obj.LocationGroup = Convert.ToString(ds.Tables[0].Rows[i]["LocationGroup"]);
                    obj.PayrollState = Convert.ToString(ds.Tables[0].Rows[i]["PayRollState"]);
                    obj.SalesPerson = Convert.ToString(ds.Tables[0].Rows[i]["SalesPerson"]);
                    obj.ProjectCategory = Convert.ToString(ds.Tables[0].Rows[i]["ProjectCategory"]);
                    obj.ProjectType = Convert.ToString(ds.Tables[0].Rows[i]["ProjectType"]);
                    obj.SubDomain = Convert.ToString(ds.Tables[0].Rows[i]["SubDomain"]);
                    obj.TimesheetRepresentative = Convert.ToString(ds.Tables[0].Rows[i]["TimeSheetRepresentative"]);
                    obj.ClientInvoiceGroup = Convert.ToString(ds.Tables[0].Rows[i]["ClientInvoiceGroup"]);
                    obj.TimesheetType = Convert.ToString(ds.Tables[0].Rows[i]["TimeSheetType"]);
                    obj.IsVmsTimesheet = Convert.ToString(ds.Tables[0].Rows[i]["IsVMSTimeSheet"]);
                    obj.PracticeType = Convert.ToString(ds.Tables[0].Rows[i]["PracticeType"]);
                    obj.Recruiter = Convert.ToString(ds.Tables[0].Rows[i]["Recruiter"]);
                    SelectListNew.Add(obj);
                }
            }

            return SelectListNew;
        }

        public DataSet GetList(ProjectAddEditViewModel pmodel)
        {



            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ToString());
            SqlCommand cmd = new SqlCommand("ProjectList_Nisarg_Training", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet myrec = new DataSet();
            da.Fill(myrec);
            return myrec;
        }

    }
}