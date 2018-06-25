﻿using System.Data.SqlClient;

namespace OddJob.Storage.SqlServer.Test
{
    public class TestConnectionFactory : IJobQueueDbConnectionFactory
    {
        public SqlConnection GetConnection()
        {
            return SqlConnectionHelper.GetLocalDB("unittestdb");
        }
    }
}