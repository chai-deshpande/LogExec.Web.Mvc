using System.Web.Mvc;

namespace LogExec.Web.Mvc
{
  /// <summary>
  /// This attribute logs the execution time for the controller/action it is applied to.
  /// The execution time includes the time to execute the action as well as the result.
  /// </summary>
  public class LogExecTimeAttribute : FilterAttribute, IActionFilter, IResultFilter
  {
    private ExecutionTimeLogger _executionTimeLogger;

    public void OnActionExecuting(ActionExecutingContext filterContext)
    {
      _executionTimeLogger = new ExecutionTimeLogger(string.Format("{0}.{1}", filterContext.ActionDescriptor.ControllerDescriptor.ControllerName, filterContext.ActionDescriptor.ActionName));
    }

    public void OnActionExecuted(ActionExecutedContext filterContext)
    {
    }

    public void OnResultExecuting(ResultExecutingContext filterContext)
    {
    }

    public void OnResultExecuted(ResultExecutedContext filterContext)
    {
      _executionTimeLogger.Stop();
      _executionTimeLogger.Log();
    }
  }
}