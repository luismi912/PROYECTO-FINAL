using System.Security.Cryptography.X509Certificates;

System.Console.WriteLine("EXPEDIENTES LABORALES: ");
var Lista_ExpedientesLaborales = new List<ExpedientesLaborales>();
Lista_ExpedientesLaborales.Add(new ExpedientesLaborales() { Id = 1, NombreEmpresa = "TechSolutions S.A", Cargo = "Desarrollador Junior", SalarioPagado = 1800000m, FechaIngreso = new DateTime(2021, 2, 15), FechaEgreso = new DateTime(2022, 6, 30), Desempeño = "Excelente", MotivoSalida = "Mejor oportunidad laboral" });
Lista_ExpedientesLaborales.Add(new ExpedientesLaborales() {Id = 2, NombreEmpresa = "Innovatech Ltda", Cargo = "Soporte Tecnico", SalarioPagado = 1500000m, FechaIngreso = new DateTime(2020, 1, 10), FechaEgreso = new DateTime(2021, 1, 30), Desempeño = "Bueno", MotivoSalida = "Fin de contrato" });
Lista_ExpedientesLaborales.Add(new ExpedientesLaborales() { Id = 3, NombreEmpresa = "GlobalSoft", Cargo = "Analista de Sistemas", SalarioPagado = 2500000m, FechaIngreso = new DateTime(2022, 7, 1), FechaEgreso = new DateTime(2023, 12, 15), Desempeño = "Sobresaliente", MotivoSalida = "Cambio de ciudad" });
Lista_ExpedientesLaborales.Add(new ExpedientesLaborales() {Id = 4, NombreEmpresa = "DataCorp", Cargo = "Administrador de Base de Datos", SalarioPagado = 3200000m, FechaIngreso = new DateTime(2023, 1, 5), FechaEgreso = new DateTime(2024, 3, 20), Desempeño = "Excelente", MotivoSalida = "Crecimiento profesional" });
Lista_ExpedientesLaborales.Add(new ExpedientesLaborales() {Id = 5, NombreEmpresa = "CyberNet", Cargo = "Desarrollador Full Stack", SalarioPagado = 4000000m, FechaIngreso = new DateTime(2024, 4, 1), FechaEgreso = new DateTime(2025, 2, 28), Desempeño = "Muy Bueno", MotivoSalida = "Proyecto finalizado"});
foreach (var Expedientes in Lista_ExpedientesLaborales)
{
    System.Console.WriteLine(Expedientes.Id + " | " + Expedientes.NombreEmpresa + " | " + Expedientes.Cargo + " | " + Expedientes.SalarioPagado + " | " + Expedientes.FechaIngreso + " | " + Expedientes.FechaEgreso + " | " + Expedientes.Desempeño + " | " + Expedientes.MotivoSalida);
}

System.Console.WriteLine("BIENES MUEBLES: ");
var Lista_BienesMuebles = new List<BienesMuebles>();
Lista_BienesMuebles.Add(new BienesMuebles() { Id = 1, Nombre = "Laptop Empresarial", Descripcion = "Portatil para trabajo administrativo", FechaAdquisicion = new DateTime(2023, 5, 10), PrecioCompra = 3500000m, ValorActual = 2800000m, Tipo = "Tecnologico", Modelo = "Dell Latitude 5520", UbicacionActual = "Oficina Principal", Garantia = "2 años", Estado = "Activo" });
Lista_BienesMuebles.Add(new BienesMuebles() { Id = 2, Nombre = "Impresora Multifuncional", Descripcion = "Impresora laser con escaner", FechaAdquisicion = new DateTime(2022, 8, 15), PrecioCompra = 1200000m, ValorActual = 800000m, Tipo = "Tecnologico", Modelo = "HP LaserJet Pro M428fdw", UbicacionActual = "Area Administrativa", Garantia = "1 año", Estado = "Activo" });
Lista_BienesMuebles.Add(new BienesMuebles() { Id = 3, Nombre = "Escritorio Ejecutivo", Descripcion = "Escritorio de madera con gavetas", FechaAdquisicion = new DateTime(2021, 3, 20), PrecioCompra = 900000m, ValorActual = 600000m, Tipo = "Mobiliario", Modelo = "Moderno X200", UbicacionActual = "Gerencia", Garantia = "Sin garantia", Estado = "En uso" });
Lista_BienesMuebles.Add(new BienesMuebles() { Id = 4, Nombre = "Vehiculo Corporativo", Descripcion = "Automovil para diligencias empresariales", FechaAdquisicion = new DateTime(2020, 11, 5), PrecioCompra = 55000000m, ValorActual = 42000000m, Tipo = "Transporte", Modelo = "Chevrolet Onix 2020", UbicacionActual = "Parqueadero Principal", Garantia = "Vencida", Estado = "Activo" });
Lista_BienesMuebles.Add(new BienesMuebles() { Id = 5, Nombre = "Servidor Empresarial", Descripcion = "Servidor para almacenamiento de datos", FechaAdquisicion = new DateTime(2024, 1, 12), PrecioCompra = 15000000m, ValorActual = 14000000m, Tipo = "Tecnologico", Modelo = "HP ProLiant DL380", UbicacionActual = "Centro de Datos", Garantia = "3 años", Estado = "Activo" });
foreach (var Bienes in Lista_BienesMuebles)
{
    System.Console.WriteLine(Bienes.Id + " | " + Bienes.Nombre + " | " + Bienes.Descripcion + " | " + Bienes.FechaAdquisicion + " | " + Bienes.PrecioCompra + " | " + Bienes.ValorActual + " | " + Bienes.Tipo + " | " + Bienes.Modelo + " | " + Bienes.UbicacionActual + " | " + Bienes.Garantia + " | " + Bienes.Estado);
}

