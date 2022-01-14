using System.ComponentModel.DataAnnotations;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        
        [Required(ErrorMessage = "Name is Required")]
        public  string Name { get; set; }
        [Required(ErrorMessage = "Location is Required")]
        public string Location { get; set; }

        public AddEmployerViewModel(string name, string location)
        {
            Name = name;
            Location = location;
        }
        public AddEmployerViewModel()
        {

        }
    }
}
