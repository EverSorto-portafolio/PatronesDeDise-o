using Codigo_Limpio.AbstracFactory.AFEjemplo1;
using Codigo_Limpio.AbstracFactory.AFEjemplo1.Factory;
using Codigo_Limpio.AbstracFactory.Ejercicio3.Fabrica;
using Codigo_Limpio.AbstracFactory.Ejercicio3.PaimentServices;

using Codigo_Limpio.Estructural.Adapter;
using Codigo_Limpio.Estructural.Adapter.Ejercicio1;
using Codigo_Limpio.Estructural.Adapter.Ejercicio1.Database;
using Codigo_Limpio.Estructural.Adapter.Ejercicio1.Intermediario;
using Codigo_Limpio.Estructural.Adapter.ejercicio2;
using Codigo_Limpio.Estructural.Adaptert.Ejercicio3;
using Codigo_Limpio.Estructural.Bridge.ejercicio2;
using Codigo_Limpio.Estructural.Bridge.ejercicio2.ClaseAbstracta;
using Codigo_Limpio.Estructural.Bridge.ejercicio2.Implementador;
using Codigo_Limpio.Estructural.Bridge.ejercicio3;
using Codigo_Limpio.Estructural.Bridge.ejercicio3.ImplementacionesMotor;
using Codigo_Limpio.Estructural.Bridge.ejercicio3.refinador;
using Codigo_Limpio.Estructural.Bridge.implementacionDelPatron.ejecutor;
using Codigo_Limpio.Estructural.Bridge.implementacionDelPatron.ejemplo1;
using Codigo_Limpio.Estructural.Bridge.implementacionDelPatron.Implementacion;
using Codigo_Limpio.Estructural.Bridge.implementacionDelPatron.refinador;
using Codigo_Limpio.Estructural.Composite.Ejemplo1Composite;
using Codigo_Limpio.Estructural.Composite.Ejercicio2Composite;
using Codigo_Limpio.Estructural.Composite.Ejercicio3;
using Codigo_Limpio.Estructural.Wrapper;
using Codigo_Limpio.FactoryMethod;
using Codigo_Limpio.FactoryMethod.Ejercicio1;
using Codigo_Limpio.FactoryMethod.Ejercicio1.implementacion;
using Codigo_Limpio.FactoryMethod.Ejercicio2.Producto;
using Codigo_Limpio.FactoryMethod.Factories;
using Codigo_Limpio.FactoryMethod.Producto.Factory;
using Codigo_Limpio.PatronBuilder.ejercicio2;
using Codigo_Limpio.Prototype.Ejemplo1;
using Codigo_Limpio.Prototype.Ejemplo3.prototypos;
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
//    Console.WriteLine("Usuario o  contraseña no validos");1
    
    
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

Console.WriteLine("Prueba Facorty Method2 ___________Bridge____________________________");
Iformat mp3 = new MP3();
MusicPlayer Reprodutor = new Escritorio(mp3);
Reprodutor.play("cancion.mp3");

Iformat mp4 = new MP4();
Reprodutor = new ReproductorAndroid(mp4);
Reprodutor.play("video.mp4");

Console.WriteLine("Prueba Facorty Method2 ___________Bridge Ejemplo 2____________________________");
IAuto auto = new combustionInterfa();
TipoAutomovil electrico = new Bocho(auto);
electrico.EstadoAuto();

Console.WriteLine("Prueba Facorty Method2 ___________Bridge Ejemplo 3____________________________");
Motor motor = new MotorACombustion();
AvionDeCasaApacheR32 avion = new AvionDeCasaApacheR32(motor);
avion.EstadoMotor();

motor = new MotorElectrico();
AvionDeCasaApacheR32 avionElectrico = new AvionDeCasaApacheR32(motor);
avionElectrico.EstadoMotor();

Console.WriteLine("Prueba Facorty Method2 ___________Composite____________________________");

var file1 = new AppFile("file10.txt");
var file2 = new AppFile("file11.txt");
var file3 = new AppFile("file12.txt");
var file4 = new AppFile("file13.txt");
var file5 = new AppFile("file14.txt");
var file6 = new AppFile("file15.txt");
var file7 = new AppFile("file16.txt");

var folder1 = new Folder("folder1");

folder1.Item(file1);
folder1.Item(file6);
folder1.Item(file7);

var folder2 = new Folder("folder2");
folder1.Item(file2);
folder1.Item(file3);
folder2.Item(file4);
folder2.Item(file5);

var folder4 = new Folder("root");
folder4.Item(folder1);
folder4.Item(folder2);
folder4.Display();
Console.WriteLine("Prueba Facorty Method2 ___________Composite1____________________________");
var empleado1 = new Empleado("Juan");
var empleado2 = new Empleado("Maria");
var empleado3 = new Empleado("Pedro");
var empleado4 = new Empleado("Ana");
var empleado5 = new Empleado("Luis");

var jefe1 = new Jefe("Carlos");
jefe1.agregarSubordinado(empleado1);
jefe1.agregarSubordinado(empleado2);
jefe1.agregarSubordinado(empleado3);
jefe1.recorrer();

Console.WriteLine("Prueba Facorty Method2 ___________Composite2____________________________");
// agregamos el casador
ICasador casador = new CasadorNovato();
casador.Nombre("Juan-winguo");
casador.Codigo("Gan-Gan-Style");
casador.Rango("GT");


ICasador casador1 = new CasadorNovato();
casador1.Nombre("Juan-DounZu");
casador1.Codigo("SexyTres");
casador1.Rango("AF");


ICasador casador2 = new CasadorNovato();
casador2.Nombre("Soon-winguo");
casador2.Codigo("Gan-Gan-Style");
casador2.Rango("Monarca de las sombras ");


var Director = new RangoS();
Director.Nombre("Director");
Director.Codigo("Director-001");
Director.Rango("Director de la caceria");
Director.AgregarCasador(casador);
Director.AgregarCasador(casador2);
Director.AgregarCasador(casador1);
Director.Recorrer();
Console.WriteLine("Prueba Facorty Method2 ___________Decorator____________________________");
ICafe cafe  = new Cafe();
Console.WriteLine($"{cafe.GetDescription()} : ${cafe.GetCost()}");
cafe = new Crema(cafe);
Console.WriteLine($"{cafe.GetDescription()} : ${cafe.GetCost()}");
cafe = new ChocolateDecorator(cafe);
Console.WriteLine($"{cafe.GetDescription()} : ${cafe.GetCost()}");