System.Console.WriteLine("BIENES INMUEBLES: ");
var Lista_BienesInmuebles = new List<BienesInmuebles>();
Lista_BienesInmuebles.Add(new BienesInmuebles() { Id = 1, Nombre = "Casa Campestre", Descripcion = "Vivienda ubicada en zona rural", FechaAdquisicion = new DateTime(2019, 6, 15), PrecioCompra = 250000000m, ValorActual = 310000000m, MetrosCuadrados = 180m, Direccion = "Vereda El Rosal, Medellin", EstadoConservacion = "Excelente", Estrato = "4", NumeroHabitaciones = "4", NumeroBaños = "3", CodigoCUC = "CUC-001-2019", EncargosDeudas = "Libre de deudas" });
Lista_BienesInmuebles.Add(new BienesInmuebles() { Id = 2, Nombre = "Apartamento Centro", Descripcion = "Apartamento en zona urbana", FechaAdquisicion = new DateTime(2021, 3, 10), PrecioCompra = 180000000m, ValorActual = 210000000m, MetrosCuadrados = 85m, Direccion = "Cra 45 #50-20, Medellin", EstadoConservacion = "Bueno", Estrato = "5", NumeroHabitaciones = "3", NumeroBaños = "2", CodigoCUC = "CUC-002-2021", EncargosDeudas = "Hipoteca vigente" });
Lista_BienesInmuebles.Add(new BienesInmuebles() { Id = 3, Nombre = "Local Comercial", Descripcion = "Local en centro comercial", FechaAdquisicion = new DateTime(2018, 11, 5), PrecioCompra = 320000000m, ValorActual = 400000000m, MetrosCuadrados = 120m, Direccion = "CC Mayorca Local 210, Sabaneta", EstadoConservacion = "Excelente", Estrato = "6", NumeroHabitaciones = "N/A", NumeroBaños = "1", CodigoCUC = "CUC-003-2018", EncargosDeudas = "Libre de deudas" });
Lista_BienesInmuebles.Add(new BienesInmuebles() { Id = 4, Nombre = "Bodega Industrial", Descripcion = "Bodega para almacenamiento", FechaAdquisicion = new DateTime(2017, 9, 18), PrecioCompra = 600000000m, ValorActual = 750000000m, MetrosCuadrados = 450m, Direccion = "Zona Industrial Itagui", EstadoConservacion = "Regular", Estrato = "3", NumeroHabitaciones = "N/A", NumeroBaños = "2", CodigoCUC = "CUC-004-2017", EncargosDeudas = "Embargo parcial" });
Lista_BienesInmuebles.Add(new BienesInmuebles() { Id = 5, Nombre = "Finca Recreativa", Descripcion = "Finca para descanso y eventos", FechaAdquisicion = new DateTime(2022, 1, 25), PrecioCompra = 450000000m, ValorActual = 520000000m, MetrosCuadrados = 600m, Direccion = "Guarne Antioquia", EstadoConservacion = "Bueno", Estrato = "2", NumeroHabitaciones = "5", NumeroBaños = "4", CodigoCUC = "CUC-005-2022", EncargosDeudas = "Libre de deudas" });
foreach (var Bienes in Lista_BienesInmuebles)
{
    System.Console.WriteLine(Bienes.Id + " | " + Bienes.Nombre + " | " + Bienes.Descripcion + " | " + Bienes.FechaAdquisicion + " | " + Bienes.PrecioCompra + " | " + Bienes.ValorActual + " | " + Bienes.MetrosCuadrados + " | " + Bienes.Direccion + " | " + Bienes.EstadoConservacion + " | " + Bienes.Estrato + " | " + Bienes.NumeroHabitaciones + " | " + Bienes.NumeroBaños + " | " + Bienes.CodigoCUC + " | " + Bienes.EncargosDeudas);
}

System.Console.WriteLine("TELEFONOS: ");
var Lista_Telefonos = new List<Telefonos>();
Lista_Telefonos.Add(new Telefonos() {Id = 1, Numero = "32312421441", Prefijo = "+57"});
Lista_Telefonos.Add(new Telefonos() {Id = 2, Numero = "12412412412", Prefijo = "+1"});
Lista_Telefonos.Add(new Telefonos() {Id = 3, Numero = "41241244124", Prefijo = "+30"});
Lista_Telefonos.Add(new Telefonos() {Id = 4, Numero = "51245134515", Prefijo = "+41"});
Lista_Telefonos.Add(new Telefonos() {Id = 5, Numero = "12341415515", Prefijo = "+22"});
foreach (var Telefonos in Lista_Telefonos)
{
    System.Console.WriteLine(Telefonos.Id + " | " + Telefonos.Numero + " | " + Telefonos.Prefijo);
}

System.Console.WriteLine("ACTIVOS FINANCIEROS: ");
var Lista_ActviosFinancieros = new List<ActivosFinancieros>();
Lista_ActviosFinancieros.Add(new ActivosFinancieros() { Id = 1, Nombre = "Acciones Bancolombia", Descripcion = "Compra de acciones ordinarias en bolsa", FechaAdquisicion = new DateTime(2023, 2, 15), Precio = 15000000m });
Lista_ActviosFinancieros.Add(new ActivosFinancieros() { Id = 2, Nombre = "Bonos del Estado", Descripcion = "Inversion en bonos gubernamentales a 5 años", FechaAdquisicion = new DateTime(2022, 7, 10), Precio = 25000000m });
Lista_ActviosFinancieros.Add(new ActivosFinancieros() { Id = 3, Nombre = "CDT Bancario", Descripcion = "Certificado de deposito a termino", FechaAdquisicion = new DateTime(2024, 1, 5), Precio = 10000000m });
Lista_ActviosFinancieros.Add(new ActivosFinancieros() { Id = 4, Nombre = "Fondo de Inversion", Descripcion = "Participacion en fondo de inversion colectiva", FechaAdquisicion = new DateTime(2021, 11, 20), Precio = 18000000m });
Lista_ActviosFinancieros.Add(new ActivosFinancieros() { Id = 5, Nombre = "Criptomoneda Bitcoin", Descripcion = "Compra de activo digital BTC", FechaAdquisicion = new DateTime(2023, 9, 12), Precio = 22000000m });
foreach (var Activos in Lista_ActviosFinancieros)
{
    System.Console.WriteLine(Activos.Id + " | " + Activos.Nombre + " | " + Activos.Descripcion + " | " + Activos.FechaAdquisicion + " | " + Activos.Precio);
}

System.Console.WriteLine("EXPEDIENTES FINANCIEROS: ");
var Lista_ExpedientesFinancieros = new List<ExpedientesFinancieros>();
Lista_ExpedientesFinancieros.Add(new ExpedientesFinancieros() {Id = 1});
Lista_ExpedientesFinancieros.Add(new ExpedientesFinancieros() {Id = 2});
Lista_ExpedientesFinancieros.Add(new ExpedientesFinancieros() {Id = 3});
Lista_ExpedientesFinancieros.Add(new ExpedientesFinancieros() {Id = 4});
Lista_ExpedientesFinancieros.Add(new ExpedientesFinancieros() {Id = 5});
foreach (var Expedientes in Lista_ExpedientesFinancieros)
{
    System.Console.WriteLine(Expedientes.Id);
}

System.Console.WriteLine("ESTADOS CIVILES EN COLOMBIA: ");
var Lista_EstadosCiviles = new List<EstadosCiviles>();
Lista_EstadosCiviles.Add( new EstadosCiviles() {Id = 1, Nombre = "Soltero"});
Lista_EstadosCiviles.Add( new EstadosCiviles() {Id = 2, Nombre = "Casado"});
Lista_EstadosCiviles.Add( new EstadosCiviles() {Id = 3, Nombre = "Divorciado"});
Lista_EstadosCiviles.Add( new EstadosCiviles() {Id = 4, Nombre = "Viudo"});
Lista_EstadosCiviles.Add( new EstadosCiviles() {Id = 5, Nombre = "Union Libre"});
foreach (var Estados in Lista_EstadosCiviles)
{
    System.Console.WriteLine(Estados.Id + " | " + Estados.Nombre);
}

