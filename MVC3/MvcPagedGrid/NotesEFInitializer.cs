using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MvcPagedGrid.Domain.Entities;

namespace MvcPagedGrid
{
    public class NotesEFInitializer : DropCreateDatabaseAlways<NotesContext>
    {
        protected override void Seed(NotesContext context)
        {
            var categories = new List<Category>
            {
                new Category
                {
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                    Name = "Urgent"
                },
                new Category
                {
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                    Name = "Private"
                }
            };

            var notes = new List<Note>
            {
                new Note
                {
                    Content = "Content",
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                    Categories = categories
                },
                new Note
                {
                    Content = "Content 2",
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                    Categories = categories
                },
                new Note
                {
                    Content = "Content 3",
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                    Categories = categories
                },
            };

            categories.ForEach(c => context.Categories.Add(c));
            notes.ForEach(n => context.Notes.Add(n));
        }
    }
}