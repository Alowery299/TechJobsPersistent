using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        
        public string Name { get; set; }
        public int EmployerId { get; set; }
        public List<SelectListItem> Employers { get; set; }
        public List<Skill>Skills { get; set; }   

       
        public AddJobViewModel()
        {
        }

        public  AddJobViewModel(List<Employer>employerList, List<Skill>employerSkills)
        {
            Employers = new List<SelectListItem>();
            Skills = employerSkills;

            foreach (var employer in employerList)
            {
                Employers.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });
            }

            
        }

        
    }
} 
