using Absensi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Absensi.Pages
{
    public class MahasiswaaddModel :PageModel
    {
        [BindProperty]
        public DataMahasiswa Mhs{get; set;}
        public void OnGet(){

        }
        public IActionResult OnPost(){
            ProsesMahasiswa proses=new ProsesMahasiswa();
            if(proses.saveMahasiswa(Mhs)){
                return new RedirectToPageResult("/Mahasiswa");
            }
            return Page();
        }
    }
}