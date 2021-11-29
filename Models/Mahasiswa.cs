using System;
using System.ComponentModel.DataAnnotations;

namespace Absensi.Models
{
    public class Mahasiswa
    {
        [Required(ErrorMessage="Nama wajib diisi")]
        public string Nama{get; set;}
        public string Kelas{get; set;}
        [Required(ErrorMessage ="Tempat lahir harus diisi")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage ="Tempat lahir hanya huruf")]
        public string TempatLahir{get; set;}
        [DataType(DataType.Date)]
        public DateTime TglLahir{get; set;}
        [Range(100,180,ErrorMessage ="Tinggi badan sampai 100-180")]
        public int tinggibadan{get; set;}
        [RegularExpression("^[0-9]*$")]
        public string Hp{get; set;}
    }
}