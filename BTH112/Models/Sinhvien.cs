using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTH112.Models;
public class Sinhvien
{
    [Key]
    [Display(Name ="Tên Sinh Viên")]
    public string tensv{get;set;}

    [Display(Name ="Mã Sinh Viên")]
    public string masv{get;set;}

    [Display(Name ="Tên Lớp")]
    public string tenlop{get;set;}

    [ForeignKey("tenlop")]
    public Lophoc? Lophoc {get;set;}

}