namespace Project.Domain
{
	public class Appointment
	{
		public int AppointmentId { get; set; }
		public DateTime Date { get; set; }
		public int UserId { get; set; }
		public int PetId { get; set; }
	}
}
