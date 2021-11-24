using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Fullname.Models
{
    public class Name
    {
        public int Id { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Enter Your First Name"), MaxLength(30)]
        [Display(Name = " First Name")]

        public string FirstName { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Enter Your Last Name"), MaxLength(30)]
        [Display(Name = " Last Name")]
        public string LastName { get; set; }
    }
}