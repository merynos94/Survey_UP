using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SurveyUP.Pages.Roles
{
    public class IndexModel : PageModel
    {

        public IndexModel()
        {
        }

        public List<string> AspNetRoles { get; set; } = new List<string>();

        public void OnGet()
        {
            foreach (var v in Enum.GetValues(typeof(Data.Enums.Roles)))
            {
                AspNetRoles.Add(v.ToString());
            }
        }
    }
}
