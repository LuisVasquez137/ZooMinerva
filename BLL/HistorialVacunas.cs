<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class HistorialVacunas
    {
        DAL.HistorialVacunas DTOHistorialVacunas = new DAL.HistorialVacunas();

        public bool Create(int idAnimal, int idVacuna, DateTime fecha)
        {
            return DTOHistorialVacunas.Create(idAnimal, idVacuna, fecha);
        }

        public bool Update(int idAnimal, int idVacuna, DateTime fecha, int PK)
        {
            return DTOHistorialVacunas.Update(idAnimal, idVacuna, fecha, PK);
        }

        public int Count(int idAnimal, int idVacuna)
        {
            return DTOHistorialVacunas.Count(idAnimal, idVacuna);
        }

        public DataTable Listar()
        {
            return DTOHistorialVacunas.Listar();
        }

        public DataTable Listar(int id)
        {
            return DTOHistorialVacunas.Listar(id);
        }

        public DataTable Listar(string nombreVacuna, string nombreAnimal)
        {
            return DTOHistorialVacunas.Listar(nombreVacuna, nombreAnimal);
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class HistorialVacunas
    {
        DAL.HistorialVacunas DTOHistorialVacunas = new DAL.HistorialVacunas();

        public bool Create(int idAnimal,int idVacuna,DateTime fecha)
        {
            return DTOHistorialVacunas.Create(idAnimal,idVacuna,fecha);
        }

        public bool Update(int idAnimal,int idVacuna,DateTime fecha, int PK)
        {
            return DTOHistorialVacunas.Update(idAnimal,idVacuna,fecha,PK);
        }

        public int Count(int idAnimal,int idVacuna)
        {
            return DTOHistorialVacunas.Count(idAnimal,idVacuna);
        }

        public DataTable Listar()
        {
            return DTOHistorialVacunas.Listar();
        }

        public DataTable Listar(int id)
        {
            return DTOHistorialVacunas.Listar(id);
        }

        public DataTable Listar(string nombreVacuna, string nombreAnimal)
        {
            return DTOHistorialVacunas.Listar(nombreVacuna,nombreAnimal);
        }
    }
}
>>>>>>> origin/master
