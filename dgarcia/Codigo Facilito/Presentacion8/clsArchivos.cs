using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion8
{
    public class clsArchivos : intSalidas
    {
        public void ImprimeCliente(clsAbsClientes cliente)
        {
            int i = 0;
            bool bandera = true;
            while (bandera) 
            { 
            
            try { 
            StreamWriter ar = new StreamWriter("D:\\MATERIAS CUMBRE\\PROGRAMACION 2 NUEVO\\ArchBitacora.log", true);
            ar.WriteLine(cliente.Clave + " " + cliente.Nombre);
            if (cliente.TipoRegimen == 1)
                ar.WriteLine("Tipo: PERSONA FISICA");
            else
                ar.WriteLine("Tipo: PERSONA MORAL");
            ar.WriteLine("RFC: " + cliente.RFC);
            ar.Close();
                    bandera = false;
            }
            catch (Exception e) 
            {
                    i++;
                    if (i >= 1000)
                throw e;
            }
            }
        }

        public void ImprimeDireccion(clsDirecciones direccion)
        {
            StreamWriter ar = new StreamWriter("D:\\MATERIAS CUMBRE\\PROGRAMACION 2 NUEVO\\ArchBitacora.log", true);
            ar.Close ();
        }
    }
}
