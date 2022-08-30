using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UniversidadClase.Data;
using UniversidadClase.Models;

namespace UniversidadClase.Pages.Estudiantes
{
    public class IndexModel : PageModel
    {
        private readonly UniversidadClase.Data.ApplicationDbContext _context;

        public IndexModel(UniversidadClase.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Estudiante> Estudiante { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Estudiantes != null)
            {
                Estudiante = await _context.Estudiantes.ToListAsync();
            }
        }
    }
}
