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
    }
}