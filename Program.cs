System.Console.WriteLine("ESTADOS CIVILES EN COLOMBIA: " + "\n");
var Lista_EstadosCiviles = new List<EstadosCiviles>();
Lista_EstadosCiviles.Add( new EstadosCiviles() {Id = 1, Nombre = "Soltero"});
Lista_EstadosCiviles.Add( new EstadosCiviles() {Id = 2, Nombre = "Casado"});
Lista_EstadosCiviles.Add( new EstadosCiviles() {Id = 3, Nombre = "Divorciado"});
Lista_EstadosCiviles.Add( new EstadosCiviles() {Id = 4, Nombre = "Viudo"});
Lista_EstadosCiviles.Add( new EstadosCiviles() {Id = 5, Nombre = "Union Libre"});
foreach (var Estados in Lista_EstadosCiviles)
{
    System.Console.WriteLine($"{Estados.Nombre}" + " | ");
}

System.Console.WriteLine("LISTA NACIONALIDADES: " + "\n");
var Lista_Nacionalidades = new List<Nacionalidades>();
Lista_Nacionalidades.Add(new Nacionalidades() {Id = 1, Nombre = "Colombiana"});
Lista_Nacionalidades.Add(new Nacionalidades() {Id = 1, Nombre = "Argentina"});
Lista_Nacionalidades.Add(new Nacionalidades() {Id = 1, Nombre = "Chilena"});
Lista_Nacionalidades.Add(new Nacionalidades() {Id = 1, Nombre = "Española"});
Lista_Nacionalidades.Add(new Nacionalidades() {Id = 1, Nombre = "Africana"});
foreach (var Nacionalidades in Lista_Nacionalidades)
{
    System.Console.WriteLine($"Nacionalidad: {Nacionalidades.Nombre} " + "| ");
}

System.Console.WriteLine("LISTA DE ADMINISTRADORES: " + "\n");
var Lista_AdministradoresCiudades = new List<AdministradoresCiudades>();
Lista_AdministradoresCiudades.Add(new AdministradoresCiudades() {Id = 1, Cedula = "132443242", Nombre = "Luis Alberto", Apellido = "Arango Martinez", Genero = 'M', Correo = "Luisalberto@Gmail.com", FechaNacimiento = new DateTime(2002,08,19), FechaRegistro = DateTime.Now, Presupuesto = 32500000.0m});
Lista_AdministradoresCiudades.Add(new AdministradoresCiudades() {Id = 2, Cedula = "214312341", Nombre = "Gilma Rosa", Apellido = "Garcia Meneses", Genero = 'F', Correo = "GilmaRosa@Gmail.com", FechaNacimiento = new DateTime(2000,02,10), FechaRegistro = DateTime.Now, Presupuesto = 33500000.0m});
Lista_AdministradoresCiudades.Add(new AdministradoresCiudades() {Id = 3, Cedula = "512341234", Nombre = "Luis Miguel", Apellido = "Arango Garcia", Genero = 'M', Correo = "LuisMiguel@Gmail.com", FechaNacimiento = new DateTime(2004,03,11), FechaRegistro = DateTime.Now, Presupuesto = 34500000.0m});
Lista_AdministradoresCiudades.Add(new AdministradoresCiudades() {Id = 4, Cedula = "124312433", Nombre = "Maria Camila", Apellido = "Arango Martinez", Genero = 'F', Correo = "MariaCamila@Gmail.com", FechaNacimiento = new DateTime(2003,11,11), FechaRegistro = DateTime.Now, Presupuesto = 355500000.0m});
Lista_AdministradoresCiudades.Add(new AdministradoresCiudades() {Id = 5, Cedula = "523412123", Nombre = "Valentina Sofia", Apellido = "Martinez Ocampo", Genero = 'F', Correo = "ValentinaSofia@Gmail.com", FechaNacimiento = new DateTime(2005,02,12), FechaRegistro = DateTime.Now, Presupuesto = 32500000.0m});
foreach (var Admins in Lista_AdministradoresCiudades)
{
    System.Console.WriteLine(Admins.Id + " | " + Admins.Cedula + " | " + Admins.Nombre + " | "  + Admins.Apellido + " | " + Admins.Genero + " | " + Admins.Correo + " | " + Admins.FechaNacimiento + " | " + Admins.FechaRegistro + " | " + Admins.Presupuesto);
}

