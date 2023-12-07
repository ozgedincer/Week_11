using System.ComponentModel.DataAnnotations;

namespace Week_11.API.Models
{
    public class GetBankAccountDataResponseModel
    {
        //[Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        //[Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        //[Required(ErrorMessage = "Balance is required")]
        public decimal Balance { get; set; }
    }
}
