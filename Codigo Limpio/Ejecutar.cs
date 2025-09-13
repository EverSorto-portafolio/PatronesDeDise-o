using Codigo_Limpio.AbstracFactory.AFEjemplo1;
using Codigo_Limpio.AbstracFactory.AFEjemplo1.Factory;
using Codigo_Limpio.AbstracFactory.Ejercicio3.Fabrica;
using Codigo_Limpio.AbstracFactory.Ejercicio3.PaimentServices;
using Codigo_Limpio.comportamiento.Commend;
using Codigo_Limpio.comportamiento.Commend.Ejercicio1;
using Codigo_Limpio.comportamiento.Iterator.IteratorEjemplo1;
using Codigo_Limpio.comportamiento.Iterator.NewFolder;
using Codigo_Limpio.comportamiento.Mediator;
using Codigo_Limpio.comportamiento.Mediator.ejercicio1;
using Codigo_Limpio.comportamiento.Mediator.ejercicio2;
using Codigo_Limpio.comportamiento.Memento;
using Codigo_Limpio.comportamiento.Memento.ejemplo2;
using Codigo_Limpio.comportamiento.Observer;
using Codigo_Limpio.comportamiento.Observer.ejemplo1;
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
using Codigo_Limpio.Estructural.NewFacade;
using Codigo_Limpio.Estructural.NewFacade.ejemplo2;
using Codigo_Limpio.Estructural.Proxy;
using Codigo_Limpio.Estructural.Proxy.Ejercicio1;
using Codigo_Limpio.Estructural.Wrapper.WrapperEjercicio1;
using Codigo_Limpio.Estructural.Wrapper.WrapperEjercicio2;
using Codigo_Limpio.FactoryMethod;
using Codigo_Limpio.FactoryMethod.Ejercicio1;
using Codigo_Limpio.FactoryMethod.Ejercicio1.implementacion;
using Codigo_Limpio.FactoryMethod.Ejercicio2.Producto;
using Codigo_Limpio.FactoryMethod.Factories;
using Codigo_Limpio.FactoryMethod.Producto.Factory;
using Codigo_Limpio.PatronBuilder.ejercicio2;
using Codigo_Limpio.Prototype.Ejemplo1;
using Codigo_Limpio.Prototype.Ejemplo3.prototypos;
using Codigo_Limpio.State;
using HombreLobo = Codigo_Limpio.Prototype.Ejemplo2.EjemploPrototype1.Clonables.Modelos.HombreLobo;

#region patrones
////IModelo modelo = new Plano();
////CasaCampoEconomica casa = new (modelo);

////casa.ConstruirCasa();


////Modelo ejemplo =  modelo.GetModelo();
////ejemplo.MostrarCasa();


////// rutina de ejericio 
////Entrenamiento entrenamiento = new ImplementarRutina();
////Rutina rutina = new Rutina(entrenamiento);
////rutina.Ruta();

//Console.WriteLine("--------------------------------------------------------------");
//Console.WriteLine("--------------------------------------------------------------");
//Console.WriteLine("--------------------------------------------------------------");

//// comida en la ma;ana 
//DirectorTemprano director = new DirectorTemprano();
//ComidaDeMama comida = new ComidaDeMama();

//director.temprano(comida);
//Comida receta = comida.getComida();
//receta.getComida();

//Console.WriteLine("--------------------------------------------------------------");
//Console.WriteLine("--------------------------------------------------------------");
//Console.WriteLine("--------------------------------------------------------------");

//// comida en la tarde
//DirectorTarde directorTarde = new DirectorTarde();
//Tarde MedioDia = new Tarde();

//directorTarde.IngredienteTarde(MedioDia);
//receta = MedioDia.getComida();
//receta.getComida();

//Console.WriteLine("--------------------------------------------------------------");
//Console.WriteLine("--------------------------------------------------------------");
//Console.WriteLine("--------------------------------------------------------------");

//IThema gui = new WinFactory();
//IButton boton = gui.CreateButton();
//boton.Render();

//gui = new MacFactory();
//boton= gui.CreateButton();
//boton.Render();

//gui = new LinuxFactory();
//boton = gui.CreateButton();
//boton.Render();

//Console.WriteLine("--------------------------------------------------------------");
//Console.WriteLine("--------------------------------------------------------------");
//Console.WriteLine("--------------------------------------------------------------");


