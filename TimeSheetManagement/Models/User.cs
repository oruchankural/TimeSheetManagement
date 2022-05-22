using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetManagement.Models
{
    public class User
    {

        /*------------------ Error Message ları validasyon mesajları olarak girin , asp-validation-for da kullanacağız size bırakıyorum bu tarafı veya client-side validation
         yapılabilir FluentValidation vs ------------------*/
        [Key]
        public int user_id { get; set; }

        [MaxLength(110, ErrorMessage = "")]
        public string mail { get; set; }

        [MaxLength(200, ErrorMessage = "")]
        public string password { get; set; }
    }
}
