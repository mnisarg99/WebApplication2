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

        public bool SaveData(ProjectAddEditViewModel model)
        {
            Connection();
            SqlCommand com = new SqlCommand("ProjectDetails_Nisarg_Training", con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@CustomerName", model.Project.CustomerName);
            com.Parameters.AddWithValue("@ProjectName", model.Project.ProjectName);
            com.Parameters.AddWithValue("@ProjectId", model.Project.ProjectId);
            com.Parameters.AddWithValue("@StartDate", model.Project.StartDate);
            com.Parameters.AddWithValue("@EndDate", model.Project.EndDate);
            com.Parameters.AddWithValue("@ProjectStatus", model.Project.ProjectStatus);
            com.Parameters.AddWithValue("@LocationGroup", model.Project.LocationGroup);
            com.Parameters.AddWithValue("@PayrollState", model.Project.PayrollState);
            com.Parameters.AddWithValue("@SalesPerson", model.Project.SalesPerson);
            com.Parameters.AddWithValue("@ProjectCategory", model.Project.ProjectCategory);
            com.Parameters.AddWithValue("@ProjectType", model.Project.ProjectType);
            com.Parameters.AddWithValue("@SubDomain", model.Project.SubDomain);
            com.Parameters.AddWithValue("@TimesheetRepresentative", model.Project.TimesheetRepresentative);
            com.Parameters.AddWithValue("@ClientInvoiceGroup", model.Project.ClientInvoiceGroup);
            com.Parameters.AddWithValue("@TimesheetType", model.Project.TimesheetType);
            com.Parameters.AddWithValue("@IsVmsTimesheet", model.Project.IsVmsTimesheet);
            com.Parameters.AddWithValue("@PracticeType", model.Project.PracticeType);
            com.Parameters.AddWithValue("@Recruiter", model.Project.Recruiter);
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