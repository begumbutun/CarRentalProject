using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete.CarImages;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImagesDal : EfEntityRepositoryBase<CarImages, ReCapDb>, ICarImagesDal
    {
    }
}
