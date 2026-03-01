public class EstadosCiviles
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
    public char Genero {get;set;}
    public String? Correo {get;set;}
    public String? Codigo {get;set;}
    public String? Nacionalidad {get;set;}
    public DateTime FechaNacimiento {get;set;}
    public DateTime FechaRegistro {get;set;}
    public int EstadoCivil {get;set;} 

    public EstadosCiviles? _EstadoCivil {get;set;}
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