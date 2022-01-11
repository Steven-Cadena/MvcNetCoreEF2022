using MvcNetCoreEF2022.Data;
using MvcNetCoreEF2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcNetCoreEF2022.Repositories
{
    public class RepositoryHospitales
    {
        //creamos la propiedad de context
        private HospitalesContext context;
        //constructor donde recibimos el context
        public RepositoryHospitales(HospitalesContext context) 
        {
            this.context = context;
        }
        //REALIZAMOS UNA CONSULTA LINQ PARA DEVOLVER TODOS LOS HOSPITALES
        public List<Hospital> GetHospitales() 
        {
            //consulta
            var consulta = from datos in this.context.Hospitales
                           select datos;
            //con este return devolvemos todos los hospitales 
            return consulta.ToList();
        }
        public Hospital FindHospital(int idhospital) 
        {
            //hacemos la consulta con el where 
            var consulta = from datos in this.context.Hospitales
                           where datos.IdHospital == idhospital
                           select datos;
            //PODRIAMOS TENER HOSPITAL (UNO) O NO
            if (consulta.Count() == 0)
            {
                //siempre hay que devolver nulos cuando se filtre o se devuelva un valor 
                return null;
            }
            else 
            {
                //devolvemos el primer campo para pintar en la vista
                return consulta.First();
            }
        }
    }
}
