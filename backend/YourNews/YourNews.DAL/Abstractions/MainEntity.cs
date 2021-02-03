using System;


namespace YourNews.DAL.Abstractions
{
     public abstract class MainEntity
     {
            public int Id { get; set; }
            public DateTime CreatingDate { get; set; }
     }
}
