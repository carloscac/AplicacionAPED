using AccesoDatos.Models;
using AccesoDatos.Repositorio;
using APEDI.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
