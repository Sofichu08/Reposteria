using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasteleria._02
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<Producto>> Recetas = new Dictionary<string, List<Producto>>();
            List<Producto> productos = new List<Producto>();
            //cambiar nombre de productos por el nombre de lo que es.cambiar Producto1 a Harina
            Producto producto1 = new Producto();
            producto1.nombre = "Harina";
            producto1.cantidad = 20;
            producto1.descrip = "Harina leudante ultrarefinada";
            Producto producto2 = new Producto();
            producto2.nombre = "Huevos";
            producto2.cantidad = 85;
            producto2.descrip = "De gallina tamaño mediano";
            Producto producto3 = new Producto();
            producto3.nombre = "Manteca";
            producto3.cantidad = 12;
            producto3.descrip = "Manteca pomada de 200grs";
            Producto producto4 = new Producto();
            producto4.nombre = "Leche";
            producto4.cantidad = 20;
            producto4.descrip = "Vacuna deslactosada";
            Producto producto5 = new Producto();
            producto5.nombre = "Azúcar";
            producto5.cantidad = 50;
            producto5.descrip = "Azúcar blanca";
            Producto producto6 = new Producto();
            producto6.nombre = "Limón";
            producto6.cantidad = 30;
            producto6.descrip = "Ralladura de limón";
            Producto producto7 = new Producto();
            producto7.nombre = "Esencia de vainilla";
            producto7.cantidad = 5;
            producto7.descrip = "Líquida";
            Producto producto8 = new Producto();
            producto8.nombre = "Cacao en polvo";
            producto8.cantidad = 30;
            producto8.descrip = "Cacao puro sin azúcar";

            productos.Add(producto1);
            productos.Add(producto2);
            productos.Add(producto3);
            productos.Add(producto4);
            productos.Add(producto5);
            productos.Add(producto6);
            productos.Add(producto7);
            productos.Add(producto8);

            // Recetas ya registradas 
            List<Producto> Bizcochuelo = new List<Producto>();
            Bizcochuelo.Add(new Producto { nombre = "Harina", cantidad = 5, descrip = "Harina leudante" });
            Bizcochuelo.Add(new Producto { nombre = "Huevos", cantidad = 3, descrip = "Huevos medianos" });
            Bizcochuelo.Add(new Producto { nombre = "Azúcar", cantidad = 2, descrip = "Azúcar blanca" });

            List<Producto> Brownie = new List<Producto>();
            Brownie.Add(new Producto { nombre = "Harina", cantidad = 5, descrip = "Harina leudante" });
            Brownie.Add(new Producto { nombre = "Huevos", cantidad = 3, descrip = "Huevos medianos" });
            Brownie.Add(new Producto { nombre = "Azúcar", cantidad = 2, descrip = "Azúcar blanca" });
            Brownie.Add(new Producto { nombre = "Cacao en polvo", cantidad = 1, descrip = "Cacao puro sin azúcar" });

            List<Producto> Cookies = new List<Producto>();
            Cookies.Add(new Producto { nombre = "Harina", cantidad = 1, descrip = "Harina leudante" });
            Cookies.Add(new Producto { nombre = "Huevos", cantidad = 2, descrip = "Huevos medianos" });
            Cookies.Add(new Producto { nombre = "Azúcar", cantidad = 1, descrip = "Azúcar blanca" });
            Cookies.Add(new Producto { nombre = "Esencia de vainilla", cantidad = 1, descrip = "Vainilla líquida" });

            List<Producto> Budin = new List<Producto>();
            Budin.Add(new Producto { nombre = "Harina", cantidad = 3, descrip = "Harina leudante" });
            Budin.Add(new Producto { nombre = "Huevos", cantidad = 4, descrip = "Huevos medianos" });
            Budin.Add(new Producto { nombre = "Azúcar", cantidad = 2, descrip = "Azúcar blanca" });
            Budin.Add(new Producto { nombre = "Esencia de vainilla", cantidad = 1, descrip = "Vainilla líquida" });
            Budin.Add(new Producto { nombre = "Cacao en polvo", cantidad = 1, descrip = "Cacao sin azúcar" });


            Recetas.Add("Brownie", Brownie);
            Recetas.Add("Bizcochuelo", Bizcochuelo);
            Recetas.Add("Cookies de vainilla", Cookies);
            Recetas.Add("Budin marmolado", Budin);

            Console.Title = "Gestor de Pastelería";
            bool seguir = true;
            string produ;
            bool existe = false;
            int n;
            string canti;
            string nombreReceta;

            while (seguir)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                //muestro opciones
                Console.WriteLine("-------------------------------------");
                Console.WriteLine(" \t MENÚ");
                Console.WriteLine("1.Agregar nuevo producto");// Verificar si el producto esta, si no se pide agregar nombre, cant y descript
                Console.WriteLine("2.Modificar cant de un producto"); // Ingresar el nom y cambiar la cantidad
                Console.WriteLine("3.Ver inventario de productos"); //Muestra el inventario ya disponible
                Console.WriteLine("4.Ver recetas"); //Permite ver las recetas disponibles
                Console.WriteLine("5.Agregar receta"); //Se agrega nombre + ingredientes (si es necesario)
                Console.WriteLine("6.Elegir una receta y verificar si es posible hacerla"); //si es posible se eliminan cantidad del inventario
                Console.WriteLine("7.Salir del programa"); //Sale de la tecla presionando un boton
                Console.Write("Elegir opción: ");
                string opcion = Console.ReadLine();
                Console.WriteLine("-------------------------------------");
                Console.ResetColor();
                bool mod = false;
                string nuevareceta;
                string recetaElegida;
                string noming;
                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el nombre del producto: ");
                        produ = Console.ReadLine();
                        produ = produ.ToLower();

                        foreach (Producto p in productos)
                        {
                            if (produ == p.nombre)
                            {
                                Console.WriteLine("El producto ya se encuentra registrado");
                                existe = true;
                            }
                        }

                        if (existe == false)
                        {
                            Producto nuevoProducto = new Producto();
                            nuevoProducto.nombre = produ;

                            Console.Write("Ingrese la cantidad: ");
                            nuevoProducto.cantidad = int.Parse(Console.ReadLine());

                            Console.Write("Ingrese una descripción: ");
                            nuevoProducto.descrip = Console.ReadLine();

                            productos.Add(nuevoProducto);

                            Console.WriteLine("El producto ha sido agragado exitosamente");
                        }
                        break;

                    case "2":
                        Console.WriteLine("¿Cuál producto desea modificar?");
                        canti = Console.ReadLine();

                        foreach (Producto p in productos)
                        {
                            if (p.nombre == canti)
                            {
                                Console.WriteLine("Ingrese nueva cantidad:");
                                n = int.Parse(Console.ReadLine());
                                p.cantidad = n;
                                mod = true;
                                Console.WriteLine("El producto se módifico exitosamente.");
                            }
                        }
                        ;

                        if (mod != true)
                        {
                            Console.WriteLine("El producto no se encuentra registrado");
                        }
                        break;

                    case "3":

                        if (productos.Count == 0)
                        {
                            Console.WriteLine("La lista está vacía");
                        }
                        else
                        {
                            Console.WriteLine("\t Inventario de productos:");
                            Console.WriteLine("Producto | Cantidad | Descripción");
                            Console.WriteLine("---------------------------------------");
                            foreach (Producto p in productos)
                            {   
                                Console.WriteLine(p);
                            }
                        }
                       
                        break;

                    case "4":
                        Console.WriteLine("Recetas disponibles:");
                        foreach (var r in Recetas.Keys)
                        {
                            Console.WriteLine($"* {r}");
                        }

                        Console.Write("\n Ingrese el nombre de una receta para ver los ingredientes: ");
                        nombreReceta = Console.ReadLine();

                        if (Recetas.ContainsKey(nombreReceta))
                        {
                            Console.WriteLine($"Receta: {nombreReceta}");
                            Console.WriteLine("Ingredientes:");
                            Console.WriteLine("Producto | Cantidad | Descripción");
                            Console.WriteLine("---------------------------------------");

                            foreach (Producto ing in Recetas[nombreReceta])
                            {
                                Console.WriteLine(ing);
                            }
                        }
                        else
                        {
                            Console.WriteLine("La receta no existe.");
                        }
                        break;        
               
                    
                    case "5":
                        Console.Write("Ingrese el nombre de la receta: ");
                        nuevareceta = Console.ReadLine();

                        if (Recetas.ContainsKey(nuevareceta))
                        {
                            Console.WriteLine("Esta receta ya se encuentra registrada");
                        }
                        else
                        {
                            List<Producto> ingredientesNuevaReceta = new List<Producto>();
                            bool mas = true;

                            while (mas)
                            {
                                Console.Write("Ingrese el nombre del ingrediente (o 'fin' para terminar): ");
                                noming = Console.ReadLine();
                                string descripcion = "";
                                bool existeEnInventario = false;
                                if (noming.ToLower() == "fin") break;

                                foreach (Producto p in productos)
                                {
                                    if (p.nombre.ToLower() == noming.ToLower())
                                    {
                                        existeEnInventario = true;
                                        descripcion = p.descrip;
                                        break;
                                    }
                                }

                                if (!existeEnInventario)
                                {
                                    Console.WriteLine("El ingrediente no existe. Se debe agregar al inventario primero.");
                                    continue;
                                }

                             

                                int cantidadIngrediente;
                                Console.Write("Ingrese la cantidad necesaria para la receta: ");
                                try
                                {
                                    cantidadIngrediente = int.Parse(Console.ReadLine());
                                    if (cantidadIngrediente <= 0)
                                    {
                                        Console.WriteLine("La cantidad debe ser mayor a 0.");
                                        continue;
                                    }
                                }
                                catch
                                {
                                    Console.WriteLine("Ingreso incorrecto. Debe ser un número.");
                                    continue;
                                }

                             

   
                                // agregar ingrediente a la receta
                                Producto ingrediente = new Producto
                                {
                                    nombre = noming,
                                    cantidad = cantidadIngrediente,
                                    descrip = descripcion
                                };

                                ingredientesNuevaReceta.Add(ingrediente);
                            }

                            if (ingredientesNuevaReceta.Count > 0)
                            {
                                Recetas.Add(nuevareceta, ingredientesNuevaReceta);
                                Console.WriteLine($"Receta '{nuevareceta}' creada con éxito.");
                            }
                            else
                            {
                                Console.WriteLine("No se agregaron ingredientes. Receta no guardada.");
                            }
                        }
                        break;

                    case "6":
                        Console.WriteLine("Recetas disponibles:");
                        foreach (var r in Recetas.Keys)
                        {
                            Console.WriteLine($"* {r}");
                        }

                        Console.Write("Ingrese el nombre de la receta que desea preparar: ");
                        recetaElegida = Console.ReadLine();

                        if (!Recetas.ContainsKey(recetaElegida))
                        {
                            Console.WriteLine("La receta no existe.");
                            break;
                        }
                        foreach (var r in Recetas)
                        {
                            if (r.Key == recetaElegida)
                            {
                                foreach (var e in r.Value)
                                {
                                    Console.WriteLine(e);
                                }
                            }
                        }
                        List<Producto> ingredientesNecesarios = Recetas[recetaElegida]; //creamos lista de los productos necesarios para hacer coparación con los disponibles 
                        bool preparar = true;

                        // Verificar si los ingredientes estan 
                        foreach (Producto ing in ingredientesNecesarios)
                        {
                            bool encontrado = false;

                            foreach (Producto prod in productos)
                            {
                                if (prod.nombre.ToLower() == ing.nombre.ToLower())
                                {
                                    encontrado = true;

                                    if (prod.cantidad < ing.cantidad)
                                    {
                                        Console.WriteLine($"No hay suficiente {ing.nombre}. Necesita {ing.cantidad}, pero hay {prod.cantidad}.");
                                        preparar = false;
                                    }

                                    break; 
                                }
                            }

                            if (!encontrado)
                            {
                                Console.WriteLine($"Falta el ingrediente: {ing.nombre}");
                                preparar = false;
                            }
                        }

                        // Si se puede preparar, descontamos ingredientes 
                        if (preparar)
                        {
                            foreach (Producto ing in ingredientesNecesarios)
                            {
                                for (int i = 0; i < productos.Count; i++)
                                {
                                    if (productos[i].nombre.ToLower() == ing.nombre.ToLower())
                                    {
                                        productos[i].cantidad -= ing.cantidad;
                                        break;
                                    }
                                }
                            }

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"La receta '{recetaElegida}' se puede realizar. Se descontaron los ingredientes del inventario.");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No se puede preparar la receta. Faltan ingredientes o cantidades insuficientes.");
                            Console.ResetColor();
                        }

                        break;

                    case "7":
                        Console.WriteLine("Saliendo del programa...");
                        Console.WriteLine("Presione una tecla para salir...");
                        Console.ReadKey();
                        seguir = false;
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta");
                        break;
                }
            }
        }
    }
}