using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text;

namespace CharityApp.Core
{
    public class Organization
    {
        
        public Guid Id { get; set; }

        
        public string NpoName { get; set; }

        
        public string NpoRegNumber { get; set; }

        
        public string TypeOfOrganization { get; set; }

        
        public string RegistrationStatus { get; set; }

        
        public DateTime? DateRegistered { get; set; }
        
        public string Sector { get; set; }

        
        public string Objective { get; set; }
        
        public string Theme { get; set; }
        
        public string Description { get; set; }
        
        public string TypeofDeregistration { get; set; }
        

        public string FinancialYearEnd { get; set; }

        
        public DateTime? DueDate { get; set; }
        
        public bool Active { get; set; }
        
        public DateTime CreatedOnUtc { get; set; }
        
        public DateTime? UpdatedOnUtc { get; set; }

    }

}
