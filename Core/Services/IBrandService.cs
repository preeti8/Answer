using AnswerFrameworkTests.Core.Models;
using AnswerFrameworkTests.Services;
using AnswerFrameworkTests.Core.Resources;

namespace AnswerFrameworkTests.Core.Services
{
    public interface IBrandService
    {
        Brand GetBrand(Enums.Brands brandName);
    }
}
