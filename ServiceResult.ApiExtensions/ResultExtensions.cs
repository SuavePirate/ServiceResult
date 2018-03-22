using System;
using Microsoft.AspNetCore.Mvc;

namespace ServiceResult.ApiExtensions
{
    /// <summary>
    /// Result extensions for APIs.
    /// </summary>
    public static class ResultExtensions
    {
        /// <summary>
        /// Creates an ActionResult from a service Result
        /// </summary>
        /// <returns>The action result.</returns>
        /// <param name="result">Service Result.</param>
        /// <typeparam name="T">The data type of the Result.</typeparam>
        public static ActionResult FromActionResult<T>(this ControllerBase controller, Result<T> result)
        {
            switch (result.ResultType)
            {
                case ResultType.Ok:
                    return controller.Ok(result.Data);
                case ResultType.NotFound:
                    return controller.NotFound(result.Errors);
                case ResultType.Invalid:
                    return controller.BadRequest(result.Errors);
                case ResultType.Unexpected:
                    return controller.BadRequest(result.Errors);
                case ResultType.Unauthorized:
                    return controller.Unauthorized();
                default:
                    throw new Exception("An unhandled result has occurred as a result of a service call.");
            }
        }
    }
}
