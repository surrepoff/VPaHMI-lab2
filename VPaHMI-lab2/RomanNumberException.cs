﻿using System;

namespace VPaHMI_lab2
{
    internal class RomanNumberException : Exception
    {
        public RomanNumberException() : base("ERROR") { }
        public RomanNumberException(string message) : base(message) { }
    }
}
