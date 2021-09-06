using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Repository
{
    public class DataTab
    {
        
        private SqlConnection con;



        private void Connection()
        {
            string _conString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            con = new SqlConnection(_conString);

        }

        public bool SaveData(Project proj)
        {
            Connection();
            SqlCommand com = new SqlCommand("ProjectDetails_Nisarg_Training", con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@CustomerName", proj.CustomerName);
            com.Parameters.AddWithValue("@ProjectName", proj.ProjectName);
            com.Parameters.AddWithValue("@ProjectId", proj.ProjectId);
            com.Parameters.AddWithValue("@StartDate", proj.StartDate);
            com.Parameters.AddWithValue("@EndDate", proj.EndDate);
            com.Parameters.AddWithValue("@ProjectStatus", proj.ProjectStatus);
            com.Parameters.AddWithValue("@LocationGroup", proj.LocationGroup);
            com.Parameters.AddWithValue("@PayrollState", proj.PayrollState);
            com.Parameters.AddWithValue("@SalesPerson", proj.SalesPerson);
            com.Parameters.AddWithValue("@ProjectCategory", proj.ProjectCategory);
            com.Parameters.AddWithValue("@ProjectType", proj.ProjectType);
            com.Parameters.AddWithValue("@SubDomain", proj.SubDomain);
            com.Parameters.AddWithValue("@TimesheetRepresentative", proj.TimesheetRepresentative);
            com.Parameters.AddWithValue("@ClientInvoiceGroup", proj.ClientInvoiceGroup);
            com.Parameters.AddWithValue("@TimesheetType", proj.TimesheetType);
            com.Parameters.AddWithValue("@IsVmsTimesheet", proj.IsVmsTimesheet);
            com.Parameters.AddWithValue("@PracticeType", proj.PracticeType);
            com.Parameters.AddWithValue("@Recruiter", proj.Recruiter);
            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetProjectData() 
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

            return "Done";
        }
    }
}
