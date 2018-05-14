using System;
using AnswerFrameworkTests.Core.Models;
using AnswerFrameworkTests.Core.Resources;
using AnswerFrameworkTests.Services;

namespace AnswerFrameworkTests.Core.Services
{
    public class BrandService : IBrandService
    {
        public Brand GetBrand(Enums.Brands brandName)
        {
            return CreateBrand(brandName);
        }

        private Brand CreateBrand(Enums.Brands brandName)
        {
            switch (brandName)
            {
                case Enums.Brands.Default:
                    return new Brand("Default", url.AnswerDigital);
                
                default:
                    throw new ArgumentOutOfRangeException(nameof(brandName), brandName, null);
    }
}
    }
}

