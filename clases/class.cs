using System;

public class Vino
{
    // Atributos
    private string añada;
    private DateTime fechaActualizacion;
    private string imagenEtiqueta;
    private string nombre;
    private string notaDECataBodega;
    private decimal precioArs;

    // Métodos
    public void buscarInfoBodega()
    {
        // Código del método buscarInfoBodega
    }

    public void buscarVarietal()
    {
        // Código del método buscarVarietal
    }

    public void calcularPuntajeDeSommelierEnPeriodo()
    {
        // Código del método calcularPuntajeDeSommelierEnPeriodo
    }

    public void calcularPuntajePromedio()
    {
        // Código del método calcularPuntajePromedio
    }

    public void calcularRanking()
    {
        // Código del método calcularRanking
    }

    public void compararEtiqueta()
    {
        // Código del método compararEtiqueta
    }

    public void crearVarietal()
    {
        // Código del método crearVarietal
    }

    public bool esDeBodega()
    {
        // Código del método esDeBodega
        return false;
    }

    public bool esDeRegionVitivinicola()
    {
        // Código del método esDeRegionVitivinicola
        return false;
    }

    public string getNombre()
    {
        // Código del método getNombre
        return nombre;
    }

    public decimal getPrecio()
    {
        // Código del método getPrecio
        return precioArs;
    }

    public Vino()
    {
        // Código del constructor Vino
    }

    public void setImagenEtiqueta(string imagen)
    {
        // Código del método setImagenEtiqueta
    }

    public void setNotaCata(string nota)
    {
        // Código del método setNotaCata
    }

    public void setPrecio(decimal precio)
    {
        // Código del método setPrecio
    }

    public bool sosVinoParaActualizar()
    {
        // Código del método sosVinoParaActualizar
        return false;
    }

    public bool tenesResenasDeTipoEnPeriodo()
    {
        // Código del método tenesResenasDeTipoEnPeriodo
        return false;
    }
}

public class Varietal
{
    // Atributos
    private string descripcion;
    private decimal PorcentajeComposicion;

    // Métodos
    public void conocerTipoUva()
    {
        // Código del método conocerTipoUva
    }

    public bool esDeTipoUva()
    {
        // Código del método esDeTipoUva
        return false;
    }

    public string getDescripcion()
    {
        // Código del método getDescripcion
        return descripcion;
    }

    public void mostrarPorcentaje()
    {
        // Código del método mostrarPorcentaje
    }

    public Varietal()
    {
        // Código del constructor Varietal
    }
}

public class GestorRankingVinos
{
    // Atributos
    private DateTime fechaDesde;
    private DateTime fechaHasta;
    private string tipoRankingSeleccionado;
    private string vinosOrdenados;
    private string vinosQueCumplenFiltros;

    // Métodos
    public void buscarVinosConResenasEnPeriodo()
    {
        // Código del método buscarVinosConResenasEnPeriodo
    }

    public void calcularPuntajeDeSommelierEnPeriodo()
    {
        // Código del método calcularPuntajeDeSommelierEnPeriodo
    }

    public void finCU()
    {
        // Código del método finCU
    }

    public void opcionGenerarRankingVinos()
    {
        // Código del método opcionGenerarRankingVinos
    }

    public void ordenarVinos()
    {
        // Código del método ordenarVinos
    }

    public void tomarConfirmacionGenReporte()
    {
        // Código del método tomarConfirmacionGenReporte
    }

    public void tomarSelFechaDesdeYHasta()
    {
        // Código del método tomarSelFechaDesdeYHasta
    }

    public void tomarSelTipoResena()
    {
        // Código del método tomarSelTipoResena
    }

    public void tomarSelTipoVisualizacion()
    {
        // Código del método tomarSelTipoVisualizacion
    }

    public GestorRankingVinos()
    {
        // Código del constructor GestorRankingVinos
    }
}

public interface InterfazExcel
{
    // Método
    void exportarExcel();
}