System.Console.WriteLine("LISTA NACIONALIDADES: ");
var Lista_Nacionalidades = new List<Nacionalidades>();
Lista_Nacionalidades.Add(new Nacionalidades() {Id = 1, Nombre = "Colombiana"});
Lista_Nacionalidades.Add(new Nacionalidades() {Id = 2, Nombre = "Argentina"});
Lista_Nacionalidades.Add(new Nacionalidades() {Id = 3, Nombre = "Chilena"});
Lista_Nacionalidades.Add(new Nacionalidades() {Id = 4, Nombre = "Española"});
Lista_Nacionalidades.Add(new Nacionalidades() {Id = 5, Nombre = "Africana"});
foreach (var Nacionalidades in Lista_Nacionalidades)
{
    System.Console.WriteLine(Nacionalidades.Id + " | " + Nacionalidades.Nombre);
}

System.Console.WriteLine("LISTA DE CIUDADES: ");
var Lista_Ciudades = new List<Ciudades>();
Lista_Ciudades.Add(new Ciudades() { Id = 1, Nombre = "Medellin", Estado = true, Poblacion = "2500000", FechaCreacion = new DateTime(1616, 3, 2), CodigoPostal = 050001 });
Lista_Ciudades.Add(new Ciudades() { Id = 2, Nombre = "Bogota", Estado = true, Poblacion = "7800000", FechaCreacion = new DateTime(1538, 8, 6), CodigoPostal = 110111 });
Lista_Ciudades.Add(new Ciudades() { Id = 3, Nombre = "Cali", Estado = true, Poblacion = "2200000", FechaCreacion = new DateTime(1536, 7, 25), CodigoPostal = 760001 });
Lista_Ciudades.Add(new Ciudades() { Id = 4, Nombre = "Cartagena", Estado = true, Poblacion = "1000000", FechaCreacion = new DateTime(1533, 6, 1), CodigoPostal = 130001 });
Lista_Ciudades.Add(new Ciudades() { Id = 5, Nombre = "Barranquilla", Estado = true, Poblacion = "1300000", FechaCreacion = new DateTime(1813, 4, 7), CodigoPostal = 080001 });
foreach (var Ciudad in Lista_Ciudades)
{
    System.Console.WriteLine(Ciudad.Id + " | " + Ciudad.Nombre + " | " + Ciudad.Estado + " | " + Ciudad.Poblacion + " | " + Ciudad.FechaCreacion + " | " + Ciudad.CodigoPostal);
}

System.Console.WriteLine("LISTA DE ADMINISTRADORES: ");
var Lista_AdministradoresDepartamentos = new List<AdministradoresDepartamentos>();
Lista_AdministradoresDepartamentos.Add(new AdministradoresDepartamentos() {Cedula = "132443242", Nombre = "Luis Alberto", Apellido = "Arango Martinez", Genero = 'M', Correo = "Luisalberto@Gmail.com", FechaNacimiento = new DateTime(2002,08,19), FechaRegistro = DateTime.Now, Sueldo = 7500000, Estado = true, Jornada = "Diurna", PresupuestoDepartamento = 32500000.0m});
Lista_AdministradoresDepartamentos.Add(new AdministradoresDepartamentos() {Cedula = "214312341", Nombre = "Gilma Rosa", Apellido = "Garcia Meneses", Genero = 'F', Correo = "GilmaRosa@Gmail.com", FechaNacimiento = new DateTime(2000,02,10), FechaRegistro = DateTime.Now, Sueldo = 8500000, Estado = true, Jornada = "Especial", PresupuestoDepartamento = 33500000.0m});
Lista_AdministradoresDepartamentos.Add(new AdministradoresDepartamentos() {Cedula = "512341234", Nombre = "Luis Miguel", Apellido = "Arango Garcia", Genero = 'M', Correo = "LuisMiguel@Gmail.com", FechaNacimiento = new DateTime(2004,03,11), FechaRegistro = DateTime.Now, Sueldo = 4500000, Estado = true, Jornada = "Parcial", PresupuestoDepartamento = 34500000.0m});
Lista_AdministradoresDepartamentos.Add(new AdministradoresDepartamentos() {Cedula = "124312433", Nombre = "Maria Camila", Apellido = "Arango Martinez", Genero = 'F', Correo = "MariaCamila@Gmail.com", FechaNacimiento = new DateTime(2003,11,11), FechaRegistro = DateTime.Now, Sueldo = 5500000, Estado = true, Jornada = "Diurna", PresupuestoDepartamento = 355500000.0m});
Lista_AdministradoresDepartamentos.Add(new AdministradoresDepartamentos() {Cedula = "523412123", Nombre = "Valentina Sofia", Apellido = "Martinez Ocampo", Genero = 'F', Correo = "ValentinaSofia@Gmail.com", FechaNacimiento = new DateTime(2005,02,12), FechaRegistro = DateTime.Now, Sueldo = 3500000, Estado = true, Jornada = "Continua", PresupuestoDepartamento = 32500000.0m});
foreach (var Admins in Lista_AdministradoresDepartamentos)
{
    System.Console.WriteLine(Admins.Id + " | " + Admins.Cedula + " | " + Admins.Nombre + " | "  + Admins.Apellido + " | " + Admins.Genero + " | " + Admins.Correo + " | " + Admins.FechaNacimiento + " | " + Admins.FechaRegistro + " | " + Admins.PresupuestoDepartamento);
}

System.Console.WriteLine("DEPARTAMENTOS: ");
var Lista_Departamentos = new List<Departamentos>();
Lista_Departamentos.Add(new Departamentos() { Id = 1, Nombre = "Antioquia", Estado = true, FechaCreacion = new DateTime(1826, 6, 25), Poblacion = "6700000" });
Lista_Departamentos.Add(new Departamentos() { Id = 2, Nombre = "Cundinamarca", Estado = true, FechaCreacion = new DateTime(1886, 8, 5), Poblacion = "3200000" });
Lista_Departamentos.Add(new Departamentos() { Id = 3, Nombre = "Valle del Cauca", Estado = true, FechaCreacion = new DateTime(1910, 4, 16), Poblacion = "4500000" });
Lista_Departamentos.Add(new Departamentos() { Id = 4, Nombre = "Bolivar", Estado = true, FechaCreacion = new DateTime(1857, 6, 15), Poblacion = "2100000" });
Lista_Departamentos.Add(new Departamentos() { Id = 5, Nombre = "Atlantico", Estado = false, FechaCreacion = new DateTime(1905, 4, 11), Poblacion = "2700000" });
foreach (var Departamento in Lista_Departamentos)
{
    System.Console.WriteLine(Departamento.Id + " | " + Departamento.Nombre + " | " + Departamento.Estado + " | " + Departamento.FechaCreacion + " | " + Departamento.Poblacion);
}

