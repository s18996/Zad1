using System.Xml.Serialization;

namespace APBD_zad1
{
    public class Studies
    {
        [XmlElement("name")]
        public string StudiesName { get; set; }

        [XmlElement("mode")]
        public string StudiesMode { get; set; }
    }
}
