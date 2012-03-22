using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcPagedGrid.Domain.Entities;

namespace MvcPagedGrid.Models
{
    public class NotesListViewModel
    {
        public IEnumerable<Note> Notes { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}