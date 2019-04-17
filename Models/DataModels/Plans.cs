using System;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class Plans
    {
        [Key]
        public int PlansId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int WeddingId { get; set; }
        public Wedding Wedding { get; set; }
        public Plans() {}

        public Plans(int user, int wed)
        {
            UserId = user;
            WeddingId = wed;
        }
    }

}