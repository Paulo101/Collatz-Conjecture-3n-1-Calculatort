using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CollatzConjecture_Group7.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            Sequence = new List<long>();
        }

        public void OnGet()
        {

        }
        
        public long Number { get; set; }
        public long Steps { get; set; }
        public List<long> Sequence { get; set; }
        public long Max { get; set; }
    }
}