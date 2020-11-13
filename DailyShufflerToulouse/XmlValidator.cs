using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace DailyShufflerToulouse
{
    /// <summary>
    /// Validates XML files from multiple XSD files
    /// </summary>
    class XmlValidator
    {
        /// <summary>
        /// The XML namespace to validate against
        /// </summary>
        public String Namespace { get; set; } = String.Empty;
        /// <summary>
        /// Add an XSD for validation from a path on the file system
        /// </summary>
        /// <param name="xsdPath"></param>
        public void AddSchemaPath(String xsdPath)
        {
            XmlReader xsdReader = XmlReader.Create(xsdPath);
            _schemas.Add(Namespace, xsdReader);
        }

        private XmlSchemaSet _schemas = new XmlSchemaSet();

        /// <summary>
        /// Validates a XML from a path on the filesystem
        /// </summary>
        /// <param name="xmlFilePath">
        /// The file path of the XML to validate
        /// </param>
        /// <exception cref="XmlSchemaValidationException">
        /// Thrown when the XML does not follow the XSD structure
        /// </exception>
        public void ValidateXmlPath(String xmlFilePath)
        {
            XmlReader xmlReader = XmlReader.Create(xmlFilePath);
            XDocument xmlDocument = XDocument.Load(xmlReader);
            xmlDocument.Validate(_schemas, (_, e) => throw new XmlSchemaValidationException(e.Message));
        }
    }  
}
