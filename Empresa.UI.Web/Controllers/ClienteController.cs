﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Empresa.Db;
using Empresa.Models;


namespace Empresa.UI.Web.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Clientes
        public ActionResult Index()

        {
            var db = new ClienteDb();
            var lista = db.Listar();
            return View(lista);
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            var db = new ClienteDb();
            var cliente = db.ObterPorId(id);
            return View(cliente);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
           
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            try
            {
                var db = new ClienteDb();
                db.Incluir(cliente);
          
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View(cliente);
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            var db = new ClienteDb();
            var cliente = db.ObterPorId(id);
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Cliente cliente)
        {
            try
            {
                // TODO: Add update logic here
                var db = new ClienteDb();
                db.Alterar(cliente);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(cliente);
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {

            var db = new ClienteDb();
            var cliente = db.ObterPorId(id);

            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Cliente cliente)
        {
            try
            {
                // TODO: Add delete logic here

                var db = new ClienteDb();
                db.Excluir(cliente);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
