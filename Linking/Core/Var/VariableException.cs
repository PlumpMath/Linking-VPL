﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linking.Core.Var
{
    public class VariableException : Exception
    {
        public VariableException(string message) : base(message) { }
    }
}
