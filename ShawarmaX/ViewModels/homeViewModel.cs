using ShawarmaX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShawarmaX.ViewModels
{
    public class homeViewModel
    {
        public IEnumerable<Shawarma> Offers { get; set; }
    }
}
