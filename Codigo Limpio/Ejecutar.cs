using Codigo_Limpio.AbstracFactory.AFEjemplo1;
using Codigo_Limpio.AbstracFactory.AFEjemplo1.Factory;
using Codigo_Limpio.AbstracFactory.Ejemplo2;
using Codigo_Limpio.AbstracFactory.Ejemplo2._2;
using Codigo_Limpio.AbstracFactory.Ejemplo2._2.InterfazPago;
using Codigo_Limpio.AbstracFactory.Ejemplo2._2.LaFactoria;
using Codigo_Limpio.AbstracFactory.Ejercicio3;
using Codigo_Limpio.AbstracFactory.Ejercicio3.Fabrica;
using Codigo_Limpio.AbstracFactory.Ejercicio3.implementaciones;
using Codigo_Limpio.AbstracFactory.Ejercicio3.PaimentServices;
using Codigo_Limpio.Ejercicio3;
using Codigo_Limpio.Estructural.Adapter;
using Codigo_Limpio.Estructural.Adapter.Ejercicio1;
using Codigo_Limpio.Estructural.Adapter.Ejercicio1.Database;
using Codigo_Limpio.Estructural.Adapter.Ejercicio1.Intermediario;
using Codigo_Limpio.Estructural.Adapter.ejercicio2;

using Codigo_Limpio.FactoryMethod;
using Codigo_Limpio.FactoryMethod.Ejercicio1;
using Codigo_Limpio.FactoryMethod.Ejercicio1.implementacion;
using Codigo_Limpio.FactoryMethod.Ejercicio1.interfaz;
using Codigo_Limpio.FactoryMethod.Ejercicio2.Producto;
using Codigo_Limpio.FactoryMethod.Factories;
using Codigo_Limpio.FactoryMethod.Producto.Factory;
using Codigo_Limpio.PatronBuilder;
using Codigo_Limpio.PatronBuilder.ejecicio;
using Codigo_Limpio.PatronBuilder.ejercicio2;
using Codigo_Limpio.Prototype.Ejemplo1;
using Codigo_Limpio.Prototype.Ejemplo2.EjemploPrototype1.Clonables.Modelos;
using Codigo_Limpio.Prototype.Ejemplo3.prototypos;
using System.Xml.Linq;
using HombreLobo = Codigo_Limpio.Prototype.Ejemplo2.EjemploPrototype1.Clonables.Modelos.HombreLobo;

//IModelo modelo = new Plano();
//CasaCampoEconomica casa = new (modelo);

//casa.ConstruirCasa();


//Modelo ejemplo =  modelo.GetModelo();
//ejemplo.MostrarCasa();


//// rutina de ejericio 
//Entrenamiento entrenamiento = new ImplementarRutina();
//Rutina rutina = new Rutina(entrenamiento);
//rutina.Ruta();

Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("--------------------------------------------------------------");

// comida en la ma;ana 
DirectorTemprano director = new DirectorTemprano();
ComidaDeMama comida = new ComidaDeMama();

director.temprano(comida);
Comida receta = comida.getComida();
receta.getComida();

Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("--------------------------------------------------------------");

// comida en la tarde
DirectorTarde directorTarde = new DirectorTarde();
Tarde MedioDia = new Tarde();

directorTarde.IngredienteTarde(MedioDia);
receta = MedioDia.getComida();
receta.getComida();

Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("--------------------------------------------------------------");

IThema gui = new WinFactory();
IButton boton = gui.CreateButton();
boton.Render();

gui = new MacFactory();
boton= gui.CreateButton();
boton.Render();

gui = new LinuxFactory();
boton = gui.CreateButton();
boton.Render();

Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("--------------------------------------------------------------");


//Usuario user = new Usuario();
//user.Saldo = 1000;
//user.user = "Juan Perez";
//user.passwor = "1234";
//decimal monto = 0;

//IPasarela pasarela = new StipeFactory (user, monto);
//IValidarUsuario verificar = pasarela.CrearValidarUsuario();
//ValidadCantidad cantidad = pasarela.CrearValidadCantidad();
//IvalidadPago pago = pasarela.CrearValidarPago();



//bool resultado = verificar.ValidarUsuario(user);
//bool resultadoPass = verificar.ValidarPass(user);



//Console.WriteLine(resultado);


//if (!resultado)
//{
//    Console.WriteLine("Usuario o  contraseña no validos");
    
    
//    resultado = verificar.ValidarPass(user);
//}
//if (resultado && resultadoPass) {
//   monto = cantidad.ValidadCantidad(user);
   
//}


//if (monto > 0) {
//   pago.ValidarPago(user, monto);S
//}

//Console.WriteLine(user.transacciones);

Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("--------------------------------------------------------------");

PasarelaGateway _strip = new  StripeFactory();

// inyectamos la fabrica 

PaymentServices utilizar = new PaymentServices(_strip);

decimal montoPago = 1000m;

utilizar.ProcesarPago(montoPago);

// cambiamos a Stripe

// inyectamos la fabrica

Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("--------------------------------------------------------------");

Console.WriteLine("Prueba Facorty Method _______________________________________");

VehiculoFacroty vehiculoFacroty;

vehiculoFacroty = new LanchaFactory();
IVehiculo vehiculo = vehiculoFacroty.crearVehiculo();
vehiculoFacroty.Transprote();
Console.WriteLine("Vehiculo creado: " + vehiculo.GetType().Name);