System.Console.WriteLine("JEFES DE SECTORES: " + "\n");
var Lista_JefesSectores = new List<JefesSectores>();
Lista_JefesSectores.Add(new JefesSectores() {Id = 6, Cedula = "901234567", Nombre = "Ricardo", Apellido = "Montoya Perez", Genero = 'M', Correo = "Ricardo@gmail.com", FechaNacimiento = new DateTime(1985,03,12), FechaRegistro = DateTime.Now, PresupuestoSector = 4500000.0m});
Lista_JefesSectores.Add(new JefesSectores() {Id = 7, Cedula = "902345678", Nombre = "Patricia", Apellido = "Gomez Herrera", Genero = 'F', Correo = "Patricia@gmail.com", FechaNacimiento = new DateTime(1988,07,25), FechaRegistro = DateTime.Now, PresupuestoSector = 3500000.0m});
Lista_JefesSectores.Add(new JefesSectores() {Id = 8, Cedula = "903456789", Nombre = "Fernando", Apellido = "Rios Salgado", Genero = 'M', Correo = "Fernando@gmail.com", FechaNacimiento = new DateTime(1982,11,08), FechaRegistro = DateTime.Now, PresupuestoSector = 2500000.0m});
Lista_JefesSectores.Add(new JefesSectores() {Id = 9, Cedula = "904567890", Nombre = "Claudia", Apellido = "Martinez León", Genero = 'F', Correo = "Claudia@gmail.com", FechaNacimiento = new DateTime(1990,01,17), FechaRegistro = DateTime.Now, PresupuestoSector = 1500000.0m});
Lista_JefesSectores.Add(new JefesSectores() {Id = 10, Cedula = "905678901", Nombre = "Hector", Apellido = "Suarez Medina", Genero = 'M', Correo = "Hector@gmail.com", FechaNacimiento = new DateTime(1987,09,03), FechaRegistro = DateTime.Now, PresupuestoSector = 4500000.0m});
foreach (var Jefes in Lista_JefesSectores)
{
    System.Console.WriteLine(Jefes.Id + " | " + Jefes.Cedula + " | " + Jefes.Nombre + " | "  + Jefes.Apellido + " | " + Jefes.Genero + " | " + Jefes.Correo + " | " + Jefes.FechaNacimiento + " | " + Jefes.FechaRegistro + " | " + Jefes.PresupuestoSector);    
}

