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
    public class PreguntaController : Controller
    {
        public static string NombreTabla;
        public static string[] NombreCampos;
        public PreguntaController()
        {
            NombreTabla = "Pregunta";
            NombreCampos = new string[] { "@IdPregunta", "IdPreguntaPrincipal", "Enunciado","IdTipo"};
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
            PreguntaModel Pregunta = new PreguntaModel();
            con.Select("1005206910", Pregunta);
            return View(Pregunta);
        }

        // GET: Create/Create
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.TipoList = ListaClases.getListTipoPreguntas();
            ViewBag.PreguntaList = ListaClases.getListPreguntas();
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
            List<Object> arreglo = conector.SelectAll(new PreguntaModel(),NombreTabla,NombreCampos);
            List<PreguntaModel> listaPreguntaes = new List<PreguntaModel>();
            foreach (Object Objecto in arreglo)
            {
                listaPreguntaes.Add((PreguntaModel)Objecto);
            }
            IEnumerable<PreguntaModel> list = listaPreguntaes;
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