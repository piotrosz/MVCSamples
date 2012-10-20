using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcPagedGrid.Domain.Abstract;
using MvcPagedGrid.Models;

namespace MvcPagedGrid.Controllers
{
    public class NotesController : Controller
    {
        private INoteRepository notesRepository;

        public NotesController(INoteRepository notesRepository)
        {
            this.notesRepository = notesRepository;
        }

        public ActionResult Index(int page = 1)
        {
            int pageSize = 2;

            var viewModel = new NotesListViewModel
            {
                Notes = notesRepository.Notes
                .OrderBy(n => n.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize),

                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = notesRepository.Notes.Count()
                }
            };

            return View(viewModel);
        }
    }
}
