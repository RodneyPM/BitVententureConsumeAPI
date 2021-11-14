using System;
using System.Collections.Generic;
using System.Text;

namespace ConsumeEndPoints.Dtos
{
   public class EndPointsDTO
    {
        public bool Enabled { get; set; }
        public string Resource { get; set; }
        public string RequestBody { get; set; }
        public ResponseDTO[] Response { get; set; }
    }

}
