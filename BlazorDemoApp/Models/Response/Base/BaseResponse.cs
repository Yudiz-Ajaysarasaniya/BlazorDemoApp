namespace BlazorDemoApp.Models.Response.Base
{
    public class BaseResponse
    {
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
        public string Data { get; set; }
    }
}
