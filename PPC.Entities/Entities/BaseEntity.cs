using System;
using System.Collections.Generic;
using System.Text;

namespace PPC.Entities.Entities
{
    public class BaseEntity
    {
        public DateTime CriadoEm { get; set; }
        public DateTime AlteradoEm { get; set; }
        public int CriadoPor { get; set; }
        public int AlteradoPor { get; set; }
    }
}
