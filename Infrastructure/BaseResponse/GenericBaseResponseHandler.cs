using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.BaseResponse;

public class GenericBaseResponseHandler
{

    public GenericBaseResponseHandler()
    {
    }

    public GenericBaseResponse<T> Delete<T>()
    {
        return new GenericBaseResponse<T>()
        {
            StatusCode = HttpStatusCode.OK,
            Succeeded = true,
            Message = "Deleted Successfully"
        };
    }

    public GenericBaseResponse<T> Success<T>(T entity, object Meta = null)
    {
        return new GenericBaseResponse<T>()
        {
            StatusCode = HttpStatusCode.OK,
            Succeeded = true,
            Message = "Successfully Completed",
            Data = entity,
            Meta = Meta
        };
    }

    public GenericBaseResponse<T> Unauthorized<T>()
    {
        return new GenericBaseResponse<T>()
        {
            StatusCode = HttpStatusCode.Unauthorized,
            Succeeded = true,
            Message = "Unauthorized"
        };
    }
    public GenericBaseResponse<T> BadRequest<T>(string Message = null)
    {
        return new GenericBaseResponse<T>()
        {
            StatusCode = HttpStatusCode.BadRequest,
            Succeeded = false,
            Message = Message == null ? "Bad Request" : Message
        };
    }

    public GenericBaseResponse<T> UnprocessableEntity<T>(string Message = null)
    {
        return new GenericBaseResponse<T>()
        {
            StatusCode = HttpStatusCode.UnprocessableEntity,
            Succeeded = false,
            Message = Message == null ? "Un-processable Entity" : Message
        };
    }

    public GenericBaseResponse<T> AlreadyExit<T>(string Message = null)
    {
        return new GenericBaseResponse<T>()
        {
            StatusCode = HttpStatusCode.OK,
            Succeeded = false,
            Message = Message == null ? "This Object Already Exists" : Message
        };
    }

    public GenericBaseResponse<T> NotFound<T>(string message = null)
    {
        return new GenericBaseResponse<T>()
        {
            StatusCode = HttpStatusCode.NotFound,
            Succeeded = false,
            Message = message == null ? "This Object Not Found" : message
        };
    }

    public GenericBaseResponse<T> Created<T>(T entity, object Meta = null)
    {
        return new GenericBaseResponse<T>()
        {
            Data = entity,
            StatusCode = HttpStatusCode.Created,
            Succeeded = true,
            Message = "Created Successfully",
            Meta = Meta
        };
    }

    public GenericBaseResponse<T> Updated<T>(T entity, object Meta = null)
    {
        return new GenericBaseResponse<T>()
        {
            Data = entity,
            StatusCode = HttpStatusCode.OK,
            Succeeded = true,
            Message = "Updated Successfully",
            Meta = Meta
        };
    }
}
