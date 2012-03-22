using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvcPagedGrid.Domain.Entities;

namespace MvcPagedGrid.Domain.Abstract
{
    public interface INoteRepository
    {
        IQueryable<Note> Notes { get; }
    }
}
