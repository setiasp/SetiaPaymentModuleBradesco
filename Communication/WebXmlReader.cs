using System.Xml;
using System.Xml.Serialization;

namespace SetiaPaymentModuleBradesco.Communication
{
    public static class WebXmlReader
    {
        public static T LoadFromInternet<T>(string uri, string path = null, string secondpath = null)
        {
            using (var reader = XmlReader.Create(uri))
            {
                if (path != null)
                    reader.ReadStartElement(path);
                else
                    reader.ReadStartElement();

                if (secondpath != null)
                    reader.ReadToDescendant(secondpath);

                return (T)new XmlSerializer(typeof(T)).Deserialize(reader);
            }
        }
    }
}
