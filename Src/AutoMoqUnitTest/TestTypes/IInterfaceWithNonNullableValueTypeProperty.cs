﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ploeh.AutoFixture.AutoMoq.UnitTest.TestTypes
{
    public interface IInterfaceWithNonNullableValueTypeProperty
    {
        int Property { get; set; }
    }
}