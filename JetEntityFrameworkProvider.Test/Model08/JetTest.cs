﻿using System;
using System.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JetEntityFrameworkProvider.Test.Model08
{
    [TestClass]
    public class Model08 : Test
    {
        protected override DbConnection GetConnection()
        {
            return Helpers.GetJetConnection();
        }
    }
}
