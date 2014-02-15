using System.Threading;
using System.Web.Mvc;
using LogExec.Web.Mvc;

namespace LogExec.Sample.Web.Mvc.Controllers
{
  public class TestController : Controller
  {
    //
    // GET: /Test/
    /// <summary>
    /// This action is not decorated with the [LogExecutionTime] attribute, so the time for this will not be logged.
    /// </summary>
    public ActionResult Index()
    {
      // Do some work.
      Thread.Sleep(450);

      return View();
    }

    [LogExecTime]
    public ActionResult About()
    {
      // Do some work.
      Thread.Sleep(1500);

      return View();
    }
  }
}
