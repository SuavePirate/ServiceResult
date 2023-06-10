using System;
using System.Collections.Generic;

namespace ServiceResult
{
    /// <summary>
    /// Result model to contain data, result type, and errors
    /// </summary>
    public abstract class Result<T>
    {
        public abstract ResultType ResultType { get; }
        public abstract List<string> Errors { get; }
        public abstract T Data { get; }

        public static implicit operator bool(Result<T> result)
        {
            return result.ResultType == ResultType.Ok;
        }
    }
}