////Usuario user = new Usuario();
////user.Saldo = 1000;
////user.user = "Juan Perez";
////user.passwor = "1234";
////decimal monto = 0;

////IPasarela pasarela = new StipeFactory (user, monto);
////IValidarUsuario verificar = pasarela.CrearValidarUsuario();
////ValidadCantidad cantidad = pasarela.CrearValidadCantidad();
////IvalidadPago pago = pasarela.CrearValidarPago();



////bool resultado = verificar.ValidarUsuario(user);
////bool resultadoPass = verificar.ValidarPass(user);



////Console.WriteLine(resultado);


////if (!resultado)
////{
////    Console.WriteLine("Usuario o  contraseña no validos");1


////    resultado = verificar.ValidarPass(user);
////}
////if (resultado && resultadoPass) {
////   monto = cantidad.ValidadCantidad(user);

////}


////if (monto > 0) {
////   pago.ValidarPago(user, monto);S
////}

////Console.WriteLine(user.transacciones);

//Console.WriteLine("--------------------------------------------------------------");
//Console.WriteLine("--------------------------------------------------------------");
//Console.WriteLine("--------------------------------------------------------------");

//PasarelaGateway _strip = new  StripeFactory();

//// inyectamos la fabrica 

//PaymentServices utilizar = new PaymentServices(_strip);

//decimal montoPago = 1000m;

//utilizar.ProcesarPago(montoPago);

//// cambiamos a Stripe

//// inyectamos la fabrica

//Console.WriteLine("--------------------------------------------------------------");
//Console.WriteLine("--------------------------------------------------------------");
//Console.WriteLine("--------------------------------------------------------------");

//Console.WriteLine("Prueba Facorty Method _______________________________________");

//VehiculoFacroty vehiculoFacroty;

//vehiculoFacroty = new LanchaFactory();
//IVehiculo vehiculo = vehiculoFacroty.crearVehiculo();
//vehiculoFacroty.Transprote();
//Console.WriteLine("Vehiculo creado: " + vehiculo.GetType().Name);



//Console.WriteLine("Prueba Facorty Method ___________ Mensaje____________________________");

//MensajeFactory mensajeFactory;
//mensajeFactory = new HotMailFactory();
//IMensaje mensaje = mensajeFactory.CrearMensaje();

//mensajeFactory.Mostrar();

//Console.WriteLine("Prueba Facorty Method2 ___________ Mensaje 2____________________________");

//NotificationFactory notificationFactory;
//notificationFactory = new PuschFactory();
//Inotificacion notificacion = notificationFactory.CrearNotificacion();
//notificacion.enviar("Hola, esta es una notificación por push.");
//Console.WriteLine("Notificación creada: " + notificacion.GetType().Name);

//Console.WriteLine("Prueba Facorty Method2 ___________ Prototype____________________________");

//Circulo circulo = new Circulo("Circulo");
//circulo.Id = 1;

//Rectangulo rectangulo = new Rectangulo("Rectangulo");
//rectangulo.Id = 2;

//Triangulo triangulo = new Triangulo("Triangulo");
//triangulo.Id = 3;
//Console.WriteLine("Prueba Facorty Method2 ___________ Original____________________________");
//circulo.dibujar();
//rectangulo.dibujar();
//triangulo.dibujar();
//Console.WriteLine("Prueba Facorty Method2 ___________ Copiar____________________________");

//Circulo copiaCirculo = (Circulo) circulo.clone();
//Rectangulo copiaRectangulo = (Rectangulo)rectangulo.clone();
//Triangulo copiaTriangulo = (Triangulo)triangulo.clone();

//copiaCirculo.dibujar();
//copiaRectangulo.dibujar();
//copiaTriangulo.dibujar();

//Console.WriteLine("Prueba Facorty Method2 ___________ Modificar____________________________");

//copiaCirculo.Name = "Nuevo Circulo";
//copiaRectangulo.Name = "Nuevo Rectangulo";
//copiaTriangulo.Name = "Nuevo Triangulo";

//copiaCirculo.Id = 4;
//copiaRectangulo.Id = 5;
//copiaTriangulo.Id = 6;
//copiaCirculo.dibujar();
//copiaRectangulo.dibujar();
//copiaTriangulo.dibujar();
//Console.WriteLine("Prueba Facorty Method2 ___________ Original____________________________");

//circulo.dibujar();
//rectangulo.dibujar();
//triangulo.dibujar();


