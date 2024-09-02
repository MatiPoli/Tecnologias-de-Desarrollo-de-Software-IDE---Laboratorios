
bool opc = true;
while (opc) {
string mes = Console.ReadLine();;
    mes = mes.ToLower();
    switch (mes)
    {
        case "enero":
            Console.Write(1 + "\n");
            break;
        case "febrero":
            Console.Write(2 + "\n");
            break;
        case "marzo":
            Console.Write(3 + "\n");
            break;
        case "abril":
            Console.Write(4 + "\n");
            break;
        case "mayo":
            Console.Write(5 + "\n");
            break;
        case "junio":
            Console.Write(6 + "\n");
            break;
        case "julio":
            Console.Write(7 + "\n");
            break;
        case "agosto":
            Console.Write(8 + "\n");
            break;
        case "septiembre":
            Console.Write(9 + "\n");
            break;
        case "octubre":
            Console.Write(10 + "\n");
            break;
        case "noviembre":
            Console.Write(11 + "\n");
            break;
        case "diciembre":
            Console.Write(12 + "\n");
            break;
        default:
            opc = false;
            break;
    }
}