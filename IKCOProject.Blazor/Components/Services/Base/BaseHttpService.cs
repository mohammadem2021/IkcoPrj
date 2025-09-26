namespace IKCOProject.Blazor.Components.Services.Base
{
    public class BaseHttpService
    {
        protected Response<T> ConvertApiExceptions<T>(ApiException ex)
        {
            if (ex.StatusCode == 400)
            {
                return new Response<T>() { Message = "مشکلی پیش آمده دوباره امتحان کنید", ValidationErrors = ex.Response, Success = false };
            }
            else if (ex.StatusCode == 401)
            {
                return new Response<T>() { Message = "شما به این صفحه دسترسی ندارید", ValidationErrors = "401", Success = false };
            }
            else if (ex.StatusCode == 404)
            {
                return new Response<T>() { Message = "درخواست شما پیدا نشد", Success = false };
            }
            else if (ex.StatusCode == 405)
            {
                return new Response<T>() { Message = "مشکلی پیش آمده دوباره امتحان کنید", ValidationErrors = ex.Response, Success = false };
            }
            else if (ex.StatusCode == 500)
            {
                return new Response<T>() { Message = "مشکلی در سرور رخ داده است لطفا دوباره امتحان کنید", Success = false };
            }
            else
            {
                return new Response<T>() { Message = "مشکلی پیش آمده دوباره امتحان کنید", ValidationErrors = ex.Response, Success = false }; ;
            }
        }
    }
}
