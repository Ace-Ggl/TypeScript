using System.Web.Mvc;

namespace Interview.Controllers
{
    public interface IRangeController
    {
        ActionResult List(string name);
    }
}
