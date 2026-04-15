using System.ComponentModel.DataAnnotations;

public class CustomerContactVm : UserVm
{
    [MinLength(5)]
    public string? Address { get; set; }

    [Required]
    [MinLength(10)]
    public string Message { get; set; }

    [Required]
    public string Service { get; set; }

    // Term looks like a required agreement; use bool and a custom validation attribute via RequiredTrue below
    [Required]
    [Range(typeof(bool), "true", "true", ErrorMessage = "You must accept the terms.")]
    public bool Term { get; set; }

}