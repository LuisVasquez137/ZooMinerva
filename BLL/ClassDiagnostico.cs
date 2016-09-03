using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.DataSetDiagnosticoTableAdapters;

namespace BLL
{
    public class ClassDiagnostico
    {

        private DiagnosticoAnimalTableAdapter diagnosticoAnimal;
        private DiagnosticoTableAdapter diagnostico;
        private f_codigo_DiagnosticoTableAdapter codigo;
        private sp_buscaCodigoAnimalTableAdapter codigoAnimal;
        private sp_codigo_historialTableAdapter codigo_historial;
        private sp_listado_diagnosticoTableAdapter listada_diagnostico;




        private sp_listado_diagnosticoTableAdapter LISTA_DIAGNOSTICO
        {
            get
            {
                if (listada_diagnostico == null)
                    listada_diagnostico = new sp_listado_diagnosticoTableAdapter();
                return listada_diagnostico;
            }
        }

        private DiagnosticoAnimalTableAdapter DIAGNOSTICOANIMAL
        {
            get
            {
                if (diagnosticoAnimal == null)
                    diagnosticoAnimal = new DiagnosticoAnimalTableAdapter();
                return diagnosticoAnimal;
            }
        }

        private DiagnosticoTableAdapter DIAGNOSTICO
        {
            get
            {
                if (diagnostico == null)
                    diagnostico = new DiagnosticoTableAdapter();
                return diagnostico;
            }
        }

        private sp_buscaCodigoAnimalTableAdapter CODIGOANIMAL
        {
            get
            {
                if (codigoAnimal == null)
                    codigoAnimal = new sp_buscaCodigoAnimalTableAdapter ();
                return codigoAnimal;
            }
        }


        private f_codigo_DiagnosticoTableAdapter CODIGO
        {
            get
            {
                if (codigo == null)
                    codigo = new f_codigo_DiagnosticoTableAdapter();
                return codigo;
            }
        }


        private sp_codigo_historialTableAdapter HISTORIAL
        {
            get
            {
                if (codigo_historial == null)
                    codigo_historial = new sp_codigo_historialTableAdapter();
                return codigo_historial;
            }
        }
        public int InsertaDiagnostico(DateTime fecha ,int codEmpleado,string motivo,string peso,string temp,string car,string res,string tllc,string mucosas,string tungencia,string pulso,string anamnesis,string enfermedadesAnteriores,string actitud,string condicionCorporal,string hidratacion,string ojos,string oidos,string nudos,string locomocion,string mesqueletico,string nervioso,string cardiobascular,string digestivo,string respiratorio,string genitouriano,string problemasEncontrados,string diagnosticoPresuntivo,string diagnosticoDefinitivo,string resultado,string progreso)
        {

            return DIAGNOSTICO.sp_InsertaDiagnostico(fecha, codEmpleado, motivo, peso, temp, car, res, tllc, mucosas, tungencia, pulso, anamnesis, enfermedadesAnteriores, actitud, condicionCorporal, hidratacion, ojos, oidos, nudos, locomocion, mesqueletico, nervioso, cardiobascular, digestivo, respiratorio, genitouriano, problemasEncontrados, diagnosticoPresuntivo, diagnosticoDefinitivo, resultado, progreso);

        }
        public int InsertaDiagnosticoAnimal(int codAnimal, int codHistorial)

        {

            return DIAGNOSTICOANIMAL.sp_InsertaDiagnosticoAnimal(codAnimal, codHistorial);

        }

        public DataTable Devulve_codigo()

        {

            return CODIGO.CodigoDiagnostico();

        }

        public DataTable codigo_animal(string cod)
        {

            return CODIGOANIMAL.CodigoAnimal(cod);

        }

        public DataTable codigo_Historial()
        {

            return HISTORIAL.CodigoDiagnostico1();

        }

        public DataTable listados_diagnostico(int cod)

        {

            return LISTA_DIAGNOSTICO.Listado_Diagnosticos(cod);

        }


    }
}
