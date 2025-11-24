namespace Sys_Dates.Models.Modules
{
    public class Dates
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }   // Fecha y hora de inicio
        public DateTime? EndDate { get; set; }    // Fecha y hora de fin (puede ser nula)
        public bool AllDay { get; set; }          // Indica si es un evento de día completo
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }          // Cita, reunión, tarea, evento, etc.
        public string Category { get; set; }      // Trabajo, personal, salud, etc.
        public string Priority { get; set; }      // Baja, media, alta
        public string Status { get; set; }        // Pendiente, completado, cancelado
        public string Location { get; set; }      // Dirección o lugar
        public string Url { get; set; }           // Enlace a videollamada o sitio externo
        public bool ReminderSent { get; set; }
        public DateTime CreatedAt { get; set; }   // Fecha de creación
    }
}
