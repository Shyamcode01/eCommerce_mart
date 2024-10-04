using e_commerInventry.Models.product_model;
using System.ComponentModel.DataAnnotations;

namespace e_commerInventry.Models.ViewModel
{
    public class SubCategoryViewModel
    {

        public int Id { get; set; }
      
        public string Title { get; set; }
        public int CategoryId { get; set; }
       
    }
}
