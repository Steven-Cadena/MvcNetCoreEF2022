using Microsoft.AspNetCore.Mvc;
using MvcNetCoreEF2022.Models;
using MvcNetCoreEF2022.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcNetCoreEF2022.Controllers
{
    public class HospitalesController : Controller
    {
        private RepositoryHospitales repo;
        //resolvemos las dependencias 
        public HospitalesController(RepositoryHospitales repo) 
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            //recuperamos los hospitales 
            List<Hospital> hospitales = this.repo.GetHospitales();
            //se lo enviamos a la vista
            return View(hospitales);
        }
        public IActionResult Details(int idhospital) 
        {
            Hospital hospital = this.repo.FindHospital(idhospital);
            return View(hospital);
        }
    }
}
