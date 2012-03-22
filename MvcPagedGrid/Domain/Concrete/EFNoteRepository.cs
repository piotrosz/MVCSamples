using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcPagedGrid.Domain.Abstract;
using MvcPagedGrid.Domain.Entities;

namespace MvcPagedGrid.Domain.Concrete
{
    public class EFNoteRepository : INoteRepository
    {
        private NotesContext context = new NotesContext();

        public IQueryable<Note> Notes
        {
            get { return context.Notes.Include("Categories"); }
        }

        public IQueryable<Category> Categories
        {
            get { return context.Categories; }
        }
    }
}