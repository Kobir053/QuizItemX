using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QuizItemX
{
    internal class XService
    {
        private string _path;
        public XService(string path) 
        {
            _path = path;
        }

        public void AddItem(string q, string ans)
        {
            XDocument doc = XDocument.Load(_path);
            XElement root = doc.Root;

            XElement qNode = new XElement("Question",q);
            XElement aNode = new XElement("Answer",ans);
            XElement item = new XElement("Item",qNode, aNode);
            root.Add(item);
            doc.Save(_path);
        }

        public void Show()
        {
            XDocument doc = XDocument.Load(_path);
            XElement root = doc.Root;

            List<XElement> list = root.Elements().ToList();
            foreach (XElement node in list)
            {
                string a = node.Element("Question").Value;
            }
        }
    }
}
