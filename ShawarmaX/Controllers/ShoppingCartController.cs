using Microsoft.AspNetCore.Mvc;
using ShawarmaX.Models;
using ShawarmaX.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShawarmaX.Controllers
{
    public class ShoppingCartController : Controller
    {

        private readonly IShawarmaRepository _shawarmaRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IShawarmaRepository pieRepository, ShoppingCart shoppingCart)
        {
            _shawarmaRepository = pieRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int Sid)
        {
            var selectedShawarma = _shawarmaRepository.AllShawarma.FirstOrDefault(s => s.Id == Sid);

            if (selectedShawarma != null)
            {
                _shoppingCart.AddToCart(selectedShawarma, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int Sid)
        {
            var selectedShawarma = _shawarmaRepository.AllShawarma.FirstOrDefault(s => s.Id == Sid);

            if (selectedShawarma != null)
            {
                _shoppingCart.RemoveFromCart(selectedShawarma);
            }
            return RedirectToAction("Index");
        }
    }
}
