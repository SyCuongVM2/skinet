using System;

namespace API.Errors
{
  public class ApiResponse
  {
    public ApiResponse(int statusCode, string message = null)
    {
      StatusCode = statusCode;
      Message = message ?? GetDefaultMessageForStatusCode(statusCode);
    }

    public int StatusCode { get; set; }
    public string Message { get; set; }

    private string GetDefaultMessageForStatusCode(int statusCode)
    {
      return statusCode switch
      {
        400 => "Bad request",
        401 => "Unauthorized",
        404 => "No resource found",
        500 => "Object reference not set to an instance of an object",
        _ => null
      };
    }
  }
}