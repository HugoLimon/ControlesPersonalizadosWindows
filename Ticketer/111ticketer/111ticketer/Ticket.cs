using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.InteropServices;

namespace _111ticketer
{
    class Ticket
    {
        //esta clase es para crear un ticket de venta
        /*StringBuilder linea = new StringBuilder();
        StringBuilder Titulo = new StringBuilder();
        StringBuilder Subtitulos= new StringBuilder();*/
        List<KeyValuePair<int, string>> lstContenido = new List<KeyValuePair<int, string>>(); //la clave corresponde al tipo de texto 0 para titulos, 1 Subtitulos, 2 contenido, 3 pie de página  
        Image imgEncabezado = null;
        public Ticket()
        {

        }
        //maximo de caracteres que acepta la kimpresora
        int cortar; // la variable cortar cortará la cadena cuando rebace el maxioa
        int maxCarFont15 = 23;
        int maxCarFont12 = 28;
        int maxCarFont10 = 34;
        int maxCarFont8 = 41;


        // etse metodo dibujara lines guion
        public void lineaGuion(int _tipoTexto)
        {
            int maxCar;
            switch (_tipoTexto)
            {
                case 0:
                    maxCar = maxCarFont15;
                    break;
                case 1:
                    maxCar = maxCarFont12;
                    break;
                case 2:
                    maxCar = maxCarFont10;
                    break;
                default:
                    maxCar = maxCarFont8;
                    break;
            }
            string _lineasGuion = "";
            for (int i = 0; i < maxCar; i++)
            {
                _lineasGuion += "-"; // agregaremos hasta llegar al maximo del la linea
            }
            lstContenido.Add(new KeyValuePair<int, string>(_tipoTexto, _lineasGuion));
        }

        //metodo para dibujar linea con signo igual
        public void lineaAsteriscos(int _tipoTexto)
        {
            int maxCar;
            switch (_tipoTexto)
            {
                case 0:
                    maxCar = maxCarFont15;
                    break;
                case 1:
                    maxCar = maxCarFont12;
                    break;
                case 2:
                    maxCar = maxCarFont10;
                    break;
                default:
                    maxCar = maxCarFont8;
                    break;
            }
            string lineasAsterisco = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasAsterisco += "*"; // agregaremos hasta llegar al maximo del la linea
            }
            lstContenido.Add(new KeyValuePair<int, string>(_tipoTexto, lineasAsterisco));
        }

