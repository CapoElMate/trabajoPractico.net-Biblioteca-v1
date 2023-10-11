namespace Biblioteca.Aplicacion;

public class Docente : Persona{

    public int numeroMatricula{get;set;}
    

    public Docente( int nroMatricula, int añoInicio,
    int id , int numeroCarnet, string nombre, string apellido, string direccion, string facultad, int telefono, string correoElectronico)     
    :base( numeroCarnet, nombre, apellido, direccion, facultad, telefono, correoElectronico){
        
        this.numeroMatricula=nroMatricula;
        this.añoInicioDocencia = añoInicio;

    }
    
    private int _añoInicioDocencia; 
    public int añoInicioDocencia{
        get => _añoInicioDocencia;
        
        // en caso que de que no este entre los años 1900 y el actual, guarda -1
        protected set => _añoInicioDocencia =   (value <= DateTime.Now.Year) && 
                                                (value > 1900) 
                                                ? value 
                                                :throw new ArgumentException("el año de inicio no esta entre 1900 y el actual.");
    }

    public override string ToString()
    {
        return  $"{base.ToString()},{numeroMatricula},{añoInicioDocencia}";
    }

}