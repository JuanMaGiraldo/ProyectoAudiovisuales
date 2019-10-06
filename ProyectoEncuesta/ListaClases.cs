using Conexion;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProyectoEncuesta.Controllers;
using ProyectoEncuesta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEncuesta
{
    public class ListaClases
    {
        public static IEnumerable<SelectListItem> getListTipoPreguntas()
        {
            string NombreTablaF = "Tipo_Pregunta";
            string[] NombreCamposF = new string[] { "@IdTipo", "Tipo" };
            ConexionBD conector = new ConexionBD(NombreTablaF, NombreCamposF);
            List<Object> arreglo = conector.SelectAll(new TipoPreguntaModel(), NombreTablaF, NombreCamposF);
            List<TipoPreguntaModel> listaObjectos = new List<TipoPreguntaModel>();
            foreach (Object Objecto in arreglo)
            {
                listaObjectos.Add((TipoPreguntaModel)Objecto);
            }
            IEnumerable<SelectListItem> list = listaObjectos.Select(c => new SelectListItem
            {
                Value = c.IdTipo,
                Text = c.Tipo
            });

            return list;
            
        }

        public static IEnumerable<SelectListItem> getListPreguntas()
        {
            string NombreTablaF = PreguntaController.NombreTabla;
            string[] NombreCamposF = PreguntaController.NombreCampos;
            ConexionBD conector = new ConexionBD(NombreTablaF, NombreCamposF);
            List<Object> arreglo = conector.SelectAll(new PreguntaModel(), NombreTablaF, NombreCamposF);
            List<PreguntaModel> listaObjectos = new List<PreguntaModel>();
            foreach (Object Objecto in arreglo)
            {
                listaObjectos.Add((PreguntaModel)Objecto);
            }
            IEnumerable<SelectListItem> list = listaObjectos.Select(c => new SelectListItem
            {
                Value = c.IdPregunta,
                Text = c.Enunciado
            });
            return list;
        }
    }
}
