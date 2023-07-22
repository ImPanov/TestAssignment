using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Packet.Shared;
using System.ComponentModel.DataAnnotations;

namespace TestAssignment.Pages
{
    public class CompanyDetailsModel : PageModel
    {
        [BindProperty]
        public InputEmployeeModel InputEmployee { get; set; }
        public class InputEmployeeModel
        {
            [Required]
            [Display(Name = "FirstName" )]
            public string FirstName { get; set; }
            [Required]
            [Display(Name = "LastName")]
            public string LastName { get; set; }
            [Required]
            [Display(Name = "Title")]
            public string Title { get; set; }
            [Required]
            [Display(Name = "BirthDate")]
            public string BirthDate { get; set; }
            [Required]
            [Display(Name = "Position")]
            public string Position { get; set; }
        }
        [BindProperty]
        public InputCompanyModel InputCompany { get; set; }
        public class InputCompanyModel
        {
            [Required]
            [Display(Name = "ID" )]
            public string Id { get; set; }
            [Required]
            [Display(Name = "Name")]
            public string Name { get; set; }
            [Required]
            [Display(Name = "Address")]
            public string Address { get; set; }
            [Required]
            [Display(Name = "City")]
            public string City { get; set; }
            [Required]
            [Display(Name = "State")]
            public string State { get; set; }
        }
        

        private readonly ApplicationDbContext db;
        public Company? company;
        public CompanyDetailsModel(ApplicationDbContext injectContext)
        {
            db = injectContext;
        }
        public void OnGet(int? Id)
        {
            company = db.Companies.Include(c=>c.Notes).Include(c=>c.Employees).Include(c=>c.Orders).SingleOrDefault(c=>c.CompanyId==Id);
        }
    }
}
