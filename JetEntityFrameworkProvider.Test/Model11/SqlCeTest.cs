﻿using System;
using System.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JetEntityFrameworkProvider.Test.Model11
{
    [TestClass]
    public class Model11CeTest : Test
    {

        protected override DbConnection GetConnection()
        {
            return Helpers.GetSqlCeConnection();
        }

    }
}
