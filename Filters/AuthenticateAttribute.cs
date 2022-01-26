using aplus_back_seed.Common;
using aplus_back_seed.Interfaces;
using Microsoft.AspNetCore.Mvc.Filters;

public class AuthenticateAttribute : Attribute, IActionFilter
  {
   

    public AuthenticateAttribute(){
    }
    

    public void OnActionExecuting(ActionExecutingContext context)
    {
      Console.WriteLine("authentication header:" + context.HttpContext.Request.Headers["Authorization"]);
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
      Console.WriteLine("OnActionExecuted");
    }
  }

  