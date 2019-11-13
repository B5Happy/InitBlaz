using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InitBlaz.Shared.Dto.Input.Instrument.ForCreate
{
    public class DtoInputInstrumentForCreate
    {
        [Required(ErrorMessage = "Le champ '{0}' est obligatoire")]
        [StringLength(40, MinimumLength =2, ErrorMessage = " Le champ '{0}' doit faire plus de 2 caractères et maximum 40 caractères")]
        [DisplayName("Nom")]
        public string Name { get; set; }

        public int Strings { get; set; }

        public int YearManufacture { get; set; }
    }
}
