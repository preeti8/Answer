using System;
using AnswerFrameworkTests.Core.Models;
using AnswerFrameworkTests.Core.Services;
using AnswerFrameworkTests.Services;

namespace AnswerFrameworkTests.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class StartUpInfoAttribute : Attribute
    {
        public string Url { get; set; }

        public StartUpInfoAttribute(Enums.Brands brandName)
        {
            Url = new BrandService().GetBrand(brandName).Url;
        }
    }
}

