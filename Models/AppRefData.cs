using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class AppRefData
    {
        public int KeyId { get; set; }
        public string KeyName { get; set; }
        public string CustomerName { get; set; }
        public string ProjectName { get; set; }
        public string ProjectId { get; set; }
        public List<AppRefData> ProjectInfo { get; set; }
        
    }

    public class Projlist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
    }
}