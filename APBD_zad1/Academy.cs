using System.Collections.Generic;
using System.Xml.Serialization;

namespace APBD_zad1
{
    [XmlType("uczelnia")]
    public class Academy {

        [XmlAttribute("createdAt")]
        public string date { get; set; }

        [XmlAttribute("author")]
        public string author { get; set; }

        [XmlArray("studenci")]
        public List<Student> Students { get; set; }

        [XmlArray("activeStudies")]
        public List<ActiveStudies> Studies { get; set; }

    }
}
