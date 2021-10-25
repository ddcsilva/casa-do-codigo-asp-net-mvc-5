﻿using Projeto.Contexts;
using Projeto.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Projeto.Controllers
{

    /// <summary>
    /// 1. Toda classe Controller deve ter seu nome finalizado com "Controller"
    /// 2. As actions devem ser public
    /// 3. As actions não podem ser static
    /// 4. As actions não podem ser sobrecarregadas com parâmetros, apenas com Attributes
    /// </summary>

    public class CategoriasController : Controller
    {
        private Contexto contexto = new Contexto();

        // GET: Categorias
        public ActionResult Index()
        {
            return View(contexto.Categorias.OrderBy(c => c.Nome));
        }

        // GET: Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categoria categoria)
        {
            contexto.Categorias.Add(categoria);
            contexto.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Edit
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Categoria categoria = contexto.Categorias.Find(id);

            if (categoria == null)
            {
                return HttpNotFound();
            }
            
            return View(categoria);
        }

        // POST: Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                contexto.Entry(categoria).State = EntityState.Modified;
                contexto.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(categoria);
        }

        // GET: Details
        public ActionResult Details(long id)
        {
            //return View(listaCategorias.Where(c => c.CategoriaId == id).First());
            return null;
        }

        // GET: Delete
        public ActionResult Delete(long id)
        {
            //return View(listaCategorias.Where(c => c.CategoriaId == id).First());
            return null;
        }

        // POST: Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Categoria categoria)
        {
            //listaCategorias.Remove(listaCategorias.Where(c => c.CategoriaId == categoria.CategoriaId).First());

            return RedirectToAction("Index");
        }
    }
}