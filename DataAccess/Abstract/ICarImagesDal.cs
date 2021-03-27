using Core.DataAccess;
using Entities.Concrete.CarImages;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarImagesDal : IEntityRepository<CarImages>
    {
    }
}