System.Console.WriteLine("JEFES DE SECTORES: ");
var Lista_JefesSectores = new List<JefesSectores>();
Lista_JefesSectores.Add(new JefesSectores() {Cedula = "901234567", Nombre = "Ricardo", Apellido = "Montoya Perez", Genero = 'M', Correo = "Ricardo@gmail.com", FechaNacimiento = new DateTime(1985,03,12), FechaRegistro = DateTime.Now, Sueldo = 2500000, Estado = true, Jornada = "Diurna", PresupuestoSector = 4500000.0m});
Lista_JefesSectores.Add(new JefesSectores() {Cedula = "902345678", Nombre = "Patricia", Apellido = "Gomez Herrera", Genero = 'F', Correo = "Patricia@gmail.com", FechaNacimiento = new DateTime(1988,07,25), FechaRegistro = DateTime.Now, Sueldo = 3500000, Estado = true, Jornada = "Mixta", PresupuestoSector = 3500000.0m});
Lista_JefesSectores.Add(new JefesSectores() {Cedula = "903456789", Nombre = "Fernando", Apellido = "Rios Salgado", Genero = 'M', Correo = "Fernando@gmail.com", FechaNacimiento = new DateTime(1982,11,08), FechaRegistro = DateTime.Now, Sueldo = 2300000, Estado = false, Jornada = "Nocturna", PresupuestoSector = 2500000.0m});
Lista_JefesSectores.Add(new JefesSectores() {Cedula = "904567890", Nombre = "Claudia", Apellido = "Martinez León", Genero = 'F', Correo = "Claudia@gmail.com", FechaNacimiento = new DateTime(1990,01,17), FechaRegistro = DateTime.Now, Sueldo = 3200000, Estado = true, Jornada = "Ordinaria", PresupuestoSector = 1500000.0m});
Lista_JefesSectores.Add(new JefesSectores() {Cedula = "905678901", Nombre = "Hector", Apellido = "Suarez Medina", Genero = 'M', Correo = "Hector@gmail.com", FechaNacimiento = new DateTime(1987,09,03), FechaRegistro = DateTime.Now, Sueldo = 2200000, Estado = false, Jornada = "Nocturna", PresupuestoSector = 4500000.0m});
foreach (var Jefes in Lista_JefesSectores)
{
    System.Console.WriteLine(Jefes.Id + " | " + Jefes.Cedula + " | " + Jefes.Nombre + " | "  + Jefes.Apellido + " | " + Jefes.Genero + " | " + Jefes.Correo + " | " + Jefes.FechaNacimiento + " | " + Jefes.FechaRegistro + " | " + Jefes.PresupuestoSector);    
}

System.Console.WriteLine("EMPLEADOS DE SECTORES: ");
var Lista_EmpleadosSectores = new List<EmpleadosSectores>();
Lista_EmpleadosSectores.Add(new EmpleadosSectores() {Cedula = "801234567", Nombre = "Natalia", Apellido = "Castillo Ramos", Genero = 'F', Correo = "Natalia@gmail.com", FechaNacimiento = new DateTime(1999,04,10), FechaRegistro = DateTime.Now, Sueldo = 7500000, Estado = true, Jornada = "Diurna"});
Lista_EmpleadosSectores.Add(new EmpleadosSectores() {Cedula = "802345678", Nombre = "Juan Diego", Apellido = "Lopez Vargas", Genero = 'M', Correo = "Juandiego@gmail.com", FechaNacimiento = new DateTime(2000,06,21), FechaRegistro = DateTime.Now, Sueldo = 7500000, Estado = true, Jornada = "Nocturna"});
Lista_EmpleadosSectores.Add(new EmpleadosSectores() {Cedula = "803456789", Nombre = "Sofia", Apellido = "Ramirez Castro", Genero = 'F', Correo = "Sofia@gmail.com", FechaNacimiento = new DateTime(1998,12,14), FechaRegistro = DateTime.Now, Sueldo = 7500000, Estado = true, Jornada = "Ordinaria"});
Lista_EmpleadosSectores.Add(new EmpleadosSectores() {Cedula = "804567890", Nombre = "Miguel Angel", Apellido = "Torres Peña", Genero = 'M', Correo = "Miguel@gmail.com", FechaNacimiento = new DateTime(1997,02,28), FechaRegistro = DateTime.Now, Sueldo = 7500000, Estado = true, Jornada = "Parcial"});
Lista_EmpleadosSectores.Add(new EmpleadosSectores() {Cedula = "805678901", Nombre = "Laura", Apellido = "Herrera Soto", Genero = 'F', Correo = "Laura@gmail.com", FechaNacimiento = new DateTime(2001,10,05), FechaRegistro = DateTime.Now, Sueldo = 7500000, Estado = true, Jornada = "Ordinaria"});
foreach (var Empleados in Lista_EmpleadosSectores)
{
    System.Console.WriteLine(Empleados.Id + " | " + Empleados.Cedula + " | " + Empleados.Nombre + " | "  + Empleados.Apellido + " | " + Empleados.Genero + " | " + Empleados.Correo + " | " + Empleados.FechaNacimiento + " | " + Empleados.FechaRegistro + " | " + Empleados.Sueldo + " | " + Empleados.Estado + " | " + Empleados.Jornada + " | " + Empleados.TipoContrato);    
}

System.Console.WriteLine("SECTORES: ");
var Lista_Sectores = new List<Sectores>();
Lista_Sectores.Add(new Sectores() { Id = 1, Nombre = "Gestion Integral Inmobiliaria", Estado = true, FechaCreacion = new DateTime(2016, 3, 14) });
Lista_Sectores.Add(new Sectores() { Id = 2, Nombre = "Estrategia y Desarrollo Inmobiliario", Estado = true, FechaCreacion = new DateTime(2017, 7, 22) });
Lista_Sectores.Add(new Sectores() { Id = 3, Nombre = "Operaciones y Administracion de Activos", Estado = true, FechaCreacion = new DateTime(2018, 1, 9) });
Lista_Sectores.Add(new Sectores() { Id = 4, Nombre = "Planeacion y Expansión Territorial", Estado = true, FechaCreacion = new DateTime(2019, 5, 30) });
Lista_Sectores.Add(new Sectores() { Id = 5, Nombre = "Servicios Corporativos Inmobiliarios", Estado = false, FechaCreacion = new DateTime(2020, 10, 12) });
foreach (var Sector in Lista_Sectores)
{
    System.Console.WriteLine(Sector.Id + " | " + Sector.Nombre + " | " + Sector.Estado + " | " + Sector.FechaCreacion);
}

System.Console.WriteLine("TIPOS DE PROPIEDADES: ");
var Lista_TiposPropiedades = new List<TiposPropiedades>();
Lista_TiposPropiedades.Add(new TiposPropiedades() { Id = 1, Nombre = "Casa" });
Lista_TiposPropiedades.Add(new TiposPropiedades() { Id = 2, Nombre = "Apartamento" });
Lista_TiposPropiedades.Add(new TiposPropiedades() { Id = 3, Nombre = "Edificio" });
Lista_TiposPropiedades.Add(new TiposPropiedades() { Id = 4, Nombre = "Bodega" });
Lista_TiposPropiedades.Add(new TiposPropiedades() { Id = 5, Nombre = "Oficina" });
foreach (var TipoPropiedad in Lista_TiposPropiedades)
{
    System.Console.WriteLine(TipoPropiedad.Id + " | " + TipoPropiedad.Nombre);
}

