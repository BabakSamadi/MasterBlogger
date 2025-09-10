using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ServicesCheckValidation
{
    public interface IArticleCategoryValidatorServices
    {
        void CheckThatThisRecordAlreadyExist(string title);
    }
}
