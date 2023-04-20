using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SD_MatrixCrud_MVC.Models;

#nullable disable

namespace SD_MatrixCrud_MVC.Controllers
{
    public class PeoplesController : Controller
    {
        private readonly BancoDeDadosContexto _context;

        public PeoplesController(BancoDeDadosContexto context)
        {
            _context = context;
        }

        // GET: Peoples
        public async Task<IActionResult> Index()
        {
            return View(await _context.Peoples.ToListAsync());
        }


        // GET: Peoples/Create
        public IActionResult PersonAddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Person());
            else
                return View(_context.Peoples.Find(id));
        }

        // POST: Peoples/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PersonAddOrEdit([Bind("Id,FullName,DateOfBirth,Adress,Adress2,Complement,City,State")] Person person)
        {
            if (ModelState.IsValid)
            {
                if (person.Id == 0)
                    _context.Add(person);
                else
                    _context.Update(person);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(person);
        }

        // GET: Peoples/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {

            var person = await _context.Peoples.FindAsync(id);
            _context.Peoples.Remove(person);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
