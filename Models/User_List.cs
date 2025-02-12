using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Panacea_Assignment.Models
{
    public class User_List
    {
        [Key]
        public int Uid { get; set; }
        [Required(ErrorMessage = "The First Name is Required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "The Middle Name is Required")]
        public string MiddleName { get; set; }
        [Required(ErrorMessage = "The Last Name is Required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "The Address is Required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "The Phone Number is Required"), RegularExpression("\\d{10}", ErrorMessage = "Phone number must be a 10-digit number.")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "The Email is Required"), EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "The City is Required")]
        public string City { get; set; }
        [Required(ErrorMessage = "The State is Required")]
        public string State { get; set; }
        [Required(ErrorMessage = "The Pincode is Required"), RegularExpression("\\d{6}", ErrorMessage = "Pin code must be a 6-digit number.")]
        public string PinCode { get; set; }
        [Required(ErrorMessage = "The Username is Required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "The Password is Required"), MinLength(6), RegularExpression("^(?=.*[A-Za-z])(?=.*\\d)(?=.*[@$!%*#?&])[A-Za-z\\d@$!%*#?&]{6,}$", ErrorMessage = "Password must be at least 6 characters long and contain at least one letter, one number, and one special character.")]
        public string Password { get; set; }
     
        public String Status {  get; set; }

    }



}