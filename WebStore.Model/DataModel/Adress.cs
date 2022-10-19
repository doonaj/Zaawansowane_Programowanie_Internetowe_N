using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace WebStore.Model.DataModel;

public class Address
{
    public int Id { get; set; }
    public string StreetName { get; set; } = default!;
    public int StreetNumber { get; set; } = default!;
    public string City { get; set; } = default!;
    public string PostCode { get; set; } = default!;
}