using System.ComponentModel.DataAnnotations;

namespace BTH112.Models;
public class Lophoc
{
    [Key]
    [Display(Name ="Mã Lớp")]
    public string malop{get;set;}

    [Display(Name ="Tên Lớp")]
    public string tenlop{get;set;}

    
}