//Console.WriteLine("Prueba Facorty Method2 ___________ Original____________________________");
//HombreLobo hombreLobo = new HombreLobo();
//hombreLobo.NameHombreLobo("Lupin");
//hombreLobo.isTransformacion(true);
//hombreLobo.DevilidadHombreLobo("Plata (El chambiar)");
//hombreLobo.LunaLlena(true);
//hombreLobo.AtaqueHombreLobo("Mordida");
//hombreLobo.LlamaEnemigo();

//Console.WriteLine("Prueba Facorty Method2 ___________Copia____________________________");
//HombreLobo copiaHombreLobo = (HombreLobo)hombreLobo.clone();
//copiaHombreLobo.NameHombreLobo("Lupin 2");
//copiaHombreLobo.LlamaEnemigo();
//Console.WriteLine("Prueba Facorty Method2 ___________Simplificar____________________________");

//vampiro vampir2 = new vampiro();
//vampir2.Id = 1;

//vampir2.atacar();

//vampiro vampiro3 = (vampiro) vampir2.clonar();
//vampiro3.Id = 2;
//vampiro3.atacar();


//Console.WriteLine(vampiro3.Id);
//Console.WriteLine(vampir2.Id);

//Console.WriteLine("Prueba Facorty Method2 ___________Adapter____________________________");
//Conversar conversar = new Conversar();
//English english = new English();

//conversar.iniciar(english, "What is your name?", "My name is John.");

//Epanish espanish = new Epanish();

//traductor traductor = new traductor(espanish);
//conversar.iniciar(traductor, "¿Cuál es tu nombre?", "Mi nombre es Juan.");

//Console.WriteLine("Prueba Facorty Method2 ___________Adapter____________________________");
//Modeloos modeloos = new Modeloos();
//modeloos.Id = 3;
//SQLserver sqlserver = new SQLserver(modeloos);
//SQLServer_Mysql sqlServerMysql = new SQLServer_Mysql(sqlserver);
//sqlServerMysql.Consultar("SELECT * FROM Usuarios");
//Console.WriteLine("Respuesta de SQLServer: " + sqlServerMysql.Respuesta());
//Console.WriteLine("Prueba Facorty Method2 ___________Adapter____________________________");

//IDATABASE database = new DataAdapterSQL();
//Conversion conversion = new Conversion();
//conversion.add(database, "Mensaje de prueba");
//conversion.retrive(database);

//Console.WriteLine("Prueba Facorty Method2 ___________Adapter____________________________");

//database = new NewSystem(new LegasyDatabase());
//conversion.add(database, "Mensaje de prueba en el nuevo sistema");
//string data = conversion.retrive(database);

//Console.WriteLine("Prueba Facorty Method2 ___________inyeccion Adapter____________________________");
//ClaSeLegada claSeLegada = new ClaSeLegada();
//InyectAdapter inyectAdapter = new InyectAdapter(claSeLegada);

//UsarDB usarDB = new UsarDB(inyectAdapter);
//usarDB.Guardar();
//usarDB.Eliminar();

//Console.WriteLine("Prueba Facorty Method2 ___________Bridge____________________________");
//Iformat mp3 = new MP3();
//MusicPlayer Reprodutor = new Escritorio(mp3);
//Reprodutor.play("cancion.mp3");

//Iformat mp4 = new MP4();
//Reprodutor = new ReproductorAndroid(mp4);
//Reprodutor.play("video.mp4");

//Console.WriteLine("Prueba Facorty Method2 ___________Bridge Ejemplo 2____________________________");
//IAuto auto = new combustionInterfa();
//TipoAutomovil electrico = new Bocho(auto);
//electrico.EstadoAuto();

//Console.WriteLine("Prueba Facorty Method2 ___________Bridge Ejemplo 3____________________________");
//Motor motor = new MotorACombustion();
//AvionDeCasaApacheR32 avion = new AvionDeCasaApacheR32(motor);
//avion.EstadoMotor();

//motor = new MotorElectrico();
//AvionDeCasaApacheR32 avionElectrico = new AvionDeCasaApacheR32(motor);
//avionElectrico.EstadoMotor();

//Console.WriteLine("Prueba Facorty Method2 ___________Composite____________________________");

