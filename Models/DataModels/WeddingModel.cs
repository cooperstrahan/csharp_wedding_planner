using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId { get; set; }
        public string WedderOne { get; set; }
        public string WedderTwo { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public int CreatorId { get; set; }
        public List<Plans> Attendees { get; set; }
        public Wedding() {}

        public Wedding(AddWedding wedding)
        {
            WedderOne = wedding.wedOne;
            WedderTwo = wedding.wedTwo;
            Date = wedding.wedDate;
            Address = wedding.wedAddress;
            CreatorId = wedding.wedCreatorId;
            Attendees = wedding.attendees;
        }
    }
}