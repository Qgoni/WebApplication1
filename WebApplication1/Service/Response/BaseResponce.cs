using Grpc.Core;

namespace WebApplication1.Service.Response;

public class BaseResponse
{
    public StatusCode StatusCode { get; set; }
}