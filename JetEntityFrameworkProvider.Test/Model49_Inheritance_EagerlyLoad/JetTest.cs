﻿using System;
using System.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JetEntityFrameworkProvider.Test.Model49_Inheritance_EagerlyLoad
{
    [TestClass]
    public class Model49_Inheritance_EagerlyLoadJetTest : Test
    {
        protected override DbConnection GetConnection()
        {
            return Helpers.GetJetConnection();
        }
    }
}
