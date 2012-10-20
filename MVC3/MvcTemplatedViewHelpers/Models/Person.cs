using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcTemplatedViewHelpers.Models
{
    [DisplayName("Person details")]
    public class Person
    {
        // DisplayValue=false - nie wyświetla wartości (tylko pole ukryte)
        // ScaffoldColumn(false) - całkowite pomijanie tej właściwości (nie będzie pola ukrytego)
        // Scaffold column jest brane pod uwagę przy tworzeniu widoku dla całego modelu (nie dla pojedynczych właściwości)
        [HiddenInput(DisplayValue=false)]
        public int PersonId { get; set; }

        //[UIHint("MultilineText")]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Date of birth")]
        public DateTime BirthDate { get; set; }
        public Address HomeAddress { get; set; }

        [AdditionalMetadata("RenderList", "true")]
        [UIHint("Bool")]
        public bool? IsApproved { get; set; }

        [UIHint("Enum")]
        public Role Role { get; set; }
    }
}