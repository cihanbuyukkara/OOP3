using System;
using System.Collections.Generic;
using System.Text;

namespace GameProje
{
    interface ICampaingnService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
