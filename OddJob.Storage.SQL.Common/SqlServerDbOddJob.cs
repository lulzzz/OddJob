﻿using System;
using GlutenFree.OddJob.Interfaces;

namespace GlutenFree.OddJob.Storage.SQL.Common
{

    public class SqlServerDbOddJob : IOddJobWithMetadata
    {
        public Guid JobId { get; set; }
        public object[] JobArgs { get; set; }

        public Type TypeExecutedOn { get; set; }

        public string MethodName { get; set; }
        public string Status { get; set; }

        public IRetryParameters RetryParameters { get; set; }
    }
}