//var file1 = new AppFile("file10.txt");
//var file2 = new AppFile("file11.txt");
//var file3 = new AppFile("file12.txt");
//var file4 = new AppFile("file13.txt");
//var file5 = new AppFile("file14.txt");
//var file6 = new AppFile("file15.txt");
//var file7 = new AppFile("file16.txt");

//var folder1 = new Folder("folder1");

//folder1.Item(file1);
//folder1.Item(file6);
//folder1.Item(file7);

//var folder2 = new Folder("folder2");
//folder1.Item(file2);
//folder1.Item(file3);
//folder2.Item(file4);
//folder2.Item(file5);

//var folder4 = new Folder("root");
//folder4.Item(folder1);
//folder4.Item(folder2);
//folder4.Display();
//Console.WriteLine("Prueba Facorty Method2 ___________Composite1____________________________");
//var empleado1 = new Empleado("Juan");
//var empleado2 = new Empleado("Maria");
//var empleado3 = new Empleado("Pedro");
//var empleado4 = new Empleado("Ana");
//var empleado5 = new Empleado("Luis");

//var jefe1 = new Jefe("Carlos");
//jefe1.agregarSubordinado(empleado1);
//jefe1.agregarSubordinado(empleado2);
//jefe1.agregarSubordinado(empleado3);
//jefe1.recorrer();

//Console.WriteLine("Prueba Facorty Method2 ___________Composite2____________________________");
//// agregamos el casador
//ICasador casador = new CasadorNovato();
//casador.Nombre("Juan-winguo");
//casador.Codigo("Gan-Gan-Style");
//casador.Rango("GT");


//ICasador casador1 = new CasadorNovato();
//casador1.Nombre("Juan-DounZu");
//casador1.Codigo("SexyTres");
//casador1.Rango("AF");


//ICasador casador2 = new CasadorNovato();
//casador2.Nombre("Soon-winguo");
//casador2.Codigo("Gan-Gan-Style");
//casador2.Rango("Monarca de las sombras ");


//var Director = new RangoS();
//Director.Nombre("Director");
//Director.Codigo("Director-001");
//Director.Rango("Director de la caceria");
//Director.AgregarCasador(casador);
//Director.AgregarCasador(casador2);
//Director.AgregarCasador(casador1);
//Director.Recorrer();
//Console.WriteLine("Prueba Facorty Method2 ___________Decorator____________________________");
//ICafe cafe  = new Cafe();
//Console.WriteLine($"{cafe.GetDescription()} : ${cafe.GetCost()}");
//cafe = new Crema(cafe);
//Console.WriteLine($"{cafe.GetDescription()} : ${cafe.GetCost()}");
//cafe = new ChocolateDecorator(cafe);
//Console.WriteLine($"{cafe.GetDescription()} : ${cafe.GetCost()}");

//Console.WriteLine("Prueba Facorty Method2 ___________Decorator____________________________");
//IBurger burger = new Hamburgesa();
//Console.WriteLine($"{burger.Descripcion()} : ${burger.Costo()}");
//burger = new DobleCarne(burger);
//Console.WriteLine($"{burger.Descripcion()} : ${burger.Costo()}");
//burger = new Queso(burger);
//Console.WriteLine($"{burger.Descripcion()} : ${burger.Costo()}");
////----------------------------------------------------------------------------
//Console.WriteLine("Prueba Facorty Method2 ___________Decorator____________________________");

//DvDPlayer dvDPlayer = new DvDPlayer();
//sonido sonido = new sonido();
//Proyector proyector = new Proyector();

//FachadaMovie facha = new FachadaMovie(dvDPlayer, sonido, proyector);
//facha.ReproducirPelicula("Inception");
//facha.DetenerPelicula();

//Console.WriteLine("Prueba Facorty Method2 ___________Decorator____________________________");

//Dictionary<string, string> diccionario = new Dictionary<string, string>();

//diccionario.Add("hotel", "El mismisimo Decameron");
//diccionario.Add("vuelo", "Vuelo a Acajutla");
//diccionario.Add("auto", "Renta de auto en Acajutla");

//viajeFacade viaje = new viajeFacade(diccionario);

//Vuelo vuelo = new Vuelo();
//Hotel hotel = new Hotel();
//RentaCar rentaCar = new RentaCar();

//viaje.rentaCar(rentaCar);
//viaje.hotel(hotel);
//viaje.vuelo(vuelo);
//viaje.planearViaje();
//Console.WriteLine("Prueba Facorty Method2 ______ Rquipo ");

