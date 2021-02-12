using Microsoft.AspNetCore.Identity;

namespace DotNet_Core_Identity
{
    public class PluralsightUser : IdentityUser
    {
        public string Locale { get; set; } = "en-GB";

        public string OrdId { get; set; }
    }

    public class Organizaion
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
