using GusApiApp.Misc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GusApiApp.Model
{
    public class Area
    {
        [JsonPropertyName("id")]
        [ColumnName("Nazwa")]
        public int Id { get; set; }

        [JsonPropertyName("nazwa")]
        [ColumnName("Nazwa")]
        public string? Name { get; set; }

        [JsonPropertyName("id-nadrzedny-element")]
        [ColumnName("Id nadrzędnego elementu")]
        public int Id_Master_Element { get; set; }

        [JsonPropertyName("id-poziom")]
        [ColumnName("Id poziomu")]
        public int Id_Level { get; set; }

        [JsonPropertyName("nazwa-poziom")]
        [ColumnName("Nazwa poziomu")]
        public string? Level_Name { get; set; }

        [JsonPropertyName("czy-zmienne")]
        [ColumnName("Czy zmienne")]
        public bool Variable { get; set; }
    }
}
