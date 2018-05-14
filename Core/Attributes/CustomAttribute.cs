using System;
using System.Linq;
using System.Reflection;
using AnswerFrameworkTests.Core.Models;
using AnswerFrameworkTests.Services;
using AnswerFrameworkTests.Tests;

namespace AnswerFrameworkTests.Core.Attributes
{
    public static class CustomAttributes
    {
        public static Data GetStartUpInfo(MethodBase method)
        {
            var methodName = method.Name;
            var className = method.ReflectedType?.FullName;

            var member = Type.GetType(className)?.GetMembers().First(x => x.Name == methodName);
            var attributes = member?.GetCustomAttributes(true);
            foreach (var attributeClass in attributes?.OfType<StartUpInfoAttribute>())
            {
                return new Data() { SiteUrl = attributeClass.Url };
            }
            return null;
        }
        public static Enums.Drivers GetDriverType(MethodBase method)
        {
            var attributes = Attribute.GetCustomAttributes(method.DeclaringType);

            foreach (var attributeClass in attributes.OfType<DriverAttribute>())
            {
                return attributeClass.DriverToUse;
            }
            return Enums.Drivers.Chrome;
        }
    }




}