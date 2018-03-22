using System;
using System.Collections.Generic;

namespace ServiceResult
{
    /// <summary>
    /// Not found result.
    /// </summary>
    public class NotFoundResult<T> : Result<T>
    {
        private readonly string _error;
        public NotFoundResult(string error)
        {
            _error = error;
        }
        public override ResultType Type => ResultType.NotFound;

        public override List<string> Errors => new List<string> { _error ?? "The entity you're looking for cannot be found" };

        public override T Data => default(T);
    }
}
