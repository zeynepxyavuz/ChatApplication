namespace ChatApp.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<GroupMessage> Messages { get; set; }
    }
}
