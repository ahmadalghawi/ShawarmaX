using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShawarmaX.Models
{
    public interface IShawarmaRepository
    {
        IEnumerable<Shawarma> AllShawarma { get; }
        IEnumerable<Shawarma> Offers { get; }
        Shawarma GetPieById(int shawarmaId);
    }
}