        //metodo para dibujar linea con puntos
        public void lineaPuntos(int _tipoTexto)
        {
            int maxCar;
            switch (_tipoTexto)
            {
                case 0:
                    maxCar = maxCarFont15;
                    break;
                case 1:
                    maxCar = maxCarFont12;
                    break;
                case 2:
                    maxCar = maxCarFont10;
                    break;
                default:
                    maxCar = maxCarFont8;
                    break;
            }
            string lineasAsterisco = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasAsterisco += "."; // agregaremos hasta llegar al maximo del la linea
            }
            lstContenido.Add(new KeyValuePair<int, string>(_tipoTexto, lineasAsterisco));
        }

        //metodo para dibujar linea con signo igual
        public void lineaIgual(int _tipoTexto)
        {
            int maxCar;
            switch (_tipoTexto)
            {
                case 0:
                    maxCar = maxCarFont15;
                    break;
                case 1:
                    maxCar = maxCarFont12;
                    break;
                case 2:
                    maxCar = maxCarFont10;
                    break;
                default:
                    maxCar = maxCarFont8;
                    break;
            }
            string lineasIgual = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasIgual += "="; // agregaremos hasta llegar al maximo del la linea
            }
            lstContenido.Add(new KeyValuePair<int, string>(_tipoTexto, lineasIgual));
        }

        //creamos el encabezado para los articulos
        public void encabezadoVenta(int _tipoTexto)
        {
            lstContenido.Add(new KeyValuePair<int, string>(_tipoTexto, "ARTICULOS  |CANT| PRECIO| IMPORTE"));
        }

        //creamos el metodo para poner el texto a la izquierda
        public void textoIzquierda(int _tipoTexto, string texto)
        {
            int maxCar = 48;
            switch (_tipoTexto)
            {
                case 0:
                    maxCar = maxCarFont15;
                    break;
                case 1:
                    maxCar = maxCarFont12;
                    break;
                case 2:
                    maxCar = maxCarFont10;
                    break;
                default:
                    maxCar = maxCarFont8;
                    break;
            }

            if (texto.Length > maxCar)
            {
                int caracterActual = 0;
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    //agregamos el primer fargemto de texto
                    lstContenido.Add(new KeyValuePair<int, string>(_tipoTexto, texto.Substring(caracterActual, maxCar)));
                    caracterActual += maxCar;
                }
                //agregamos  fragmento restante
                lstContenido.Add(new KeyValuePair<int, string>(_tipoTexto, texto.Substring(caracterActual, texto.Length - caracterActual)));

            }
            else
            {
                lstContenido.Add(new KeyValuePair<int, string>(_tipoTexto, texto));
            }
        }

        //creamos un metodo pra agregar texto a la derecha
        public void textoDerecha(int _tipoTexto, string texto)
        {
            int maxCar = 48;
            switch (_tipoTexto)
            {
                case 0:
                    maxCar = maxCarFont15;
                    break;
                case 1:
                    maxCar = maxCarFont12;
                    break;
                case 2:
                    maxCar = maxCarFont10;
                    break;
                default:
                    maxCar = maxCarFont8;
                    break;
            }
            //si la longitud del texto es mayoar al nuemro maximo de caracteres, realizar el sig procedimiento
            if (texto.Length > maxCar)
            {
                int caracterActual = 0;//nos indicara en que caracter se quedo al bajar de linea
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    //agregamos los gragmetos que salgan del texto
                    lstContenido.Add(new KeyValuePair<int, string>(_tipoTexto, texto.Substring(caracterActual, maxCar)));
                    caracterActual += maxCar;
                }
                //variable para poner espacios restantes
                string espacios = "";
                //obtenemos la longitud del texto restante
                for (int i = 0; i < (maxCar - texto.Substring(caracterActual, texto.Length - caracterActual).Length); i++)
                {
                    espacios += " ";//aregramos espacios para alinear a la derecha
                }
                //agrgamos el fragmento restante antes de los espacios

                lstContenido.Add(new KeyValuePair<int, string>(_tipoTexto, espacios + texto.Substring(caracterActual, texto.Length - caracterActual)));
            }
            else
            {
                string espacios = "";
                //obtenemos la longitud del texto restante
                for (int i = 0; i < (maxCar - texto.Length); i++)
                {
                    espacios += " ";//aregramos espacios para alinear a la derecha
                }
                //sino es mayor 
                lstContenido.Add(new KeyValuePair<int, string>(_tipoTexto, espacios + texto));
            }

        }

        //metodo para centrar el texto
        public void textoCentro(int _tipoTexto, string texto)
        {
            int maxCar = 48;
            switch (_tipoTexto)
            {
                case 0:
                    maxCar = maxCarFont15;
                    break;
                case 1:
                    maxCar = maxCarFont12;
                    break;
                case 2:
                    maxCar = maxCarFont10;
                    break;
                default:
                    maxCar = maxCarFont8;
                    break;
            }
            //si la longitud del texto es mayoar al nuemro maximo de caracteres, realizar el sig procedimiento
            if (texto.Length > maxCar)
            {
                int caracterActual = 0;//nos indicara en que caracter se quedo al bajar de linea
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    //agregamos los gragmetos que salgan del texto

                    lstContenido.Add(new KeyValuePair<int, string>(_tipoTexto, texto.Substring(caracterActual, maxCar)));
                    caracterActual += maxCar;
                }
                //variable para poner espacios restantes
                string espacios = "";
                //Sacamos la cantidad de espacios libres y los dividimos entre 2
                int centrar = (maxCar - texto.Substring(caracterActual, texto.Length - caracterActual).Length) / 2;
                //obtenemos la longitud del texto restante
                for (int i = 0; i < centrar; i++)
                {
                    espacios += " ";//aregramos espacios para alinear a la derecha
                }
                //agrgamos el fragmento restante antes de los espacios

                lstContenido.Add(new KeyValuePair<int, string>(_tipoTexto, espacios + texto.Substring(caracterActual, texto.Length - caracterActual)));
            }
            else
            {
                string espacios = "";
                //Sacamos la cantidad de espacios libres y los dividimos entre 2
                int centrar = (maxCar - texto.Length) / 2;
                //obtenemos la longitud del texto restante
                for (int i = 0; i < centrar; i++)
                {
                    espacios += " ";//aregramos espacios para alinear a la derecha
                }
                //agrgamos el fragmento restante antes de los espacios

                lstContenido.Add(new KeyValuePair<int, string>(_tipoTexto, espacios + texto));

            }
        }

        //metodo para poner texto a los extremos
        public void textoExtremos(int _tipoTexto, string textoIzquierdo, string textoDerecho)
        {
            string textoIzq, textoDer, textoCompleto, espacios = "";

            int maxCar = 48;
            switch (_tipoTexto)
            {
                case 0:
                    maxCar = maxCarFont15;
                    break;
                case 1:
                    maxCar = maxCarFont12;
                    break;
                case 2:
                    maxCar = maxCarFont10;
                    break;
                default:
                    maxCar = maxCarFont8;
                    break;
            }

            //si el texto es mayor a 18, cortamos el texto
            if (textoIzquierdo.Length > (maxCar / 2) - 3)
            {
                cortar = textoIzquierdo.Length - ((maxCar / 2));
                textoIzq = textoIzquierdo.Remove(((maxCar / 2)), cortar);

            }
            else
            {
                textoIzq = textoIzquierdo;
            }
            textoCompleto = textoIzq; // agregamos el primer texto
            if (textoDerecho.Length > (maxCar / 2)) //si es mayor a 20 l cortamos
            {
                cortar = textoDerecho.Length - ((maxCar / 2));
                textoDer = textoDerecho.Remove(((maxCar / 2)), cortar);
            }
            else
            {
                textoDer = textoDerecho;
            }
            //obtenemos el nuemero de espacios restantes para poner eltextoDerecho al final
            int noEspacios = maxCar - (textoIzq.Length + textoDer.Length);
            for (int i = 0; i < noEspacios; i++)
            {
                espacios += " "; //agregamos los espacios para poner el textoDerecho al final
            }
            textoCompleto += espacios + textoDer; //agreamos el segundo texto
            lstContenido.Add(new KeyValuePair<int, string>(_tipoTexto, textoCompleto));

        }

        //metodo para agregar los totales de la venta
        public void agregaTotales(int _tipoTexto, string texto, decimal total)
        {
            int maxCar = 48;
            switch (_tipoTexto)
            {
                case 0:
                    maxCar = maxCarFont15;
                    break;
                case 1:
                    maxCar = maxCarFont12;
                    break;
                case 2:
                    maxCar = maxCarFont10;
                    break;
                default:
                    maxCar = maxCarFont8;
                    break;
            }
            //variables que usaremos
            string resumen, valor, textoCompleto, espacios = "";
            if (texto.Length > maxCar / 2)//si es mayor a la mitar del maximo
            {
                cortar = texto.Length - maxCar / 2;
                resumen = texto.Remove(maxCar / 2, cortar);

            }
            else
            {
                resumen = texto;
            }
            textoCompleto = resumen;
            valor = total.ToString("#,#.00");//previo formateo
                                             //obtenemos los espacios restantes para alinerlo a la derecha
            int noEspacios = maxCar - (resumen.Length + valor.Length);
            //agregamos los espacios
            for (int i = 0; i < noEspacios; i++)
            {
                espacios += " ";
            }
            textoCompleto += valor;
            lstContenido.Add(new KeyValuePair<int, string>(_tipoTexto, espacios + textoCompleto));


        }//*

        //metodo para agregar articulos al ticket de venta
        public void agregaArticulo(int _tipoTexto, string articulo, int cant, decimal precio, decimal importe)
        {
            int maxCar = 48;
            switch (_tipoTexto)
            {
                case 0:
                    maxCar = maxCarFont15;
                    break;
                case 1:
                    maxCar = maxCarFont12;
                    break;
                case 2:
                    maxCar = maxCarFont10;
                    break;
                default:
                    maxCar = maxCarFont8;
                    break;
            }
            //valida que el precio y el importe esten dentro del rango
            if (cant.ToString().Length <= 5 && precio.ToString().Length <= 8 && importe.ToString().Length <= 8)
            {
                string elemento = "", espacios = "";
                bool bandera = false; // indica si el la primera linea que se escribe cuando bajemos al segunda, si el nombre del articulo no entra en laprimera linea
                int noEspacios = 0;
                //si el nombre descripcion del articulo es mayor a 20, bajar a la siguiente linea
                if (articulo.Length > 11)
                {
                    noEspacios = (5 - cant.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < noEspacios; i++)
                    {
                        espacios = " ";
                    }
                    elemento += espacios + cant.ToString(); // agregasmo la cantidad con los espacios

                    // coloca el precio a la derecha
                    noEspacios = (7 - precio.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < noEspacios; i++)
                    {
                        espacios = " ";
                    }
                    elemento += espacios + precio.ToString();// agregamos el precio

                    //coloca el importe a la derecha
                    noEspacios = (8 - importe.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < noEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + importe.ToString(); //agegamos el importe alinendo ala derecha

                    int caracterActual = 0; //indica en que caracter se quedo al bajar a la sig linea

                    //por cada 20 caracteres se agregara una linea siguiente
                    for (int longitudTexto = articulo.Length; longitudTexto > 20; longitudTexto -= 20)
                    {
                        if (bandera == false)//si es falso o la primera linea recorrera, contunuar...
                        {
                            //agregamos los primeros 20 caracteres del articulo, mas lo que ya tiene la variable elemento

                            lstContenido.Add(new KeyValuePair<int, string>(_tipoTexto, articulo.Substring(caracterActual, 20) + elemento));
                            bandera = true;
                        }
                        else
                        {

                            lstContenido.Add(new KeyValuePair<int, string>(_tipoTexto, articulo.Substring(caracterActual, 20)));
                        }
                        caracterActual += 20;
                    }

                    lstContenido.Add(new KeyValuePair<int, string>(_tipoTexto, articulo.Substring(caracterActual, articulo.Length - caracterActual)));
                }
                else // si no es mayor solo agregar sin saltos de linea
                {
                    for (int i = 0; i < 11 - articulo.ToString().Length; i++)
                    {
                        espacios += " ";
                    }
                    elemento = articulo + espacios;

                    //colocar la cantidad a la deracha
                    noEspacios = (5 - cant.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < noEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + cant.ToString();

                    //colocamos el precio a la derecha
                    noEspacios = (8 - precio.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < noEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + precio.ToString();

                    //colocamos el importe ala derecha
                    noEspacios = (8 - importe.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < importe.ToString().Length; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + importe.ToString();

                    lstContenido.Add(new KeyValuePair<int, string>(_tipoTexto, elemento));
                }
            }
            else
            {

                lstContenido.Add(new KeyValuePair<int, string>(_tipoTexto, "Los valores ingresaodos para esta fila"));

                lstContenido.Add(new KeyValuePair<int, string>(_tipoTexto, "superan las columnas soportadas por este."));
                throw new Exception("Los valores ingresados para algunas filas del tiket\nsuperan las soportadas por este.");

            }

        }

        //Fija la imagen del encabezado
        public void agregaImagen(Image _img)
        {
            imgEncabezado = _img;
        }

        //metodos para enviar secuencia de escape a la impresora
        //para cortar ticket
        public void cortaTicket()
        {
            //linea.AppendLine("\x1B" + "d" + "\x04");//Avanza 9 renglones, tambien varian
            //linea.AppendLine("\x1B" + "m"); //Caracter de corte. Estos comandos varian seguen el tipo de impresora


        }

        //para abrir el cajon
        public void abreCajon()
        {
            //estos tambien varian, hay que ver en el manual de la impresora
            //linea.AppendLine("\x1B" + "p" + "\x00" + "\x0F" + "\x96");//apertura cajon 0
            //linea.AppendLine("\x1B" + "p" + "\x01" + "\x0F" + "\x96");//apertura cajon 1
        }
        public void imprimirTicket(string impresora)
        {
            //este modo recibe el nombre de la impresora a la cual se mandara a imprimir y el textoque se imprima 
            //Usaremos codigo que nos proporciona Microsoft. hhtps://support.microsoft.com/es-es/kb/322091
            //RawPrinterHelper.SendStringToPrinter(impresora, linea.ToString());
            //linea.Clear();
        }
        //Metodo para imprimir un ticket de manera personalizada, se pueden cambiar, tamaño de la letra, tipografia y impresión de imagenes
        public void imprimirCustomTicket(string impresora)
        {
            //utilizamos una clase de impresion de documenmtos, donde se configura la hoja de impresion
            var printDocument = new PrintDocument();
            printDocument.PrinterSettings.PrinterName = impresora;
            printDocument.PrinterSettings.DefaultPageSettings.Margins.Left = 0;
            printDocument.PrinterSettings.DefaultPageSettings.Margins.Top = 0;
            printDocument.PrinterSettings.DefaultPageSettings.Margins.Right = 0;
            printDocument.PrinterSettings.DefaultPageSettings.Margins.Bottom = 0;
            printDocument.DefaultPageSettings.PaperSize = new PaperSize("A4", 50, 10);
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            try
            {
                printDocument.Print();
            }
            catch (InvalidPrinterException)
            {
            }
            finally
            {
                printDocument.Dispose();
            }
        }

        private void imprimeTitulo(PrintPageEventArgs e, string texto, float posY)
        {
            var printContent = texto;
            var printFont = new Font("Courier New", 15, System.Drawing.FontStyle.Regular);
            var printColor = System.Drawing.Brushes.Black;
            e.Graphics.DrawString(printContent, printFont, printColor, 0f, posY);
        }
        private void imprimeSubtitulo(PrintPageEventArgs e, string texto, float posY)
        {
            var printContent = texto;
            var printFont = new Font("Courier New", 12, System.Drawing.FontStyle.Regular);
            var printColor = System.Drawing.Brushes.Black;

            e.Graphics.DrawString(printContent, printFont, printColor, 0f, posY);
        }
        private void imprimeContenido(PrintPageEventArgs e, string texto, float posY)
        {
            var printContent = texto;
            var printFont = new Font("Courier New", 10, System.Drawing.FontStyle.Regular);
            var printColor = System.Drawing.Brushes.Black;
            e.Graphics.DrawString(printContent, printFont, printColor, 0f, posY);
        }
        private void imprimePieDePagina(PrintPageEventArgs e, string texto, float posY)
        {
            var printContent = texto;
            var printFont = new Font("Courier New", 8, System.Drawing.FontStyle.Regular);
            var printColor = System.Drawing.Brushes.Black;
            e.Graphics.DrawString(printContent, printFont, printColor, 0f, posY);
        }

        //creamos un documento que imprime de maenra personalizada una pagina
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {

            if (imgEncabezado != null)
            {
                RectangleF rImage = new RectangleF(90, 90, 90, 90);
                e.Graphics.DrawImage(imgEncabezado, 0f, 0f, 200f, 90f);
            }

            float posy = 100;
            foreach (KeyValuePair<int, string> _k in lstContenido)
            {
                switch (_k.Key)
                {
                    case 0:
                        imprimeTitulo(e, _k.Value, posy);
                        posy += 20f;
                        break;
                    case 1:
                        imprimeSubtitulo(e, _k.Value, posy);
                        posy += 18f;
                        break;
                    case 2:
                        imprimeContenido(e, _k.Value, posy);
                        posy += 16f;
                        break;
                    default:
                        imprimePieDePagina(e, _k.Value, posy);
                        posy += 14f;
                        break;
                }
            }




            //Set FontStyle of the text to print
            /*printFont = new Font("Arial", 12, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            e.Graphics.DrawString(printContent, printFont, printColor, 10f, pointY += 20f);
            printFont = new Font("Arial", 12, System.Drawing.FontStyle.Regular);
            e.Graphics.ScaleTransform(0.6f, 1.0f);
            e.Graphics.DrawString(printContent, printFont, printColor, 10f, pointY += 20f);
            e.Graphics.ScaleTransform(1 / 0.6f, 1.0f);
            e.Graphics.DrawString(printContent, printFont, printColor, 10f, pointY += 20f);*/
            //var status = e.Graphics.Save();
            /*e.Graphics.ScaleTransform(0.6f, 1.0f);
            e.Graphics.DrawString(printContent, printFont, printColor, 10f, pointY += 20f);
            e.Graphics.Restore(status);
            e.Graphics.DrawString(printContent, printFont, printColor, 10f, pointY += 20f);*/
            //e.HasMorePages = false;
        }
    }




    //clase para mandar imprimir texto plano a la impresora

    public class RawPrinterHelper
    {
        // Structure and API declarions:
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public class DOCINFOA
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDocName;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pOutputFile;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDataType;
        }
        [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

        [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

        // SendBytesToPrinter()
        // When the function is given a printer name and an unmanaged array
        // of bytes, the function sends those bytes to the print queue.
        // Returns true on success, false on failure.
        public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
        {
            Int32 dwError = 0, dwWritten = 0;
            IntPtr hPrinter = new IntPtr(0);
            DOCINFOA di = new DOCINFOA();
            bool bSuccess = false; // Assume failure unless you specifically succeed.

            di.pDocName = "Ticket de venta"; // nombre del archivo en caso de no imprimir
            di.pDataType = "RAW"; // de tipo texto plano

            // Open the printer.
            if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
            {
                // Start a document.
                if (StartDocPrinter(hPrinter, 1, di))
                {
                    // Start a page.
                    if (StartPagePrinter(hPrinter))
                    {
                        // Write your bytes.
                        bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                        EndPagePrinter(hPrinter);
                    }
                    EndDocPrinter(hPrinter);
                }
                ClosePrinter(hPrinter);
            }
            // If you did not succeed, GetLastError may give more information
            // about why not.
            if (bSuccess == false)
            {
                dwError = Marshal.GetLastWin32Error();
            }
            return bSuccess;
        }


        public static bool SendStringToPrinter(string szPrinterName, string szString)
        {
            IntPtr pBytes;
            Int32 dwCount;
            // How many characters are in the string?
            dwCount = szString.Length;
            // Assume that the printer is expecting ANSI text, and then convert
            // the string to ANSI text.
            pBytes = Marshal.StringToCoTaskMemAnsi(szString);
            // Send the converted ANSI string to the printer.
            SendBytesToPrinter(szPrinterName, pBytes, dwCount);
            Marshal.FreeCoTaskMem(pBytes);
            return true;
        }
    }

}

