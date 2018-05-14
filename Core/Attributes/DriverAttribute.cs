using System;
using AnswerFrameworkTests.Services;

namespace AnswerFrameworkTests.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DriverAttribute : Attribute
    {
        public Enums.Drivers DriverToUse { get; set; }

        public DriverAttribute(Enums.Drivers driverToUse)
        {
            DriverToUse = driverToUse;
        }
    }
}

