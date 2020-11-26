using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesignerClassLib
{
    public class Serializer
    {
        public static T Deserialize<T>(string path) where T : class
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));

            using (Stream stream = File.Open(path, FileMode.Open))
            {
                return (T)ser.Deserialize(stream);
            }
        }
        public static void Serialize<T>(T ObjectToSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(ObjectToSerialize.GetType(), new XmlRootAttribute("Test"));
            using (FileStream fs = new FileStream("test.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, ObjectToSerialize);
            }
        }
    }
}
