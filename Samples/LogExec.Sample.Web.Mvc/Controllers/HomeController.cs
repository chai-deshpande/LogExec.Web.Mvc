using System.Threading;
using System.Web.Mvc;
using LogExec.Web.Mvc;

namespace LogExec.Sample.Web.Mvc.Controllers
{
  /// <summary>
  /// This will log the execution time for all the actions within this controller.
  /// </summary>
  [LogExecTime]
  public class HomeController : Controller
  {
    //
    // GET: /Home/
    public ActionResult Index()
    {
      // Dummy work.
      Thread.Sleep(245);
      return View();
    }

  }
}
