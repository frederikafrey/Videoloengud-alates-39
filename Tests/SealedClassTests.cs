﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests
{
    // seda klassi muidu ei käivitata, ainult siis kui ta on mingi teise klassi osa
    public abstract class SealedClassTests<TClass, TBaseClass> : ClassTests<TClass, TBaseClass> where TClass : new() //TClassil peab olema tühjade argmentidega constructor
    {
        [TestMethod]
        public void IsSealed()
        {
            Assert.IsTrue(type.IsSealed);
        }
    }
}
