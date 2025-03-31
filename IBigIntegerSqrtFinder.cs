﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryNumbersGenerators
{
    public interface IBigIntegerSqrtFinder
    {
        public BigInteger GetSqrt(BigInteger x);
    }
}
