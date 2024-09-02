using System.IO;
using System.Xml;


// Escribir();
// Leer();

Console.WriteLine("Presione una tecla para generar el archivo xml");
Console.ReadKey();
escribirXML();
Console.WriteLine("Archivo xml generado correctamente!");
Console.ReadKey();
Console.WriteLine();
leerXML();
Console.ReadKey();

static void Leer()
{
    /*
    FileStream lector = new FileStream("agenda.txt",FileMode.Open,FileAccess.Read,FileShare.Read);

    while (lector.Length > lector.Position)
    {
        Console.Write((char)lector.ReadByte());
    }
    lector.Close();
    Console.ReadKey();
    */

    StreamReader lector = File.OpenText("agenda.txt");
    string linea;
    Console.WriteLine("Nombre\tApellido\te-mail\t\t\tTelefono");
    do
    {
        linea = lector.ReadLine();
        if (linea != null)
        {
            //Console.WriteLine(linea)
            string[] valores = linea.Split(';');
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", valores[0], valores[1], valores[2], valores[3]);
        }
    }
    while (linea != null);
    lector.Close();
}

static void Escribir()
{
    StreamWriter escritor = File.AppendText("agenda.txt");
    Console.WriteLine("Ingrese nuevos contactos");
    string rta = "S";
    while (rta == "S")
    {
        Console.WriteLine("Ingrese nombre: ");
        string nombre = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Ingrese apellido: ");
        string apellido = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Ingrese e-mail: ");
        string email = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Ingrese telefono: ");
        string telefono = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine();

        escritor.WriteLine(nombre + ";" + apellido + ";" + email + ";" + telefono);
        Console.WriteLine("Desea ingresar otro contacto? (S/N)");
        rta = Console.ReadLine();
    }
    escritor.Close();
}

static void escribirXML()
{
    XmlTextWriter escritorXML = new XmlTextWriter("agendaxml.xml", null);
    escritorXML.Formatting = Formatting.Indented;
    escritorXML.WriteStartDocument(true);
    escritorXML.WriteStartElement("DocumentElement");

    StreamReader lector = File.OpenText("agenda.txt");
    string linea;
    do
    {
        linea = lector.ReadLine();
        if (linea != null)
        {
            string[] valores = linea.Split(';');
            escritorXML.WriteStartElement("contactos");
            escritorXML.WriteStartElement("nombre");
            escritorXML.WriteValue(valores[0]);
            escritorXML.WriteEndElement();
            escritorXML.WriteStartElement("apellido");
            escritorXML.WriteValue(valores[1]);
            escritorXML.WriteEndElement();
            escritorXML.WriteStartElement("email");
            escritorXML.WriteValue(valores[2]);
            escritorXML.WriteEndElement();
            escritorXML.WriteStartElement("telefono");
            escritorXML.WriteValue(valores[3]);
            escritorXML.WriteEndElement();
            escritorXML.WriteEndElement();
        }
    }
    while(linea != null);
    escritorXML.WriteEndElement();
    escritorXML.WriteEndDocument();
    escritorXML.Close();

    lector.Close();
}

static void leerXML()
{
    XmlTextReader lectorXML = new XmlTextReader("agendaxml.xml");

    string tagAnterior = "";
    while (lectorXML.Read())
    {
        if(lectorXML.NodeType == XmlNodeType.Element)
        {
            tagAnterior = lectorXML.Name;
        }
        else if(lectorXML.NodeType == XmlNodeType.Text)
        {
            Console.WriteLine(tagAnterior + ": " + lectorXML.Value);
        }
    }
    lectorXML.Close();
}