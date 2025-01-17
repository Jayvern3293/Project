namespace Project.Domain
{
	public class Pet
	{
		public int PetId { get; set; }
		public string? Name { get; set; }
		public int Age { get; set; }
        public string? Gender { get; set; }
        public string? Species { get; set; }
		public string? Colour { get; set; }
		public int OrganizationId { get; set; }
	}
}
