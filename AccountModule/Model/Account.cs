using System.Security.Principal;

namespace AccountModule.Model
{
   
    public class Account
    {
        public long Account_number { get; set; }

        public string? Account_holdername { get; set; }

        public string? Account_type { get; set; }

        public long Balance_amount { get; set; }

        public long Mobile_no { get; set; }


    }
}