System.Console.WriteLine("PROPIEDADES: ");
var Lista_Propiedades = new List<Propiedades>();
Lista_Propiedades.Add(new Propiedades() { Id = 1, NumeroHabitaciones = 3, NumeroBaños = 2, Patio = true, Entradas = 1, Pisos = 2, AñoConstruccion = new DateTime(2015, 1, 1), ValorPropiedad = 320000000m, ValorArriendo = 1800000m, Estado = "Disponible" });
Lista_Propiedades.Add(new Propiedades() { Id = 2, NumeroHabitaciones = 4, NumeroBaños = 3, Patio = true, Entradas = 2, Pisos = 1, AñoConstruccion = new DateTime(2018, 1, 1), ValorPropiedad = 450000000m, ValorArriendo = 2500000m, Estado = "En negociacion" });
Lista_Propiedades.Add(new Propiedades() { Id = 3, NumeroHabitaciones = 2, NumeroBaños = 1, Patio = false, Entradas = 1, Pisos = 1, AñoConstruccion = new DateTime(2020, 1, 1), ValorPropiedad = 210000000m, ValorArriendo = 1300000m, Estado = "Disponible" });
Lista_Propiedades.Add(new Propiedades() { Id = 4, NumeroHabitaciones = 5, NumeroBaños = 4, Patio = true, Entradas = 2, Pisos = 3, AñoConstruccion = new DateTime(2012, 1, 1), ValorPropiedad = 680000000m, ValorArriendo = 3500000m, Estado = "Vendida" });
Lista_Propiedades.Add(new Propiedades() { Id = 5, NumeroHabitaciones = 3, NumeroBaños = 2, Patio = false, Entradas = 1, Pisos = 2, AñoConstruccion = new DateTime(2017, 1, 1), ValorPropiedad = 290000000m, ValorArriendo = 1600000m, Estado = "Arrendada" });
foreach (var Propiedad in Lista_Propiedades)
{
    System.Console.WriteLine(Propiedad.Id + " | " + Propiedad.NumeroHabitaciones + " | " + Propiedad.NumeroBaños + " | " + Propiedad.Patio + " | " + Propiedad.Entradas + " | " + Propiedad.Pisos + " | " + Propiedad.AñoConstruccion + " | " + Propiedad.ValorPropiedad + " | " + Propiedad.ValorArriendo + " | " + Propiedad.Estado);
}

System.Console.WriteLine("CLIENTES: ");
var Lista_Clientes = new List<Clientes>();
Lista_Clientes.Add(new Clientes() {Cedula = "1018456321", Nombre = "Laura", Apellido = "Gomez", Genero = 'F', Correo = "laura.gomez@gmail.com", FechaNacimiento = new DateTime(1990, 5, 14), FechaRegistro = DateTime.Now, PorcentajeComision = 3.5m, CantidadContratos = 2, MotivoVenta = "Inversion en nuevo proyecto" });
Lista_Clientes.Add(new Clientes() {Cedula = "1032678945", Nombre = "Andres", Apellido = "Martinez", Genero = 'M', Correo = "andres.martinez@gmail.com", FechaNacimiento = new DateTime(1985, 8, 22), FechaRegistro = DateTime.Now, PorcentajeComision = 2.8m, CantidadContratos = 5, MotivoVenta = "Cambio de ciudad" });
Lista_Clientes.Add(new Clientes() {Cedula = "1032678945", Nombre = "Andres", Apellido = "Martinez", Genero = 'M', Correo = "andres.martinez@gmail.com", FechaNacimiento = new DateTime(1985, 8, 22), FechaRegistro = DateTime.Now, PorcentajeComision = 2.8m, CantidadContratos = 5, MotivoVenta = "Cambio de ciudad" });
Lista_Clientes.Add(new Clientes() {Cedula = "1098765432", Nombre = "Sebastian", Apellido = "Hernandez", Genero = 'M', Correo = "sebastian.hernandez@gmail.com", FechaNacimiento = new DateTime(1988, 11, 30), FechaRegistro = DateTime.Now, PorcentajeComision = 3.0m, CantidadContratos = 3, MotivoVenta = "Necesidad de liquidez" });
Lista_Clientes.Add(new Clientes() {Cedula = "1029384756", Nombre = "Valentina", Apellido = "Morales", Genero = 'F', Correo = "valentina.morales@gmail.com", FechaNacimiento = new DateTime(1995, 1, 18), FechaRegistro = DateTime.Now, PorcentajeComision = 2.5m, CantidadContratos = 4, MotivoVenta = "Compra de vivienda mas grande" });
foreach (var Cliente in Lista_Clientes)
{
    System.Console.WriteLine(Cliente.Id + " | " + Cliente.Cedula + " | " + Cliente.Nombre + " | "  + Cliente.Apellido + " | " + Cliente.Genero + " | " + Cliente.Correo + " | " + Cliente.FechaNacimiento + " | " + Cliente.FechaRegistro + " | " + Cliente.PorcentajeComision + " | " + Cliente.CantidadContratos + " | " + Cliente.MotivoVenta);
}

System.Console.WriteLine("CODEUDORES: ");
var Lista_Codeudores = new List<Codeudores>();
Lista_Codeudores.Add(new Codeudores() {Cedula = "1012345678", Nombre = "Andres Felipe", Apellido = "Gomez Rios", Genero = 'M', Correo = "andresgomez@gmail.com", FechaNacimiento = new DateTime(1995, 03, 12), FechaRegistro = DateTime.Now });
Lista_Codeudores.Add(new Codeudores() {Cedula = "1023456789", Nombre = "Maria Fernanda", Apellido = "Lopez Martinez", Genero = 'F', Correo = "marialopez@gmail.com", FechaNacimiento = new DateTime(1998, 07, 25), FechaRegistro = DateTime.Now });
Lista_Codeudores.Add(new Codeudores() {Cedula = "1034567890", Nombre = "Juan Esteban", Apellido = "Cardona Perez", Genero = 'M', Correo = "juancardona@gmail.com", FechaNacimiento = new DateTime(1992, 11, 05), FechaRegistro = DateTime.Now });
Lista_Codeudores.Add(new Codeudores() {Cedula = "1045678901", Nombre = "Laura Sofia", Apellido = "Ramirez Torres", Genero = 'F', Correo = "lauraramirez@gmail.com", FechaNacimiento = new DateTime(1996, 01, 18), FechaRegistro = DateTime.Now });
Lista_Codeudores.Add(new Codeudores() {Cedula = "1056789012", Nombre = "Sebastian", Apellido = "Hernandez Castro", Genero = 'M', Correo = "sebastianh@gmail.com", FechaNacimiento = new DateTime(1994, 09, 30), FechaRegistro = DateTime.Now });
foreach (var Codeudor in Lista_Codeudores)
{
    System.Console.WriteLine(Codeudor.Id + " | " + Codeudor.Cedula + " | " + Codeudor.Nombre + " | "  + Codeudor.Apellido + " | " + Codeudor.Genero + " | " + Codeudor.Correo + " | " + Codeudor.FechaNacimiento + " | " + Codeudor.FechaRegistro);
}

