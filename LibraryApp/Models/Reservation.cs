using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryApp.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

        [Required]
        public DateTime ReservationDate { get; set; }
    }
}
