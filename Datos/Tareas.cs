using System;

public class Tareas
{
	List<TareaModel> Lista = new List<TareaModel>();
	/// <summary>
	/// Guarda los datos
	/// </summary>
	/// <param name="tarea">datos de las tareas</param>
	public void GuardarTarea(TareaModel tarea) {  
		Lista.Add(tarea);
	}

    /// <summary>
    /// Consulta los datos guardados
    /// </summary>
    /// <returns>datos de tareas</returns>

    public List<TareaModel> CargarDatos()
	{
		return Lista;
    }
		
}
