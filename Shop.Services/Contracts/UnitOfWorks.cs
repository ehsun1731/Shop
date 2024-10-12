using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Services.Contracts
{
    public interface UnitOfWorks
    {
        Task Begin();
        Task Commit();
        Task Complete();
        Task RollBack();
    }
}
