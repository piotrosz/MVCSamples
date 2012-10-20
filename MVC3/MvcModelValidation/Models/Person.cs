using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcModelValidation.Validation;
using System.ComponentModel.DataAnnotations;

namespace MvcModelValidation.Models
{
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    [Required(ErrorMessage="PESEL jest obowiązkowy")]
    [PeselValidation(ErrorMessage="PESEL jest nieprawidłowy")]
    public string Pesel { get; set; }

    [NipValidation(ErrorMessage="NIP jest nieprawidłowy")]
    public string Nip { get; set; }
}
}