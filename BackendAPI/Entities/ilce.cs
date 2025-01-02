﻿using System.Collections.Generic;

namespace BackendAPI.Entities
{
    public class Ilce
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int IlId { get; set; }

        public Il Il { get; set; }
        public ICollection<Mahalle> Mahalleler { get; set; }
    }
}
