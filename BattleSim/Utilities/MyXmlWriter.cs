using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml;

namespace BattleSim.Utilities
{
    class MyXmlWriter
    {

        private void WriteToFile(FileInfo file, XElement xml)
        {
            XDocument charDoc;
            XmlWriterSettings xws = new XmlWriterSettings();
            xws.OmitXmlDeclaration = true;
            xws.Indent = true;

            if (!file.Directory.Exists)
            {
                file.Directory.Create();
            }

            using (XmlWriter writer = XmlWriter.Create(file.FullName, xws))
            {
                charDoc = new XDocument(xml);
                charDoc.WriteTo(writer);
            }
        }
    }
}
