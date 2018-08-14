﻿using System;
using System.IO;
using System.Reflection;
using GlutenFree.OddJob.Interfaces;
using GlutenFree.OddJob.Storage.BaseTests;
using GlutenFree.OddJob.Storage.SQL.Common;
using LinqToDB;
using OddJob.Storage.Sql.SqlServer.Test;

namespace GlutenFree.OddJob.Storage.Sql.SqlServer.Test
{
    public class SqlServerStorageTest : StorageTests
    {
        public SqlServerStorageTest()
        {
            var execPath = Path.Combine(Assembly.GetExecutingAssembly().CodeBase, string.Empty)
                .Substring(0, Assembly.GetExecutingAssembly().CodeBase.LastIndexOf('/'));
            AppDomain.CurrentDomain.SetData("DataDirectory", new Uri(Path.Combine(execPath, string.Empty)).LocalPath);
            UnitTestTableHelper.EnsureTablesExist();


        }

        protected override Func<IJobQueueAdder> jobAddStoreFunc
        {
            get
            {
                return () => new SqlServerJobQueueAdder(
                    new TestConnectionFactory(new JobQueueDbConnectionFactorySettings()
                    {
                        ConnectionString = SqlConnectionHelper.CheckConnString("unittestdb"),
                        ProviderName = ProviderName.SqlServer
                    }),
                    new SqlDbJobQueueDefaultTableConfiguration());
            }
        }

        protected override Func<IJobQueueManager> jobMgrStoreFunc
        {
            get
            {
                return () => new SqlServerJobQueueManager(
                    new TestConnectionFactory(new JobQueueDbConnectionFactorySettings()
                    {
                        ConnectionString = SqlConnectionHelper.CheckConnString("unittestdb"),
                        ProviderName = ProviderName.SqlServer
                    }),
                    new SqlDbJobQueueDefaultTableConfiguration());
            }
        }

    }
}


