<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class Ingrediente
    {
        DAL.Ingrediente DTOIngrediente = new DAL.Ingrediente();

        public DataTable Listar()
        {
            return DTOIngrediente.Listar();
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
    public class Ingrediente
    {
        DAL.Ingrediente DTOIngrediente = new DAL.Ingrediente();

        public DataTable Listar()
        {
            return DTOIngrediente.Listar();
        }
    }
}
>>>>>>> origin/master
