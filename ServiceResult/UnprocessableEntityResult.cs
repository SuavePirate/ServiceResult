using System.Collections.Generic;

namespace ServiceResult
{
    public class UnprocessableEntityResult<T> : Result<T>
    {
        private readonly string _error;
        public UnprocessableEntityResult(string error)
        {
            _error = error;
        }
        public override ResultType ResultType => ResultType.UnprocessableEntity;

        public override List<string> Errors => new List<string> { _error ??
            "The server understands the content type of the request entity, " +
            "and the syntax of the request entity is correct" +
            "but was unable to process the contained instructions." };

        public override T Data => default(T);
    }
}
