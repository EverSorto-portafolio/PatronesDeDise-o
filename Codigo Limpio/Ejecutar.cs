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
using Codigo_Limpio.FactoryMethod;
using Codigo_Limpio.FactoryMethod.Ejercicio1;
using Codigo_Limpio.FactoryMethod.Ejercicio1.implementacion;
using Codigo_Limpio.FactoryMethod.Ejercicio1.interfaz;
using Codigo_Limpio.FactoryMethod.Producto.Factory;
using Codigo_Limpio.PatronBuilder;
using Codigo_Limpio.PatronBuilder.ejecicio;
using Codigo_Limpio.PatronBuilder.ejercicio2;

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

