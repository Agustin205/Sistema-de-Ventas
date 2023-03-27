using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Servicios
{
    public class Serializacion
    {
        public void Serializar(object objs,string directorio)
        {
            XmlSerializer serializar = new XmlSerializer(objs.GetType());
            FileStream fs = File.Open(directorio, FileMode.Create, FileAccess.Write);
            serializar.Serialize(fs, objs);
            fs.Close();
            fs.Dispose();
        }

        public object Deserializar<T>(string directorio)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            FileStream fStream = File.Open(directorio, FileMode.Open);
            Object objetoDeserializar = serializer.Deserialize(fStream);
            fStream.Close();
            fStream.Dispose();
            return objetoDeserializar;
        }
    }
}
