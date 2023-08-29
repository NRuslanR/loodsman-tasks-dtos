namespace UMP.Loodsman.Dtos.SUPR
{
    public class UserDto
    {
        public long Id { get; set; }

        public string Name { get; set; } 

        public string FullName { get; set; } 

        public string Email { get; set; } 

        public long Index { get; set; }

        public long Status { get; set; }

        public bool Trusted { get; set; }
    }
}
