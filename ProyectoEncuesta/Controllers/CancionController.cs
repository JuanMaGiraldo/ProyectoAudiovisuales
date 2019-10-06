using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conexion;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProyectoEncuesta.Models;

namespace ProyectoEncuesta.Controllers
{
    public class CancionController : Controller
    {
        private string NombreTabla;
        private string[] NombreCampos;
        public CancionController()
        {
            NombreTabla = "Cancion";
            NombreCampos = new string[] { "@IdCancion", "Cancion", "IdGenero" };
        }
        // GET: Create
        public ActionResult Index()
        {
            return View();
        }

        // GET: Cancion/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            ConexionBD con = new ConexionBD(NombreTabla, NombreCampos);
            CancionModel Cancion = new CancionModel();
            con.Select(id+"", Cancion);


            string NombreTablaF = "Genero";
            string[] NombreCamposF = new string[] { "@IdGenero", "Genero" };
            ConexionBD conector = new ConexionBD(NombreTabla, NombreCampos);
            List<Object> arreglo = conector.SelectAll(new GeneroModel(), NombreTablaF, NombreCamposF);
            List<GeneroModel> listaCanciones = new List<GeneroModel>();
            foreach (Object Objecto in arreglo)
            {
                listaCanciones.Add((GeneroModel)Objecto);
            }
            IEnumerable<SelectListItem> list = listaCanciones.Select(c => new SelectListItem
            {
                Value = c.IdGenero,
                Text = c.Genero
            });
            ViewBag.GeneroList = list;


            return View(Cancion);
        }

        // POST: Create/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(IFormCollection collection)
        {
            try
            {
                ConexionBD autorConexion = new ConexionBD(NombreTabla, NombreCampos);
                string[] valores = new string[NombreCampos.Length];

                for (int i = 0; i < NombreCampos.Length; i++)
                {
                    if (i == 0)
                    {
                        valores[i] = collection[NombreCampos[i].Replace("@","")];
                    }
                    else
                    {
                        valores[i] = collection[NombreCampos[i]];
                    }
                    
                }
                autorConexion.Edit(valores);
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        // GET: Create/Create
        [HttpGet]
        public ActionResult Create()
        {
            
            string NombreTablaF = "Genero";
            string[] NombreCamposF = new string[] { "@IdGenero", "Genero" };
            ConexionBD conector = new ConexionBD(NombreTabla, NombreCampos);
            List<Object> arreglo = conector.SelectAll(new GeneroModel(), NombreTablaF, NombreCamposF);
            List<GeneroModel> listaCanciones = new List<GeneroModel>();
            foreach (Object Objecto in arreglo)
            {
                listaCanciones.Add((GeneroModel)Objecto);
            }
            IEnumerable<SelectListItem> list = listaCanciones.Select(c => new SelectListItem {
                    Value = c.IdGenero,
                    Text  = c.Genero 
            });
            ViewBag.GeneroList = list;
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
            List<Object> arreglo = conector.SelectAll(new CancionModel(),NombreTabla,NombreCampos);
            List<CancionModel> listaCanciones = new List<CancionModel>();
            foreach (Object Objecto in arreglo)
            {
                CancionModel cancion = (CancionModel) Objecto;


                string NombreTablaF = "Genero";
                string[] NombreCamposF = new string[] { "@IdGenero", "Genero" };
                conector = new ConexionBD(NombreTablaF, NombreCamposF);
                GeneroModel Genero = new GeneroModel();
                conector.Select(cancion.IdGenero, Genero);

                cancion.IdGenero = Genero.Genero;

                listaCanciones.Add(cancion);

            }
            IEnumerable<CancionModel> list = listaCanciones;
            return View(list);
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