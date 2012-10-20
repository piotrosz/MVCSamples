using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcPagedGrid.Domain.Abstract;

namespace MvcPagedGrid.Domain.Entities
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public virtual ICollection<Note> Notes { get; set; }
    }
}