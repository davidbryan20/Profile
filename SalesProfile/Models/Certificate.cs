namespace SalesProfile.Models
{
    public class Certificate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Institution { get; set; }
        public DateTime CompletionDate { get; set; }
        public string CertificateUrl { get; set; }
    }
}