System.Console.WriteLine("EMPLEADO Y COMPRADORES: ");
var Lista_EmpleadosCompradores = new List<EmpleadosCompradores>();
Lista_EmpleadosCompradores.Add(new EmpleadosCompradores () {Id = 1, FechaAsesoramiento = new DateTime(2006, 02, 13)});
Lista_EmpleadosCompradores.Add(new EmpleadosCompradores () {Id = 1, FechaAsesoramiento = new DateTime(2002, 01, 20)});
Lista_EmpleadosCompradores.Add(new EmpleadosCompradores () {Id = 1, FechaAsesoramiento = new DateTime(2001, 11, 22)});
Lista_EmpleadosCompradores.Add(new EmpleadosCompradores () {Id = 1, FechaAsesoramiento = new DateTime(2009, 10, 13)});
Lista_EmpleadosCompradores.Add(new EmpleadosCompradores () {Id = 1, FechaAsesoramiento = new DateTime(2022, 03, 16)});
foreach (var EmpleadoComprador in Lista_EmpleadosCompradores)
{
    System.Console.WriteLine(EmpleadoComprador.Id + " | " + EmpleadoComprador.FechaAsesoramiento);
}

System.Console.WriteLine("COMPRADORES: ");
var Lista_Compradores = new List<Compradores>();
Lista_Compradores.Add(new Compradores() {Cedula = "1012345678", Nombre = "Andres ", Apellido = "Saramillo Soez", Genero = 'M', Correo = "andresgomez@gmail.com", FechaNacimiento = new DateTime(1991, 02, 11), FechaRegistro = DateTime.Now });
Lista_Compradores.Add(new Compradores() {Cedula = "1324123412", Nombre = "Diana valentina", Apellido = "Sanchez Sanchez", Genero = 'F', Correo = "dianavalentina@gmail.com", FechaNacimiento = new DateTime(1993, 11, 10), FechaRegistro = DateTime.Now });
Lista_Compradores.Add(new Compradores() {Cedula = "4324132411", Nombre = "Rigoberto", Apellido = "Gomez Rios", Genero = 'M', Correo = "rigoberto@gmail.com", FechaNacimiento = new DateTime(1991, 03, 12), FechaRegistro = DateTime.Now });
Lista_Compradores.Add(new Compradores() {Cedula = "5123412323", Nombre = "Juan esteban", Apellido = "Quintana Restrepo", Genero = 'M', Correo = "juanesteban@gmail.com", FechaNacimiento = new DateTime(1980, 12, 11), FechaRegistro = DateTime.Now });
Lista_Compradores.Add(new Compradores() {Cedula = "4123412341", Nombre = "Thomas", Apellido = "Rua Rua", Genero = 'M', Correo = "thomas@gmail.com", FechaNacimiento = new DateTime(1994, 02, 03), FechaRegistro = DateTime.Now });
foreach (var Comprador in Lista_Compradores)
{
    System.Console.WriteLine(Comprador.Cedula + " | " + Comprador.Nombre + " | " + Comprador.Apellido + " | " + Comprador.Genero + " | " + Comprador.Correo + " | " + Comprador.FechaNacimiento + " | " + Comprador.FechaRegistro);
}

System.Console.WriteLine("CONTRATOS: ");
var Lista_Contratos = new List<Contratos>();
Lista_Contratos.Add(new Contratos () {Id = 1, FechaContrato = new DateTime(2006, 02, 25), PrecioAcordado = 250000000, FechaFinalizacion = new DateTime(2009, 10,26), Obsevaciones = "Casa estable, buen diseño y excelente calidad de materiales", ArriendoVenta = "Arriendo"});
Lista_Contratos.Add(new Contratos () {Id = 2, FechaContrato = new DateTime(2022, 01, 12), PrecioAcordado = 430000000, Obsevaciones = "Casa excelente, buen diseño y a buen precio", ArriendoVenta = "Venta"});
Lista_Contratos.Add(new Contratos () {Id = 3, FechaContrato = new DateTime(2011, 06, 22), PrecioAcordado = 230000000, Obsevaciones = "Casa buena, buen diseño y a buen precio", ArriendoVenta = "Venta"});
Lista_Contratos.Add(new Contratos () {Id = 4, FechaContrato = new DateTime(2023, 12, 01), PrecioAcordado = 110000000, FechaFinalizacion = new DateTime(2026, 10, 11), Obsevaciones = "Casa indiferente, buen  y a buen precio", ArriendoVenta = "Arriendo"});
Lista_Contratos.Add(new Contratos () {Id = 5, FechaContrato = new DateTime(2004, 11, 12), PrecioAcordado = 650000000, Obsevaciones = "Casa comun, buen diseño y a buen precio", ArriendoVenta = "Vental"});
foreach (var Contrato in Lista_Contratos)
{
    System.Console.WriteLine(Contrato.Id + " | " + Contrato.FechaContrato + " | " + Contrato.PrecioAcordado + " | " + Contrato.FechaFinalizacion + " | " + Contrato.Obsevaciones + " | " + Contrato.ArriendoVenta);
}

System.Console.WriteLine("CONTRATO Y EMPLEADO: ");
var Lista_ContratosEmpleados = new List<ContratosEmpleados>();
Lista_ContratosEmpleados.Add(new ContratosEmpleados() {Id = 1, FechaCierre = new DateTime(2006, 09, 11), PrecioAcordado = 35000000, VendidaArrendada = "Vendida"});
Lista_ContratosEmpleados.Add(new ContratosEmpleados() {Id = 1, FechaCierre = new DateTime(2002, 04, 19), PrecioAcordado = 75000000, VendidaArrendada = "Vendida"});
Lista_ContratosEmpleados.Add(new ContratosEmpleados() {Id = 1, FechaCierre = new DateTime(2001, 06, 10), PrecioAcordado = 10000000, VendidaArrendada = "Arrendada"});
Lista_ContratosEmpleados.Add(new ContratosEmpleados() {Id = 1, FechaCierre = new DateTime(2009, 11, 20), PrecioAcordado = 7000000, VendidaArrendada = "Arrendada"});
Lista_ContratosEmpleados.Add(new ContratosEmpleados() {Id = 1, FechaCierre = new DateTime(2005, 01, 21), PrecioAcordado = 105000000, VendidaArrendada = "Vendida"});
foreach (var ContratoEmpleado in Lista_ContratosEmpleados)
{
    System.Console.WriteLine(ContratoEmpleado.Id + " | " + ContratoEmpleado.FechaCierre + " | " + ContratoEmpleado.PrecioAcordado + " | " + ContratoEmpleado.VendidaArrendada);
}

System.Console.WriteLine("TIPOS DE CONTRATO: ");
var Lista_TiposContratos = new List<TiposContratos>();
Lista_TiposContratos.Add(new TiposContratos() {Id = 1, Nombre = "Fijo"});
Lista_TiposContratos.Add(new TiposContratos() {Id = 2, Nombre = "Indefinido"});
Lista_TiposContratos.Add(new TiposContratos() {Id = 3, Nombre = "Obra"});
Lista_TiposContratos.Add(new TiposContratos() {Id = 4, Nombre = "Ocasional"});
Lista_TiposContratos.Add(new TiposContratos() {Id = 5, Nombre = "Aprendizaje"});
foreach (var TipoContrato in Lista_TiposContratos)
{
    System.Console.WriteLine(TipoContrato.Id + " | " + TipoContrato.Nombre);
}

