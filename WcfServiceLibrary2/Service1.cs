using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary2
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("Valor ingresado: {0}", value);
        }

        public double PromedioPracticas(int p1, int p2, int p3, int p4)
        {
            double douPromedio = 0;
            int[] arrNotas = { p1, p2, p3, p4 };
            Array.Sort(arrNotas);
            for (int i = 1; i <= 3; i++)
                douPromedio += arrNotas[i];
            return douPromedio / 3;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
