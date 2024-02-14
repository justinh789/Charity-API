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
        [Column("id")]
        public Guid Id { get; set; }

        [Column("npo_name")]
        public string NpoName { get; set; }

        [Column("npo_reg_number")]
        public string NpoRegNumber { get; set; }

        [Column("type_of_organization")]
        public string TypeofOrganization { get; set; }

        [Column("registration_status")]
        public string RegistrationStatus { get; set; }

        [Column("date_registered")]
        public DateTime? DateRegistered { get; set; }
        [Column("sector")]
        public string Sector { get; set; }

        [Column("objective")]
        public string Objective { get; set; }
        [Column("theme")]
        public string Theme { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("type_of_deregistration")]
        public string TypeofDeregistration { get; set; }
        [Column("financial_year_end")]

        public string FinancialYearEnd { get; set; }

        [Column("due_date")]
        public DateTime? DueDate { get; set; }
        [Column("active")]
        public bool Active { get; set; }
        [Column("created_on_utc")]
        public DateTime CreatedOnUtc { get; set; }
        [Column("updated_on_utc")]
        public DateTime? UpdatedOnUtc { get; set; }

    }

}
