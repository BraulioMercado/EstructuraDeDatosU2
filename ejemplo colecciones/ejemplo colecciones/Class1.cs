using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_colecciones
{
    public class Coleccion:CollectionBase
    {
        public void Add(Object item) //agregar
        {
            InnerList.Add(item);
        }
        public void Remove(object item) //quitar
        {
            InnerList.Remove(item);
        }
        public new void Clear() //limpiar
        {
            InnerList.Clear();
        }
        public new int Count() //contar cuantos valores se tienen.
        {
            return InnerList.Count;
        }
    }
}
