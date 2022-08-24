using System.Collections.Generic;

namespace ServiceResult
{
    public class ForbidResult<T> : Result<T>
    {
        private readonly string _error;
        public ForbidResult(string error)
        {
            _error = error;
        }
        public override ResultType ResultType => ResultType.Forbid;

        public override List<string> Errors => new List<string> { _error ??
            "The server understood the request but refuses to authorize it." };

        public override T Data => default(T);
    }
}
