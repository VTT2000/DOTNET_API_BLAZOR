using Microsoft.AspNetCore.Mvc.Filters;
namespace webapi_blazor.Filter;
public class CustomFilter : ActionFilterAttribute
{
    public CustomFilter() {

    }
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        //Lấy thông tin token từ header => giải mã token => Kiểm tra hợp lệ hay không 

    }
    public override void OnActionExecuted(ActionExecutedContext context)
    {

    }

  
}