//IBancoCuenta bancoCuenta = new  Cuenta(1000);
//bancoCuenta.Depositar(1000);
//BancoProxy bancoProxy = new BancoProxy(bancoCuenta);
//Console.WriteLine("Saldo inicial: " + bancoProxy.ObtenerSaldo());
//bancoProxy.Retirar(500);
//Console.WriteLine("Saldo después de retirar 500: " + bancoProxy.ObtenerSaldo());
//bancoProxy.Retirar(600); // Esto lanzará una excepción por saldo insuficiente

//Console.WriteLine("Prueba Facorty Method2 ______ Rquipo ");
//ISegutiryCamara camara = new implmentacionInterfaz("Camara 1");
//Dictionary<string, Object> acceso = new Dictionary<string, Object>();
//acceso.Add("camara", camara);
//acceso.Add("autorizacion", true);
//CamaraProxy camaraProxy = new CamaraProxy(acceso);
//camaraProxy.ValidarAcceso(camaraProxy.ApagarCamara);

//Console.WriteLine("Command Patter ______ Rquipo ");
//Order order = new Order();
//Icommand command = new OrdenCommand(order);
//Icommand cancelCommand = new CancerlarOrden(order);
//EjecutarCommand ejecutarCommand = new EjecutarCommand();
//ejecutarCommand.Ejecutar(command);
//ejecutarCommand.Ejecutar(cancelCommand);

//Console.WriteLine("Command Patter ejemplo 2 ______ Rquipo ");
//SmartTv smartTv = new SmartTv();
//IcommandTv openNetflixCommand = new ControlNetFlix(smartTv);
//IcommandTv openAmazonCommand = new ControlAmazon(smartTv);

//ControlRemoto controlRemoto = new ControlRemoto();
//controlRemoto.IcommandTv(openNetflixCommand);
//controlRemoto.IcommandTv(openAmazonCommand);

//Console.WriteLine("Iterator ");
//var libreria = new Libreria();
//var iterator = libreria.CrearIterador();
//while (iterator.MoveNext()) {
//    var book = iterator.Next();
//    Console.WriteLine($"{book._title}, {book._autor}");
//}

//Console.WriteLine("Iterator ejemplo2");

//List<ModeloUsuario> usuarios2 = new List<ModeloUsuario>
//        {
//        new ModeloUsuario { IdUser = 1, Name = "Eder", Correo = "eder@example.com" },
//            new ModeloUsuario { IdUser = 2, Name = "Ana", Correo = "ana@example.com" },
//            new ModeloUsuario { IdUser = 3, Name = "Luis", Correo = "luis@example.com" },
//            new ModeloUsuario { IdUser = 4, Name = "Carla", Correo = "carla@example.com" },
//            new ModeloUsuario { IdUser = 5, Name = "Miguel", Correo= "miguel@example.com" },
//            new ModeloUsuario { IdUser = 6, Name = "Sofia", Correo = "sofia@example.com" },
//            new ModeloUsuario { IdUser = 7, Name = "David", Correo = "david@example.com" },
//            new ModeloUsuario { IdUser = 8, Name = "Laura", Correo = "laura@example.com" },
//            new ModeloUsuario { IdUser = 9, Name = "Carlos", Correo = "carlos@example.com" },
//            new ModeloUsuario { IdUser = 10, Name = "Marta", Correo = "marta@example.com" }
//        };

//BibliotecaDeUsuarios bibliotecaUsuarios= new BibliotecaDeUsuarios(usuarios2);
//var iterar = bibliotecaUsuarios.createIterator();
//while (iterar.HasNextUSer()) {
//    var  contador = iterar.NextUser();

//    Console.WriteLine($"ID:{contador.IdUser}, Nombre: {contador.Name}, Correo: {contador.Correo}");
//}

//Console.WriteLine("Prueba Facorty Method2 ___________Decorator____________________________");
//CarroDeCompras carroDeCompras = new CarroDeCompras(null);
//Inventario inventario = new Inventario(null);

//Tienda tienda = new Tienda(inventario, carroDeCompras);

//carroDeCompras.SetMediator(tienda);
//inventario.SetMediator(tienda);

//carroDeCompras.addItem("Sopa marucha");
//carroDeCompras.addItem("limones");

//Console.WriteLine("---------------------------------------------");


//// creamos los aviones
//AirBus airbus = new AirBus();
//AvionAeropuerto avion5 = new AvionAeropuerto();

