using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCQuiz.Models
{
    public class User
    {
        //   F i e l d s   &   P r o p e r t i e s

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }

        //   C o n s t r u c t o r s

        //   M e t h o d s

    }
}
