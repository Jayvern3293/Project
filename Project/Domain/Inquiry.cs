namespace Project.Domain
{
	public class Inquiry
	{
		public int InquiryId { get; set; }
		public string? Question {  get; set; }
		public DateTime Date { get; set; }
		public int UserId { get; set; }

	}
}
