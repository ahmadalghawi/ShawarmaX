using ShawarmaX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShawarmaX.ViewModels
{
    public class ShawarmaListViewModel
    {
        public IEnumerable<Shawarma> shawarmas { get; set; }
        public string CurrentCategory { get; set; }
    }
}
