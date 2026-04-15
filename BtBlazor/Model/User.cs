using System.ComponentModel.DataAnnotations;

public class UserVm
{
    [Required]
    [MinLength(3)]
    public string FullName { get; set; } = string.Empty;

    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    [Phone]
    [StringLength(12, MinimumLength = 10)]
    public string PhoneNum { get; set; } = string.Empty;
}