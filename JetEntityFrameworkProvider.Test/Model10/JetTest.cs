﻿using System;
using System.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JetEntityFrameworkProvider.Test.Model10
{
    [TestClass]
    public class Model10 : Test
    {
        protected override DbConnection GetConnection()
        {
            return Helpers.GetJetConnection();
        }
    }
}
