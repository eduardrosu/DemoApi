namespace Domain //this is an entity
{
    public class Activity //this is the name and the table in the db
    {
        //these are the columns of the table
        public Guid Id { get; set; } 
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }
    }
}