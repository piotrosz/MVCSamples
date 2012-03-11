using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcModelBinding.Models
{
    //[Bind(Exclude="IsApproved")]
    public class Person
    {
        [HiddenInput(DisplayValue = false)]
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public Address HomeAddress { get; set; }
        public bool? IsApproved { get; set; }
        public Role Role { get; set; }

        public string Letter { get; set; }

        public List<string> Letters = new List<string>() { "", "A", "B", "C" };
    }
}