System.Console.WriteLine("CONTRATOS CODEUDORES:");
var Lista_ContratosCodeudores = new List<ContratosCodeudores>();
Lista_ContratosCodeudores.Add(new ContratosCodeudores(){Id = 1, FechaCierre = new DateTime(2026,03,01), PrecioAcordado = 200000000m, VendidaArrendada = "Vendida"});
Lista_ContratosCodeudores.Add(new ContratosCodeudores(){Id = 2, FechaCierre = new DateTime(2026,03,02), PrecioAcordado = 1500000m, VendidaArrendada = "Arrendada"});
Lista_ContratosCodeudores.Add(new ContratosCodeudores(){Id = 3, FechaCierre = new DateTime(2026,03,03), PrecioAcordado = 320000000m, VendidaArrendada = "Vendida"});
Lista_ContratosCodeudores.Add(new ContratosCodeudores(){Id = 4, FechaCierre = new DateTime(2026,03,04), PrecioAcordado = 1700000m, VendidaArrendada = "Arrendada"});
Lista_ContratosCodeudores.Add(new ContratosCodeudores(){Id = 5, FechaCierre = new DateTime(2026,03,05), PrecioAcordado = 280000000m, VendidaArrendada = "Vendida"});

foreach (var contrato in Lista_ContratosCodeudores)
{
    System.Console.WriteLine(contrato.Id + " | " + contrato.FechaCierre.ToShortDateString() + " | " + contrato.PrecioAcordado + " | " + contrato.VendidaArrendada);
}

System.Console.WriteLine("CODEUDORES COMPRADORES:");
var Lista_CodeudoresCompradores = new List<CodeudoresCompradores>();
Lista_CodeudoresCompradores.Add(new CodeudoresCompradores(){Id = 1, FechaUnion = new DateTime(2026,03,01), Relacion = "Familiar"});
Lista_CodeudoresCompradores.Add(new CodeudoresCompradores(){Id = 2, FechaUnion = new DateTime(2026,03,02), Relacion = "Amigo"});
Lista_CodeudoresCompradores.Add(new CodeudoresCompradores(){Id = 3, FechaUnion = new DateTime(2026,03,03), Relacion = "Socio"});
Lista_CodeudoresCompradores.Add(new CodeudoresCompradores(){Id = 4, FechaUnion = new DateTime(2026,03,04), Relacion = "Hermano"});
Lista_CodeudoresCompradores.Add(new CodeudoresCompradores(){Id = 5, FechaUnion = new DateTime(2026,03,05), Relacion = "Padre"});

foreach (var relacion in Lista_CodeudoresCompradores)
{
    System.Console.WriteLine(relacion.Id + " | " + relacion.FechaUnion.ToShortDateString() + " | " + relacion.Relacion);
}

public class EstadosCiviles
{
    public int Id {get;set;}
    public String? Nombre {get;set;}
    
    public List<Personas>? Personas {get;set;} 
}

public class Nacionalidades
{
    public int Id {get;set;}
    public String? Nombre {get;set;}
    
    public List<Personas>? Personas {get;set;} 
}

public class Personas
{
    public static int Contador = 0;
    public int Id {get;set;}
    public String? Cedula {get;set;}
    public String? Nombre {get;set;}
    public String? Apellido {get;set;}
    public char Genero {get;set;}
    public String? Correo {get;set;}
    public DateTime FechaNacimiento {get;set;}
    public DateTime FechaRegistro {get;set;}
    public int EstadoCivil {get;set;} 
    public int Nacionalidad {get;set;}

    public EstadosCiviles? _EstadoCivil {get;set;}
    public Nacionalidades? _Nacionalidad {get;set;}
    public List<Telefonos>? Telefonos {get;set;}
    public List<Direcciones>? Direcciones {get;set;}
    public List<ExpedientesFinancieros>? ExpedientesFinancieros {get;set;}
    public List<ExpedientesLaborales>? ExpedientesLaborales {get;set;}

    public Personas ()
    {
        Id = Contador++;
    }

    public int TiempoRegistrado ()
    {
        int Tiempo = DateTime.Now.Year - FechaRegistro.Year;
        return Tiempo;
    }
}

public class ExpedientesLaborales
{
    public int Id {get;set;}
    public String? NombreEmpresa {get;set;}
    public String? Cargo {get;set;}
    public decimal SalarioPagado {get;set;}
    public DateTime FechaIngreso {get;set;}
    public DateTime FechaEgreso {get;set;}
    public String? Desempeño {get;set;}
    public String? MotivoSalida {get;set;}
    public int Persona {get;set;}

    public Personas? _Persona {get;set;}
}

public class Telefonos
{
    public int Id {get;set;}
    public String? Numero {get;set;}
    public String? Prefijo {get;set;}
    public int Persona {get;set;}

    public Personas? _Persona {get;set;}
}

public class Direcciones
{
    public int Id {get;set;}
    public String? TipoVia {get;set;}
    public String? Numero {get;set;}
    public String? Complemento {get;set;}
    public int Persona {get;set;}

    public Personas? _Persona {get;set;}
}

public class ExpedientesFinancieros
{
    public int Id {get;set;}
    public int Persona {get;set;}

    public Personas? _Persona {get;set;}
    public List<Bienes>? Bienes {get;set;}
    public List<ActivosFinancieros>? ActivosFinancieros {get;set;}

    public decimal CalcularPrecioBienes ()
    {
        decimal suma = 0;
        if (Bienes != null) {
            foreach (var Bien in Bienes)
            {
                suma += Bien.ValorActual;    
            }
            return suma;
        }
        return suma;
    }
}

public class Bienes
{
    public int Id {get;set;}
    public String? Nombre {get;set;}
    public String? Descripcion {get;set;}
    public DateTime FechaAdquisicion {get;set;}
    public decimal PrecioCompra {get;set;}
    public decimal ValorActual {get;set;}
    public int ExpedientesFinancieros {get;set;}
    

    public ExpedientesFinancieros? ExpedienteFinanciero {get;set;}
}

public class BienesMuebles : Bienes
{
    public String? Tipo {get;set;}
    public String? Modelo {get;set;}
    public String? UbicacionActual {get;set;}
    public String? Garantia {get;set;}
    public String? Estado {get;set;}
}

public class BienesInmuebles : Bienes
{
    public decimal MetrosCuadrados {get;set;}
    public String? Direccion {get;set;}
    public String? EstadoConservacion {get;set;}
    public String? Estrato {get;set;}
    public String? NumeroHabitaciones {get;set;}
    public String? NumeroBaños {get;set;}
    public String? CodigoCUC {get;set;}
    public String? EncargosDeudas {get;set;}
}

public class ActivosFinancieros
{
    public int Id {get;set;}
    public String? Nombre {get;set;}
    public String? Descripcion {get;set;}
    public DateTime FechaAdquisicion {get;set;}
    public decimal Precio {get;set;}
    public int ExpedienteFinanciero {get;set;}
    public ExpedientesFinancieros? _ExpedientesFinancieros {get;set;}
}

