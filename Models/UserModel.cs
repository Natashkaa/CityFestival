using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;


namespace CoreRegSite.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Поле не должно быть пустым")]
        [DataType(DataType.Text)]
        [EmailAddress(ErrorMessage = "Укажите, пожалуйста, корректный email")]
        [RegularExpression(@".+\@gmail.com", ErrorMessage = "Укажите, пожалуйста, корректный email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле не должно быть пустым")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Поле не должно быть пустым")]
        [DataType(DataType.Text)]
        public string SecondName { get; set; }

        [Required(ErrorMessage = "Поле не должно быть пустым")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\+380\d{9}$", ErrorMessage = "Укажите, пожалуйста, корректный номер телефона")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Поле не должно быть пустым")]
        public string Activity { get; set; }
    }
}