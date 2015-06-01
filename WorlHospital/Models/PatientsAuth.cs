using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace WorlHospital.Models
{
    public class PatientsAuth
    {
        [Key]
        [Required]
        public string PatientID { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
    public class PatientRegistration
    {
        [Key]
        public string PID { get; set; }
        [Required]
        public string PName{get;set;}
        [Required]
        public string PFName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string PAge { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public string DOB { get; set; }
        [Required]
        public string BGroup { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string MNumber { get; set; }
    }
    public class patientRegLogContext : DbContext
    {
        public patientRegLogContext( )
            : base( "DefaultConnection" )
        {

        }
        public DbSet<PatientsAuth> PatientLogin { get; set; }
        public DbSet<PatientRegistration> PatientDetails { get; set; }
        public DbSet<Locations> Location { get; set; }
    }
    public class Locations
    {
        [Required]
        [Key]
        public string StateID { get; set; }
        [Required]
        public string state { get; set; }
        [Required]
        public string country { get; set; }
    }
   
}