using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Shopp.Data.Models
{
    public class User
    {
        [BindNever]
        public int id { get; set; }
        [Display(Name = "Введіть ім'я")]
        [StringLength(25)]
        [Required(ErrorMessage = "Довжина ім'я не менше 5 символів")]
        public string name { get; set; }
        [Display(Name = "Введіть прізвище")]
        [StringLength(25)]
        [Required(ErrorMessage = "Довжина прізвища не менше 5 символів")]
        public string surname { get; set; }
        [Display(Name = "Введіть адресу для доставки замовлення")]
        [StringLength(35)]
        [Required(ErrorMessage = "Довжина адреси не менше 15 символів")]
        public string address { get; set; }
        [Display(Name = "Введіть номер телефону")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(20)]
        [Required(ErrorMessage = "Довжина номера не менше 10 символів")]
        public string phone { get; set; }
        [Display(Name = "Введіть електронну пошту")]
        [StringLength(25)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Довжина email не менше 15 символів")]
        public string email { get; set; }

        [Display(Name = "Придумайте пароль")]
        [StringLength(25)]
        [DataType(DataType.Password )]
        [Required(ErrorMessage = "Довжина паролю не менше 4 символів")]
        public string password { get; set; }

        public static string readyMail;

        public static void setReadyMail(string m) {
            readyMail = m;
        }

        public static string getRMail() { 
            return readyMail;
        }


    }
}
