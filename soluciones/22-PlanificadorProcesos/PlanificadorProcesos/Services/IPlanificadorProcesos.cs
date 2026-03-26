using PlanificadorProcesos.Models;

namespace PlanificadorProcesos.Services;

/// <summary>
///     Interfaz especializada para planificación de procesos.
/// </summary>
public interface IPlanificadorProcesos : IPlanificador<int, Proceso> { }