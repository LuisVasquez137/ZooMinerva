<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Persona
    {
        DAL.Persona DTOPersona = new DAL.Persona();

        public DataTable Listar()
        {
            return DTOPersona.Listar();
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
using System.Data.SqlClient;

namespace BLL
{
    public class Persona
    {
        DAL.Persona DTOPersona = new DAL.Persona();

        public DataTable Listar()
        {
            return DTOPersona.Listar();
        }
    }
}
>>>>>>> origin/master