Console.WriteLine("Prueba Facorty Method ___________ Mensaje____________________________");

MensajeFactory mensajeFactory;
mensajeFactory = new HotMailFactory();
IMensaje mensaje = mensajeFactory.CrearMensaje();

mensajeFactory.Mostrar();

Console.WriteLine("Prueba Facorty Method2 ___________ Mensaje 2____________________________");

NotificationFactory notificationFactory;
notificationFactory = new PuschFactory();
Inotificacion notificacion = notificationFactory.CrearNotificacion();
notificacion.enviar("Hola, esta es una notificación por push.");
Console.WriteLine("Notificación creada: " + notificacion.GetType().Name);

Console.WriteLine("Prueba Facorty Method2 ___________ Prototype____________________________");

Circulo circulo = new Circulo("Circulo");
circulo.Id = 1;

Rectangulo rectangulo = new Rectangulo("Rectangulo");
rectangulo.Id = 2;

Triangulo triangulo = new Triangulo("Triangulo");
triangulo.Id = 3;
Console.WriteLine("Prueba Facorty Method2 ___________ Original____________________________");
circulo.dibujar();
rectangulo.dibujar();
triangulo.dibujar();
Console.WriteLine("Prueba Facorty Method2 ___________ Copiar____________________________");

Circulo copiaCirculo = (Circulo) circulo.clone();
Rectangulo copiaRectangulo = (Rectangulo)rectangulo.clone();
Triangulo copiaTriangulo = (Triangulo)triangulo.clone();

copiaCirculo.dibujar();
copiaRectangulo.dibujar();
copiaTriangulo.dibujar();

Console.WriteLine("Prueba Facorty Method2 ___________ Modificar____________________________");

copiaCirculo.Name = "Nuevo Circulo";
copiaRectangulo.Name = "Nuevo Rectangulo";
copiaTriangulo.Name = "Nuevo Triangulo";

copiaCirculo.Id = 4;
copiaRectangulo.Id = 5;
copiaTriangulo.Id = 6;
copiaCirculo.dibujar();
copiaRectangulo.dibujar();
copiaTriangulo.dibujar();
Console.WriteLine("Prueba Facorty Method2 ___________ Original____________________________");

circulo.dibujar();
rectangulo.dibujar();
triangulo.dibujar();


Console.WriteLine("Prueba Facorty Method2 ___________ Original____________________________");
HombreLobo hombreLobo = new HombreLobo();
hombreLobo.NameHombreLobo("Lupin");
hombreLobo.isTransformacion(true);
hombreLobo.DevilidadHombreLobo("Plata (El chambiar)");
hombreLobo.LunaLlena(true);
hombreLobo.AtaqueHombreLobo("Mordida");
hombreLobo.LlamaEnemigo();

Console.WriteLine("Prueba Facorty Method2 ___________Copia____________________________");
HombreLobo copiaHombreLobo = (HombreLobo)hombreLobo.clone();
copiaHombreLobo.NameHombreLobo("Lupin 2");
copiaHombreLobo.LlamaEnemigo();
Console.WriteLine("Prueba Facorty Method2 ___________Simplificar____________________________");

vampiro vampir2 = new vampiro();
vampir2.Id = 1;

vampir2.atacar();

vampiro vampiro3 = (vampiro) vampir2.clonar();
vampiro3.Id = 2;
vampiro3.atacar();


Console.WriteLine(vampiro3.Id);
Console.WriteLine(vampir2.Id);

Console.WriteLine("Prueba Facorty Method2 ___________Adapter____________________________");
Conversar conversar = new Conversar();
English english = new English();

conversar.iniciar(english, "What is your name?", "My name is John.");

Epanish espanish = new Epanish();

traductor traductor = new traductor(espanish);
conversar.iniciar(traductor, "¿Cuál es tu nombre?", "Mi nombre es Juan.");

Console.WriteLine("Prueba Facorty Method2 ___________Adapter____________________________");
Modeloos modeloos = new Modeloos();
modeloos.Id = 3;
SQLserver sqlserver = new SQLserver(modeloos);
SQLServer_Mysql sqlServerMysql = new SQLServer_Mysql(sqlserver);
sqlServerMysql.Consultar("SELECT * FROM Usuarios");
Console.WriteLine("Respuesta de SQLServer: " + sqlServerMysql.Respuesta());
Console.WriteLine("Prueba Facorty Method2 ___________Adapter____________________________");

IDATABASE database = new DataAdapterSQL();
Conversion conversion = new Conversion();
conversion.add(database, "Mensaje de prueba");
conversion.retrive(database);

Console.WriteLine("Prueba Facorty Method2 ___________Adapter____________________________");

database = new NewSystem(new LegasyDatabase());
conversion.add(database, "Mensaje de prueba en el nuevo sistema");
string data = conversion.retrive(database);

Console.WriteLine("Prueba Facorty Method2 ___________inyeccion Adapter____________________________");
ClaSeLegada claSeLegada = new ClaSeLegada();
InyectAdapter inyectAdapter = new InyectAdapter(claSeLegada);

UsarDB usarDB = new UsarDB(inyectAdapter);
usarDB.Guardar();
usarDB.Eliminar();