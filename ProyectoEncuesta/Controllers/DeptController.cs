﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conexion;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoEncuesta.Models;

namespace ProyectoEncuesta.Controllers
{
    public class DeptController : Controller
    {
        private string NombreTabla;
        private string[] NombreCampos;
        public DeptController()
        {
            NombreTabla = "Dept";
            NombreCampos = new string[] { "@IdDept", "Dept" };
        }
        // GET: Create
        public ActionResult Index()
        {
            return View();
        }

        // GET: Create/Details/5
        public ActionResult Edit()
        {
            ConexionBD con = new ConexionBD(NombreTabla, NombreCampos);
            DeptModel Dept = new DeptModel();
            con.Select("1005206910", Dept);
            return View(Dept);
        }

        // GET: Create/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Create/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            ConexionBD autorConexion = new ConexionBD(NombreTabla, NombreCampos);
            string[] valores = new string[NombreCampos.Length];
            
            for (int i = 0; i < NombreCampos.Length; i++)
            {
                valores[i] = collection[NombreCampos[i]];
            }
            autorConexion.Insert(valores);
            return RedirectToAction("List");
        }



        [HttpGet]
        public ActionResult List()
        {
            ConexionBD conector = new ConexionBD(NombreTabla, NombreCampos);
            List<Object> arreglo = conector.SelectAll(new DeptModel(),NombreTabla,NombreCampos);
            List<DeptModel> listaDeptes = new List<DeptModel>();
            foreach (Object Objecto in arreglo)
            {
                listaDeptes.Add((DeptModel)Objecto);
            }
            IEnumerable<DeptModel> list = listaDeptes;
            return View(list);
        }


        // POST: Create/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Create/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Create/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }

}