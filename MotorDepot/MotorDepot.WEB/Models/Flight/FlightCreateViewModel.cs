﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MotorDepot.WEB.Models.Flight
{
    public class FlightCreateViewModel
    {
        [Required, StringLength(30, MinimumLength = 2)]
        public string DeparturePlace { get; set; }

        [Required, StringLength(30, MinimumLength = 2)]
        public string ArrivalPlace { get; set; }

        [DataType(DataType.MultilineText), StringLength(256)]
        public string Description { get; set; }

        [Required, Range(10, 5000)]
        public double Distance { get; set; }
        public DateTime CreateDate { get; set; }
        public string DispatcherCreatorId { get; set; }
    }
}