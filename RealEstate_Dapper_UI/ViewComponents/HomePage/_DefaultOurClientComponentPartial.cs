using Microsoft.AspNetCore.Mvc;
using NuGet.Versioning;

namespace RealEstate_Dapper_UI.ViewComponents.HomePage
{
    public class _DefaultOurClientComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
