using System.ComponentModel.DataAnnotations;

public class CourseRegisVm : UserVm
{
    [Required]
    //Select 1 of many course
    public string Course { get; set; }

    [Required]
    //Radio button for Online/Offline
    public string StudyMode { get; set; } = "Online";

    //DatePicker 
    [Required]
    public DateTime PrefStartDate { get; set; } = DateTime.Now;

    //Text area
    public string Comment { get; set; }

    [Required]
    [Range(typeof(bool), "true", "true", ErrorMessage = "You must accept the terms.")]
    public bool Term { get; set; }

}