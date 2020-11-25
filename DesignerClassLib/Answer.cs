using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesignerClassLib
{
    [Serializable]
    public class Answer
    {
        [XmlAttribute("body")]
        public string Body { get; set; }
        [XmlAttribute("correctAnswer")]
        public bool IsCorrectAnswer { get; set; }

        public Answer() { }
        public Answer(string body) 
        {
            Body = body;
        }
    }
}
