using System.Collections.Generic;

namespace ServiceResult
{
    public class CreatedResult<T> : Result<T>
    {
        private readonly T _data;
        public CreatedResult(T data)
        {
            _data = data;
        }
        public override ResultType ResultType => ResultType.Ok;

        public override List<string> Errors => new List<string>();

        public override T Data => _data;
    }
}
