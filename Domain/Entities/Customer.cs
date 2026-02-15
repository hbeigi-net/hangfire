using System.ComponentModel.DataAnnotations;
using Domain.Interfaces;

namespace Domain.Entities;

public class Customer : IEntity
{

    [Display(Name = "Customer Name")]
    public string? CustomerName { get; set; }
    [Display(Name = "Customer No")]
    public int ID { get; set; }
    [Display(Name = "Customer Location")]
    public string? CustomerLocation { get; set; }
}
