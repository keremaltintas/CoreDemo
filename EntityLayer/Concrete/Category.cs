using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        //erişim belirleyici türü-değiken türü- isim {get set}

        public int CategryID { get; set; }  
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        //Silmek yerine kategori aktif mi pasif  mi diye kullanıcaz.
        public bool CategoryStatus { get; set; }
        
    }
}
