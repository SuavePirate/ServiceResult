﻿using System;
using System.Collections.Generic;

namespace ServiceResult
{
    /// <summary>
    /// Unexpected result.
    /// </summary>
    public class UnexpectedResult : Result
    {

        private readonly string _error;
        public UnexpectedResult(string error)
        {
            _error = error;
        }
        public UnexpectedResult()
        {

        }
        public override ResultType ResultType => ResultType.Unexpected;

        public override List<string> Errors => new List<string> { _error ?? "There was an unexpected problem" };
    }
}
