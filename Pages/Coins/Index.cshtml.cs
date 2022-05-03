#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CryptoDemo.Data;
using CryptoDemo.Models;

namespace CryptoDemo.Pages.Coins
{
    public class IndexModel : PageModel
    {
        private readonly CryptoDemo.Data.CryptoDemoContext _context;

        public IndexModel(CryptoDemo.Data.CryptoDemoContext context)
        {
            _context = context;
        }

        public IList<Coin> Coin { get;set; }

        public async Task OnGetAsync()
        {
            Coin = await _context.Coin.ToListAsync();
        }
    }
}
