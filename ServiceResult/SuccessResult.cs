﻿using System;
using System.Collections.Generic;

namespace ServiceResult
{
    /// <summary>
    /// Success result.
    /// </summary>
    public class SuccessResult : Result
    {
        public SuccessResult()
        {
        
        }

        public override ResultType ResultType => ResultType.Ok;

        public override List<string> Errors => new List<string>();
    }
}
