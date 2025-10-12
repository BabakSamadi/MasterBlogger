using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Domain.ServicesCheckValidation;

namespace Domain.ArticleAgg.Services
{
   public interface IAerticleValidtorService
    {
        void CheckthatthisRecordAlreadyExisits(string title);
    }
}
