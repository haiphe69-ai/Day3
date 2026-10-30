using System.ComponentModel.DataAnnotations;

namespace Day3.Models
{
    public class Category_Id_Name_
    {
        [Required(ErrorMessage = "Id is required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100,MinimumLength =2 , ErrorMessage = "Name cannot be longer than 100 characters")]
        public string Name { get; set; }

    }
}
