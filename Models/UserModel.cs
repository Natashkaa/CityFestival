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
        public int ParticipantId { get; set; }

        [Required(ErrorMessage = "Поле не должно быть пустым")]
        [DataType(DataType.Text)]
        [EmailAddress(ErrorMessage = "Укажите, пожалуйста, корректный email")]
        [RegularExpression(@".+\@gmail.com", ErrorMessage = "Укажите, пожалуйста, корректный email")]
        public string ParticipantEmail { get; set; }

        [Required(ErrorMessage = "Поле не должно быть пустым")]
        [DataType(DataType.Text)]
        public string ParticipantFirstName { get; set; }

        [Required(ErrorMessage = "Поле не должно быть пустым")]
        [DataType(DataType.Text)]
        public string ParticipantSecondName { get; set; }

        [Required(ErrorMessage = "Поле не должно быть пустым")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\+380\d{9}$", ErrorMessage = "Укажите, пожалуйста, корректный номер телефона")]
        public string ParticipantPhone { get; set; }
        [Required(ErrorMessage = "Поле не должно быть пустым")]
        public string ParticipantActivity { get; set; }
    }
}