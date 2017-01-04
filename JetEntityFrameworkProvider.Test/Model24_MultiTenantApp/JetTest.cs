﻿using System;
using System.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JetEntityFrameworkProvider.Test.Model24_MultiTenantApp
{
    [TestClass]
    public class Model24_MultiTenantAppJetTest : Test
    {
        protected override DbConnection GetConnection()
        {
            return Helpers.GetJetConnection();
        }
    }
}
