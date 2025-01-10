namespace Project.Domain
{
	public class AdoptionHistory
	{
		public int AdoptionHistoryId {  get; set; }
		public DateTime Date { get; set; }
		public int UserId { get; set; }
		public int PetId { get; set; }
	}
}
