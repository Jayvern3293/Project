namespace Project.Domain
{
	public class Donation
	{
		public int DonationId { get; set; }
		public DateTime Date { get; set; }
		public int Amount { get; set; }
		public int UserId { get; set; }
	}
}
