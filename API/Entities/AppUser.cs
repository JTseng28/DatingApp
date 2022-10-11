namespace API.Entities
{
    public class AppUser //This is an entity in ET
    {
        public int Id { get; set; }
        public string UserName { get; set; }

    }
}

/*Entity Framework
Object relational mapper (ORM)
 Translate code to SQL commands that update our tables in the database
Uses linq to query
schema = model
*/