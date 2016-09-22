<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class Animal
    {
        DAL.Animal DTOAnimal = new DAL.Animal();

        public bool Create(string codigo, string alias, string sexo, int edad, int estado, string fechaNac, string fechaMuerte, int genero, string causaMuerte)
        {
            return DTOAnimal.Create(codigo, alias, sexo, estado, edad, fechaNac, fechaMuerte, causaMuerte, genero);
        }

        public bool Update(string codigo, string alias, string sexo, int edad, int estado, string fechaNac, string fechaMuerte, int genero, string causaMuerte, int pk)
        {
            return DTOAnimal.Update(codigo, alias, sexo, estado, edad, fechaNac, fechaMuerte, causaMuerte, genero, pk);
        }

        public int Count(string codigo, int estado)
        {
            return DTOAnimal.Count(codigo, estado);
        }

        public DataTable Listar()
        {
            return DTOAnimal.Listar();
        }

        public DataTable Listar(int id)
        {
            return DTOAnimal.Listar(id);
        }

        public DataTable Listar(string codigo, int estado)
        {
            return DTOAnimal.Listar(codigo, estado);
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
using DAL;

namespace BLL
{
    public class Animal
    {
        DAL.Animal DTOAnimal = new DAL.Animal();

        public bool Create(string codigo,string alias,string sexo,int edad,int estado,string fechaNac,string fechaMuerte, int genero,string causaMuerte)
        {
            return DTOAnimal.Create(codigo,alias,sexo,estado,edad,fechaNac,fechaMuerte,causaMuerte,genero);
        }

        public bool Update(string codigo, string alias, string sexo, int edad, int estado, string fechaNac, string fechaMuerte, int genero, string causaMuerte,int pk)
        {
            return DTOAnimal.Update(codigo,alias,sexo,estado,edad,fechaNac,fechaMuerte,causaMuerte,genero,pk);
        }

        public int Count(string codigo, int estado)
        {
            return DTOAnimal.Count(codigo, estado);
        }

        public DataTable Listar()
        {
            return DTOAnimal.Listar();
        }

        public DataTable Listar(int id)
        {
            return DTOAnimal.Listar(id);
        }

        public DataTable Listar(string codigo, int estado)
        {
            return DTOAnimal.Listar(codigo, estado);
        }
    }
}
>>>>>>> origin/master
