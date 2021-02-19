using Microsoft.AspNetCore.Mvc;
using ShawarmaX.Models;
using ShawarmaX.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShawarmaX.Controllers
{
    public class ShawarmaController : Controller
    {
        readonly IShawarmaRepository _shawarmaRepository;
        readonly ICategoryRepository _categoryRepository;

        public ShawarmaController(IShawarmaRepository shawarmaRepository, ICategoryRepository categoryRepository)
        {
            _shawarmaRepository = shawarmaRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            ShawarmaListViewModel shawarmaListViewModel = new ShawarmaListViewModel();
            shawarmaListViewModel.shawarmas = _shawarmaRepository.AllShawarma;
            shawarmaListViewModel.CurrentCategory = "main food";
            return View(shawarmaListViewModel);
        }
        public IActionResult Details(int id)
        {
            var pie = _shawarmaRepository.GetPieById(id);
            if (pie == null)
                return NotFound();

            return View(pie);
        }
    }
}
