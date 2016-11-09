using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutomatedTellerMachine.Models
{
    public class CheckingAccount
    {
        //Random comment for testing git
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Balance { get; set; }
        public virtual ApplicationUser User { get; set; }   //This SHOULD be the fk
        public string ApplicatinUserID { get; set; }

    }
}