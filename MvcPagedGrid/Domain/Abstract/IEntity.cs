using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcPagedGrid.Domain.Abstract
{
    public interface IEntity
    {
        DateTime Created { get; set; }
        DateTime Updated { get; set; }
    }
}
