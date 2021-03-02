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

        //public IActionResult List()
        //{
        //    ShawarmaListViewModel shawarmaListViewModel = new ShawarmaListViewModel();
        //    shawarmaListViewModel.shawarmas = _shawarmaRepository.AllShawarma;
        //    shawarmaListViewModel.CurrentCategory = "main food";
        //    return View(shawarmaListViewModel);
        //}
        public ViewResult List(string category)
        {
            IEnumerable<Shawarma> shawarmas;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                shawarmas = _shawarmaRepository.AllShawarma.OrderBy(p => p.Id);
                currentCategory = "All Shawarma";
            }
            else
            {
                shawarmas = _shawarmaRepository.AllShawarma.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.Id);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new ShawarmaListViewModel
            {
                shawarmas = shawarmas,
                CurrentCategory = currentCategory
            });
        }
        public IActionResult Details(int id)
        {
            var shawarma = _shawarmaRepository.GetPieById(id);
            if (shawarma == null)
                return NotFound();

            return View(shawarma);
        }
    }
}