public class Trabajadores : Personas
{
    public decimal Sueldo {get;set;}
    public Boolean Estado {get;set;}
    public String? Jornada {get;set;}
}

public class AdministradoresDepartamentos : Trabajadores
{
    public decimal PresupuestoDepartamento {get;set;}
    public int Departamento {get;set;}

    public Departamentos? _Departamentos {get;set;}
    public List<JefesSectores>? jefesSectores {get;set;}
}

public class JefesSectores : Trabajadores
{
    public decimal PresupuestoSector {get;set;}
    public int AdministradorDepartamento {get;set;}
    public int Sector {get;set;}

    public Sectores? _Sectores {get;set;}
    public AdministradoresDepartamentos? _AdministradorDepartamento {get;set;}
    public List<EmpleadosSectores>? EmpleadosSectores {get;set;}
    public List<Contratos>? Contratos {get;set;}
}

public class TiposContratos
{
    public int Id {get;set;}
    public String? Nombre {get;set;}

    public List<EmpleadosSectores>? EmpleadosSectores {get;set;}    
}

public class EmpleadosSectores : Trabajadores
{
    public int JefesSectores {get;set;}
    public int TipoContrato {get;set;}
    public int Sector {get;set;}

    public Sectores? _Sectores {get;set;}
    public TiposContratos? _TipoContrato {get;set;}
    public JefesSectores? _JefeSector {get;set;}
    public List<EmpleadosCompradores>? EmpleadosCompradores {get;set;}
    public List<ContratosEmpleados>? ContratosEmpleados {get;set;}

    public decimal CalcularSalario ()
    {
        if (_TipoContrato?.Nombre == "Fijo" || _TipoContrato?.Nombre == "Indefinido") 
            return 2550000.0m;
        else if (_TipoContrato?.Nombre == "Obra" || _TipoContrato?.Nombre == "Ocasional")
            return 1900000.0m;
        else if (_TipoContrato?.Nombre == "Aprendizaje")
            return 1500000.0m;
        else 
            return 0m;
    }
}

public class Ciudades
{
    public int Id {get;set;}
    public String? Nombre {get;set;}
    public Boolean Estado {get;set;}
    public String? Poblacion {get;set;}
    public DateTime FechaCreacion {get;set;}
    public int CodigoPostal {get;set;}
    public int Departamento {get;set;}

    public Departamentos? _Departamento {get;set;}
    public List<Sectores>? Sectores {get;set;}
}

public class Departamentos
{
    public int Id {get;set;}
    public String? Nombre {get;set;}
    public Boolean Estado {get;set;}
    public DateTime FechaCreacion {get;set;}
    public String? Poblacion {get;set;}
    public int Administrador {get;set;}

    public AdministradoresDepartamentos? _AdministradorDepatamento {get;set;}
    public List<Ciudades>? Ciudades {get;set;}
}

public class Sectores
{
    public int Id {get;set;}
    public String? Nombre {get;set;}
    public Boolean Estado {get;set;}
    public DateTime FechaCreacion {get;set;}
    public int Ciudad {get;set;}
    public int JefeSector {get;set;}

    public Ciudades? _Ciudad {get;set;}
    public JefesSectores? _JefeSector {get;set;}
    public List<EmpleadosSectores>? EmpleadosSectores {get;set;}
}

public class Codeudores : Personas
{
    public int Comprador {get;set;}

    public Compradores? _Compradores {get;set;}
    public List<Contratos>? Contratos {get;set;}
    public List<ContratosCodeudores>? ContratosCodeudores {get;set;}
}

public class EmpleadosCompradores
{
    public int Id {get;set;}
    public DateTime FechaAsesoramiento {get;set;}
    public int Comprador {get;set;}
    public int Empleado {get;set;}

    public Compradores? _Comprador {get;set;}
    public EmpleadosSectores? EmpleadoSector {get;set;}
}

public class Compradores : Personas
{
    public List<Contratos>? Contratos {get;set;}
    public List<Codeudores>? Codeudores {get;set;}    
    public List<EmpleadosCompradores>? EmpleadosCompradores {get;set;}
}

public class TiposPropiedades
{
    public int Id {get;set;}
    public String? Nombre {get;set;}
    List<Propiedades>? Propiedades {get;set;}
}

public class Clientes : Personas
{
    public decimal PorcentajeComision {get;set;}
    public int CantidadContratos {get;set;}
    public String? PrioridadCliente {get;set;}
    public String? MotivoVenta {get;set;}
}
public class Propiedades
{ 
    public int Id {get;set;}
    public int NumeroHabitaciones {get;set;}
    public int NumeroBaños {get;set;}
    public Boolean Patio {get;set;}
    public int Entradas {get;set;}
    public int Pisos {get;set;}
    public DateTime AñoConstruccion {get;set;}
    public decimal ValorPropiedad {get;set;}
    public decimal ValorArriendo {get;set;}
    public String? Estado {get;set;}
    public int Cliente {get;set;}
    public int TipoPropiedad {get;set;}

    public Clientes? _Clientes {get;set;}
    public TiposPropiedades? _TipoPropiedad {get;set;}
    public List<Contratos>? Contratos {get;set;}
}

public class Contratos
{
    public int Id {get;set;}
    public DateTime FechaContrato {get;set;}
    public DateTime? FechaFinalizacion {get;set;}
    public String?  Obsevaciones {get;set;}
    public decimal PrecioAcordado {get;set;}
    public String? ArriendoVenta {get;set;}
    public int Clientes {get;set;}
    public int Propiedad {get;set;}
    public int Comprador {get;set;}
    public int Codeudores {get;set;}
    public int JefeSector {get;set;}

    public JefesSectores? _JefeSector {get;set;}
    public Clientes? _Cliente {get;set;}
    public Propiedades? _Propiedad {get;set;}
    public Compradores? _Comprador {get;set;}
    public Codeudores? _Codeudores {get;set;}
    public List<ContratosEmpleados>? ContratosEmpleados {get;set;}
    public List<ContratosCodeudores>? ContratosCodeudores {get;set;}
}

public class ContratosEmpleados
{
    public int Id {get;set;}
    public DateTime FechaCierre {get;set;}
    public decimal PrecioAcordado {get;set;}
    public String? VendidaArrendada {get;set;}
    public int Empleado {get;set;}
    public int Contrato {get;set;}

    public EmpleadosSectores? _EmpleadoSector {get;set;}
    public Contratos? _Contrato {get;set;}
}

public class ContratosCodeudores
{
    public int Id {get;set;}
    public DateTime FechaCierre {get;set;}
    public decimal PrecioAcordado {get;set;}
    public String? VendidaArrendada {get;set;}
    public int Codeudor {get;set;}
    public int Contrato {get;set;}

    public Codeudores? _Codeudores {get;set;}
    public Contratos? _Contratos {get;set;}
}

public class CodeudoresCompradores
{
    public int Id {get;set;}
    public DateTime FechaUnion {get;set;}
    public String? Relacion {get;set;}
    public int Comprador {get;set;}
    public int Codeudor {get;set;}

    public Compradores? _Compradores {get;set;}
    public Codeudores? _Codeudores {get;set;}
}