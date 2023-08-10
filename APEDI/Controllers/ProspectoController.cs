using AccesoDatos.Models;
using AccesoDatos.Repositorio;
using APEDI.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace APEDI.Controllers
{
    public class ProspectoController : Controller
    {

        private readonly IRepositorioAplicacion _repositorioAplicacion;
        private readonly IRepositorioDapper _repositorioDapper;
        private IMapper _mapper;

        public ProspectoController(IRepositorioAplicacion repositorioAplicacion,
            IRepositorioDapper repositorioDapper,
            IMapper mapper)
        {
            _repositorioAplicacion = repositorioAplicacion;
            _repositorioDapper = repositorioDapper;
            _mapper = mapper;
        }

        // GET: ProspectoController
        public ActionResult Index()
        {
            List<BasePoliticaPublicaModel> _politicas = _mapper.Map<List<BasePoliticaPublicaModel>>(_repositorioAplicacion.ListaBasePolitica());

            List<ProspectoModel> prospectos = _mapper.Map<List<ProspectoModel>>(_repositorioDapper.ListaProspectos());

            //List<ProspectoModel> prospectos = _repositorioDapper.ListaProspectos().
            //    Select(e => new ProspectoModel
            //    {
            //        NombreCodigoEvento = e.NombreCodigoEvento,
            //        NombreIdentatario = e.NombreIdentatario,
            //        NombresCompleto = e.NombresCompleto,
            //        FechaRegistro = e.FechaRegistro,
            //        FechaExpedición = e.FechaExpedición,
            //        FechaNacimiento = e.FechaNacimiento
            //    }).ToList();

            return View(prospectos);
        }

        // GET: ProspectoController/Details/5
        public ActionResult Details(string id)
        {
            var prospecto = _repositorioDapper.ConsultaProspecto(id);

            return View(prospecto);
        }

        // GET: ProspectoController/Create
        public ActionResult Create()
        {
            var listaTipoRegistro = _repositorioAplicacion.ListaTipoRegistro();

            List<SelectListItem> selectListItem = new List<SelectListItem>();
            selectListItem.Add(new SelectListItem { Text = "Seleccione un tipo", Value = "0", Selected = true });
            foreach (var item in listaTipoRegistro)
            {
                selectListItem.Add(new SelectListItem { Text = item.TipRegNombre, Value = item.IdTipoRegistro.ToString() });
            }
            ViewBag.IdTipoRegistro = selectListItem;

            var listaTipoFuente = _repositorioAplicacion.ListaTipoFuente();
            List<SelectListItem> listFuente = new List<SelectListItem>();
            listFuente.Add(new SelectListItem { Text = "Seleccione el tipo de fuente", Value = "0", Selected = true });
            foreach (var item in listaTipoFuente)
            {
                listFuente.Add(new SelectListItem { Text = item.FueAteNombre, Value = item.IdFuenteAtencion.ToString() });
            }
            ViewBag.IdFuente = listFuente;

            var listaPoliticas = _repositorioAplicacion.ListaBasePolitica();
            List<SelectListItem> listaPoliticasP = new List<SelectListItem>();
            listaPoliticasP.Add(new SelectListItem { Text = "Seleccione una politica", Value = "0", Selected = true });
            foreach (var item in listaPoliticas)
            {
                listaPoliticasP.Add(new SelectListItem { Text = item.BasPolPubNombre, Value = item.IdBasePoliticaPublica.ToString(),});
            }
            ViewBag.IdBasesPoliticasPublicas = listaPoliticasP;
            var listModoAtencion = _repositorioAplicacion.ListaModoAtencion();
            List<SelectListItem> listMod = new List<SelectListItem>();
            listMod.Add(new SelectListItem { Text = "Seleccione un modo de atención", Value = "0", Selected = true });
            foreach (var item in listModoAtencion)
            {
                listMod.Add(new SelectListItem { Text = item.ModAteNombre, Value = item.IdModoAtencion.ToString()});
            }
            ViewBag.IdModoAtencion = listMod;
            return View();
        }

        // POST: ProspectoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProspectoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProspectoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProspectoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProspectoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
