using Microsoft.AspNetCore.Mvc.Rendering;

namespace Boxetheus.Models
{
    public class BoxViewDesignModel
    {
        public List<BoxView>? BoxViews { get; set; }
        public SelectList? Design { get; set; }
        public string? BoxDesign { get; set; }
        public string? SearchString { get; set; }
    }
}
