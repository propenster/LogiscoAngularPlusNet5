using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LogicoStartupEngine.Models
{
    public class LogisticCompany
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        [Column(TypeName = "varchar(32)")]
        public string CompanyEmail { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [DataType(DataType.PhoneNumber)]
        [Column(TypeName = "varchar(13)")]
        public string CompanyPhoneNumber { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [Column(TypeName = "varchar(150)")]
        public string CompanyAddress { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [Column(TypeName = "varchar(50)")]
        public string CompanyLocation { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [Column(TypeName = "varchar(max)")]
        public string CompanyDescription { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [Column(TypeName = "varchar(10)")]
        public string CompanyRegistrationNumber { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [Column(TypeName = "varchar(15)")]
        public string CompanyTaxRegistrationNumber { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [DataType(DataType.PhoneNumber)]
        [Column(TypeName = "varchar(13)")]
        public string CompanyReferencePhoneNumber { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        [Column(TypeName = "varchar(32)")]
        public string CompanyReferenceEmail { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [DataType(DataType.Url, ErrorMessage = "Url is not valid")]
        [Column(TypeName = "varchar(2048)")]
        public string CompanyWebsiteURL { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [DataType(DataType.Url, ErrorMessage = "Url is not valid")]
        [Column(TypeName = "varchar(2048)")]
        public string CompanyImageURL { get; set; }



    }
}