public class Reseña
{
    // Atributos
    private string comentario;
    private bool esPremium;
    private DateTime fechaReseña;
    private int puntaje;

    // Métodos
    public bool esPermium()
    {
        // Código del método esPermium
        return false;
    }

    public int getPuntaje()
    {
        // Código del método getPuntaje
        return puntaje;
    }

    public bool sosDeEnofilo()
    {
        // Código del método sosDeEnofilo
        return false;
    }

    public bool sosDePeriodo()
    {
        // Código del método sosDePeriodo
        return false;
    }

    public bool sosDeSommelier()
    {
        // Código del método sosDeSommelier
        return false;
    }
}

public class PantallaRankingVinos
{
    // Atributos
    private string lblFechaDesde;
    private string lblFechaHasta;
    private string txtFechaDesde;
    private string txtFechaHasta;
    private bool confirmarExportacion;

    // Métodos
    public void habilitarPantalla()
    {
        // Código del método habilitarPantalla
    }

    public void opcionGenerarRankingVinos()
    {
        // Código del método opcionGenerarRankingVinos
    }

    public void solicitarConfirmationGenReporte()
    {
        // Código del método solicitarConfirmationGenReporte
    }

    public void solicitarSelFechaDesdeYHasta()
    {
        // Código del método solicitarSelFechaDesdeYHasta
    }

    public void solicitarSelTipoResena()
    {
        // Código del método solicitarSelTipoResena
    }

    public void solicitarSelTipoVisualizacion()
    {
        // Código del método solicitarSelTipoVisualizacion
    }

    public void tomarConfirmacionGenReporte()
    {
        // Código del método tomarConfirmacionGenReporte
    }

    public void tomarSelFechaDesdeYHasta()
    {
        // Código del método tomarSelFechaDesdeYHasta
    }

    public void tomarTipoResena()
    {
        // Código del método tomarTipoResena
    }

    public void tomarTipoVisualizacion()
    {
        // Código del método tomarTipoVisualizacion
    }

    public void validarPeriodo()
    {
        // Código del método validarPeriodo
    }
}



public class Bodega
{
    // Atributos
    private double[] coordenadasUbicacion;
    private string descripcion;
    private DateTime fechaUltimaActualizacion;
    private string historia;
    private string nombre;
    private string periodoActualizacion;

    // Métodos
    public void actualizarDatosVino()
    {
        // Código del método actualizarDatosVino
    }

    public int contarReseñas()
    {
        // Código del método contarReseñas
        return 0;
    }

    public void crearNuevosVinos()
    {
        // Código del método crearNuevosVinos
    }

    public bool estaParaActualizarNovedadesVino()
    {
        // Código del método estaParaActualizarNovedadesVino
        return false;
    }

    public string getNombre()
    {
        // Código del método getNombre
        return nombre;
    }

    public void mostrarTodosVinos()
    {
        // Código del método mostrarTodosVinos
    }

    public string obtenerRegionYPais()
    {
        // Código del método obtenerRegionYPais
        return string.Empty;
    }
}

public class RegionVitivinicola
{
    // Atributos
    private string descripcion;
    private string nombre;

    // Métodos
    public int contarBodegas()
    {
        // Código del método contarBodegas
        return 0;
    }

    public string getNombre()
    {
        // Código del método getNombre
        return nombre;
    }

    public string obtenerPais()
    {
        // Código del método obtenerPais
        return string.Empty;
    }
}

public class Provincia
{
    // Atributos
    private string nombre;

    // Métodos
    public int contarRegiones()
    {
        // Código del método contarRegiones
        return 0;
    }

    public void mostrarRegiones()
    {
        // Código del método mostrarRegiones
    }

    public string obtenerPais()
    {
        // Código del método obtenerPais
        return string.Empty;
    }
}

public class Pais
{
    // Atributos
    private string nombre;

    // Métodos
    public int contarBodegas()
    {
        // Código del método contarBodegas
        return 0;
    }

    public string getNombre()
    {
        // Código del método getNombre
        return nombre;
    }
}
