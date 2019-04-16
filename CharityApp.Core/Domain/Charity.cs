using System;
using System.Collections.Generic;
using System.Text;

namespace CharityApp.Core
{
    public class Charity
    {
        public int Id { get; set; }

        public string NPO_Name { get; set; }

        public string NPO_Reg_Number { get; set; }

        public string Postal_Address1 { get; set; }

        public string Postal_Address2 { get; set; }

        public string Postal_Address3 { get; set; }

        public string Postal_Town { get; set; }

        public string Postal_Province { get; set; }

        public string Postal_Postal_Code { get; set; }

        public string Primary_Address1 { get; set; }

        public string Primary_Address2 { get; set; }

        public string Primary_Address3 { get; set; }

        public string Primary_Town { get; set; }

        public string Primary_Province { get; set; }

        public string Primary_Postal_Code { get; set; }

        public string Metro { get; set; }

        public string District { get; set; }

        public string Municipality { get; set; }

        public string Contact_Person { get; set; }

        public string Email { get; set; }

        public string Tel { get; set; }

        public string Cell { get; set; }

        public string Fax { get; set; }

        public string Type_of_Organisation { get; set; }

        public string Registration_Status { get; set; }

        public DateTime? Date_Registered { get; set; }

        public string Sector { get; set; }

        public string Objective { get; set; }

        public string Theme { get; set; }

        public string Description { get; set; }

        public string Type_of_Deregistration { get; set; }

        public string Financial_Year_End { get; set; }

        public DateTime? DueDate { get; set; }

        public bool Active { get; set; }

        public decimal? Longitude { get; set; }

        public decimal? Latitude { get; set; }

    }

}
