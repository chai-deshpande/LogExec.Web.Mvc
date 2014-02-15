LogExec.Web.Mvc
===============

Logs the execution time for ASP.NET MVC Controller Action methods by simply decorating it with an attribute [LogExecutionTime]

### Depends On
This library depends on the [LogExec github repo](https://github.com/chai-deshpande/LogExec), which is hosted on Nuget on https://www.nuget.org/packages/LogExec/

### Sample Usage
A sample usage of this library is show below:
```
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
```

Notice the attribute `[LogExecTime]` applied on the `HomeController`. This indicates that the execution time for all the action methods in the `HomeController` will be logged.

**Sample log file entry**
```
NEXUS INFO  2014-02-15 17:27:25,579   thread:5         40408ms LogExec.ExecutionTimeLogger => Execution time for [Home.Index]: [276] ms
NEXUS INFO  2014-02-15 17:27:29,281   thread:5         44110ms LogExec.ExecutionTimeLogger => Execution time for [Test.About]: [1536] ms
```