//IAeroPuerto Torre = new TorreDeControl(airbus,avion5);

//airbus.setInstruccion(Torre);
//avion5.setInstruccion(Torre);

//airbus.OperacionB("Preparandome para despegar");
//avion5.OperacionA("Preaparandome para aterrizar");

//Console.WriteLine("---------------------------------------------");

//IAtraficControl torre = new Tower();
//AirCraft avion1 = new AirPlane(torre, "Boing 777");
//AirCraft avion3 = new AirPlane(torre, "AirBus 767");

//avion3.SendMessage("Bong  saludos desde el aire");
#endregion
//Juego juego = new Juego();
//GameSaveManager gameManager = new GameSaveManager();

//juego.estadoActual = new Personaje {
//    Level = 5,
//    Salud = 99,
//    Equipo = "lazo"
//};

//Console.WriteLine($"Estado actual{juego.estadoActual.Level}");

//gameManager.SaveGame(juego);
//Console.WriteLine("Juego Guardado");

// juego.estadoActual = new Personaje
//{
//    Level = 6,
//    Salud = 79,
//    Equipo = "Un palo"
//};
//Console.WriteLine($"Estado actual {juego.estadoActual.Level}");

//gameManager.loadGeme(juego, 0);
//Console.WriteLine($"Estado actual {juego.estadoActual.Level}");

//Commit iniciar = new Commit();

//iniciar.Code = "1111";

//Console.WriteLine($"Estado Actual {iniciar.Code}");

//Git estado = new Git(iniciar);
//estado.Commit();
//Console.WriteLine($"Estado Guardad {iniciar.Code}");

//iniciar.Code = "12";
//Console.WriteLine($"Estado Modificado {iniciar.Code}");

//estado.Commit();
//Console.WriteLine($"Estado Guardad {iniciar.Code}");

//iniciar.Code = "1s2";
//Console.WriteLine($"Estado Modificado {iniciar.Code}");
//estado.Commit();
//Console.WriteLine($"Estado Guardad {iniciar.Code}");

//Console.WriteLine("Recuperando el estado anterior");
//iniciar.Code = "1111";
//estado.Revert(  iniciar );
//Console.WriteLine($"Estado Guardad {iniciar.Code}");

//Console.WriteLine("-----------------Observer----------------------------");
//ModeloTv _modelo = new ModeloTv();
//_modelo.control = "esw2";
//_modelo.Marca = "RCA";
//_modelo.modelo = "Rj-2025";

//Tv tv = new Tv();
//Tv tv1 = new Tv();
//Tv tv2 = new Tv();

//ObservadorTV observadorTV = new ObservadorTV();
//observadorTV.ActualizarModelo(_modelo);
//observadorTV.RegistrarObservador(tv);
//observadorTV.RegistrarObservador(tv1);
//observadorTV.RegistrarObservador(tv2);
//observadorTV.Notificar();
//Console.WriteLine("-----------------Observer----------------------------");
//_modelo.control = "esw3";
//_modelo.Marca = "RCA2";
//_modelo.modelo = "Rj-2028";
//observadorTV.ActualizarModelo(_modelo);


//observadorTV.Notificar();

//Console.WriteLine("--------------------------------------------");
//IObjeto subastador = new Imp_lementacionIObjeto();
//IObjeto subastador2 = new Imp_lementacionIObjeto();
//IObjeto subastador3 = new Imp_lementacionIObjeto();
//Subasta objetoOfertado = new Subasta
//{
//    IdArticulo = 1,
//    Oferta = 100f,
//    Precio = 80
//};

//ImplementacionPostulante nuevaOferta = new ImplementacionPostulante();
//nuevaOferta.Registrar(subastador);
//nuevaOferta.ActualizarPropuesta(objetoOfertado);

//Console.WriteLine("--------------------------------------------");

//Subasta objetoOfertado1 = new Subasta
//{
//    IdArticulo = 1,
//    Oferta = 400f,
//    Precio = 303
//};
//Console.WriteLine("--------------------------------------------");

//nuevaOferta.Registrar(subastador2);
//nuevaOferta.Registrar(subastador3);
//nuevaOferta.ActualizarPropuesta(objetoOfertado1);
//Console.WriteLine("--------------------------------------------");
EstadoContexto contexto = new EstadoContexto();
for (int i =0; i<10;i++) {
    contexto.Request();
}