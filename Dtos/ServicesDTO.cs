using System;
using System.Collections.Generic;
using System.Text;

namespace ConsumeEndPoints.Dtos
{
   public class ServicesDTO
    {
        public string BaseURL { get; set; }
        public bool Enabled { get; set; }
        public string Datatype { get; set; }
        public EndPointsDTO[] Endpoints { get; set; }
        public IdentifiersDTO[] Identifiers { get; set; }
    }
}