System.Console.WriteLine("EMPLEADOS DE SECTORES: " + "\n");
var Lista_EmpleadosSectores = new List<EmpleadosSectores>();
Lista_EmpleadosSectores.Add(new EmpleadosSectores() {Id = 11, Cedula = "801234567", Nombre = "Natalia", Apellido = "Castillo Ramos", Genero = 'F', Correo = "Natalia@gmail.com", FechaNacimiento = new DateTime(1999,04,10), FechaRegistro = DateTime.Now});
Lista_EmpleadosSectores.Add(new EmpleadosSectores() {Id = 12, Cedula = "802345678", Nombre = "Juan Diego", Apellido = "Lopez Vargas", Genero = 'M', Correo = "Juandiego@gmail.com", FechaNacimiento = new DateTime(2000,06,21), FechaRegistro = DateTime.Now});
Lista_EmpleadosSectores.Add(new EmpleadosSectores() {Id = 13, Cedula = "803456789", Nombre = "Sofia", Apellido = "Ramirez Castro", Genero = 'F', Correo = "Sofia@gmail.com", FechaNacimiento = new DateTime(1998,12,14), FechaRegistro = DateTime.Now});
Lista_EmpleadosSectores.Add(new EmpleadosSectores() {Id = 14, Cedula = "804567890", Nombre = "Miguel Angel", Apellido = "Torres Peña", Genero = 'M', Correo = "Miguel@gmail.com", FechaNacimiento = new DateTime(1997,02,28), FechaRegistro = DateTime.Now});
Lista_EmpleadosSectores.Add(new EmpleadosSectores() {Id = 15, Cedula = "805678901", Nombre = "Laura", Apellido = "Herrera Soto", Genero = 'F', Correo = "Laura@gmail.com", FechaNacimiento = new DateTime(2001,10,05), FechaRegistro = DateTime.Now});
foreach (var Empleados in Lista_EmpleadosSectores)
{
    System.Console.WriteLine(Empleados.Id + " | " + Empleados.Cedula + " | " + Empleados.Nombre + " | "  + Empleados.Apellido + " | " + Empleados.Genero + " | " + Empleados.Correo + " | " + Empleados.FechaNacimiento + " | " + Empleados.FechaRegistro + " | " + Empleados.TipoContrato);    
}

System.Console.WriteLine("EXPEDIENTES LABORALES: " + "\n");
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

public class BienMueble : Bienes
{
    public String? Tipo {get;set;}
    public String? Modelo {get;set;}
    public String? UbicacionActual {get;set;}
    public String? Garantia {get;set;}
    public String? Estado {get;set;}
}

public class BienInmueble : Bienes
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

public class AdministradoresCiudades : Trabajadores
{
    public decimal Presupuesto {get;set;}
    public int Ciudad {get;set;}

    public Ciudades? _Ciudad {get;set;}
    public List<JefesSectores>? jefesSectores {get;set;}
}

public class JefesSectores : Trabajadores
{
    public decimal PresupuestoSector {get;set;}
    public int AdministradorCiudad {get;set;}

    public AdministradoresCiudades? _AdministradorCiudad {get;set;}
    public List<EmpleadosSectores>? EmpleadosSectores {get;set;}
}

public class EmpleadosSectores : Trabajadores, IcalcularSalario
{
    public String? TipoContrato {get;set;}
    public int JefesSectores {get;set;}

    public JefesSectores? _JefeSector {get;set;}

    public decimal CalcularSalario ()
    {
        if (TipoContrato == "Fijo" || TipoContrato == "Indefinido") 
            return 1750000.0m;
        else if (TipoContrato == "Obra" || TipoContrato == "Labor")
            return 1900000.0m;
        else if (TipoContrato == "Aprendizaje")
            return 1500000.0m;
        else 
            return 0m;
    }
}

public interface IcalcularSalario
{
    decimal CalcularSalario ();
}

public class Ciudades
{
    public int Id {get;set;}
    public String? Nombre {get;set;}
    public Boolean Estado {get;set;}
    public String? Poblacion {get;set;}
    public DateTime FechaCreacion {get;set;}
    public int CodigoPostal {get;set;}
    public int AdministradorCiudad {get;set;}

    public AdministradoresCiudades? _AdministradorCiudad {get;set;}
    public List<Departamentos>? Departamentos {get;set;}
}

public class Departamentos
{
    public int Id {get;set;}
    public String? Nombre {get;set;}
    public Boolean Estado {get;set;}
    public DateTime FechaCreacion {get;set;}
    public String? Poblacion {get;set;}
    public int Ciudad {get;set;}

    public Ciudades? _Ciudades {get;set;}
    public List<Sectores>? Sectores {get;set;}
}

public class Sectores
{
    public int Id {get;set;}
    public String? Nombre {get;set;}
    public Boolean Estado {get;set;}
    public DateTime FechaCreacion {get;set;}
    public int Departamento {get;set;}

    public Departamentos? _Departamento {get;set;}
}