using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace MvCTests.Components
{
    public class TextboxViewComponent : ViewComponent
    {
        public TextboxViewComponent() { }
        
        public IViewComponentResult Invoke(ModelExpression aspFor)
        {
            MvCTests.Models.Components.Textbox.Textbox vm = new Models.Components.Textbox.Textbox 
            {
                Label = aspFor.Metadata.DisplayName,
                Value = (string)aspFor.Model,
                IsRequired = aspFor.Metadata.IsRequired,
                Name = aspFor.Name
            };

            return View(vm);
        }
    }
}