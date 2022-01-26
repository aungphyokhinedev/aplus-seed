using aplus_back_seed.Common;
using aplus_back_seed.Interfaces;
using Microsoft.AspNetCore.Mvc.Filters;

public class LogStatusAttribute : Attribute, IActionFilter
  {
    protected IAplusSample logger;
   

    public LogStatusAttribute()
    {
      logger = new AplusSampleDI2();
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
      
      logger.write("OnActionExecuting");
     // Console.WriteLine("OnActionExecuting");
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
      Console.WriteLine("OnActionExecuted");
    }
  }

  