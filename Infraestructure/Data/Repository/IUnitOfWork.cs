using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Data.Repository
{
    public interface IUnitOfWork: IDisposable
    {
        IFishRepository Fish { get; }

        void Save();
    }
}
