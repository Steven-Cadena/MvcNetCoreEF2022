using Microsoft.AspNetCore.Mvc;
using MvcNetCoreEF2022.Models;
using MvcNetCoreEF2022.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcNetCoreEF2022.Controllers
{
    public class DoctoresController : Controller
    {
        private RepositoryDoctores repo;

        // constructor para las dependencias
        public DoctoresController(RepositoryDoctores repo) 
        {
            this.repo = repo;
        }
        public IActionResult DoctoresHospital(int idhospital) 
        {
            List<Doctor> doctores = this.repo.GetDoctoresHospital(idhospital);
            return View(doctores);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DoctoresSalario() 
        {
            List<Doctor> doctores = this.repo.GetDoctores();
            return View(doctores);
        }
        [HttpPost]
        public IActionResult DoctoresSalario(int salario) 
        {
            List<Doctor> doctores = this.repo.GetDoctoresSalario(salario);
            if (doctores == null)
            {
                ViewData["mensaje"] = "No hay doctores con ese salario.";
                return View();
            }
            else 
            {
                return View(doctores);
            }
        }
    }
}
