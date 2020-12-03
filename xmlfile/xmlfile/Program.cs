using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace xmlfile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var xmlDoc = new XmlDocument();
            xmlDoc.Load("..\\..\\book.xml");
            // Get list of nodes whose name is Book
            var nodeList = xmlDoc.DocumentElement.SelectNodes("/catalog/book");
            foreach (XmlNode node in nodeList)
            {
                // Read attribute value
                var isbn = node.Attributes["ISBN"].Value;
                // Read child node value
                var title = node.SelectSingleNode("title").InnerText;
                var price = node.SelectSingleNode("price").InnerText;
                // Read the descendant node value
                var firstName = node.SelectSingleNode("author/first-name").InnerText;
                var lastName = node.SelectSingleNode("author/last-name").InnerText;
                Console.WriteLine("{0,-15}{1,-50}{2,-15}{3,-15}{4,6}",
                isbn, title, firstName, lastName, price);
            }*/
            /*using (XmlWriter writer = XmlWriter.Create("book.xml"))
            {
                // Write Processing Instruction
                String pi = "type=\"text/xsl\" href=\"book.xsl\"";
                writer.WriteProcessingInstruction("xml-stylesheet", pi);
                // Write DocumentType
                writer.WriteDocType("catalog", null, null, "<!ENTITY h\"hardcover\">");

                // Write a Comment
                writer.WriteComment("This is a book sample XML");
                // Root element - start tag
                writer.WriteStartElement("book");
                // Write ISBN attribute
                writer.WriteAttributeString("ISBN", "9831123212");
                // Write year attribute
                writer.WriteAttributeString("yearpublished", "2002");
                // Write title
                writer.WriteElementString("author", "Mahesh Chand");
                // Write author
                writer.WriteElementString("title", "Visual C# Programming");
                // Write price
                writer.WriteElementString("price", "44.95");
                // Root element - end tag
                writer.WriteEndElement();
                // End Documentd
                writer.WriteEndDocument();
                // Flush it
                writer.Flush();
            }*/
            List<Book> book ;
            book.
            SaveToXmlFile(book);
        }
        public class Book
        {
            public string ISBN { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public decimal Price { get; set; }
            public int YearPublished { get; set; }
        }
        private static void SaveToXmlFile(List<Book> books)
        {
            var serializer = new XmlSerializer(typeof(List<Book>));
            using (var writer = new StreamWriter("book.xml"))
            {
                serializer.Serialize(writer, books, null);
                writer.Close();
            }
        }
    }
}
