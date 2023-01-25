﻿namespace HoopShoot.Models
{
    public class EntityBase
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public DateTime? DeletedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
