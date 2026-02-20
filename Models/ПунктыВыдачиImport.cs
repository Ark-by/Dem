using System;
using System.Collections.Generic;

namespace pz4.Models;

public partial class ПунктыВыдачиImport
{
    public int Id { get; set; }

    public int? Индекс { get; set; }

    public string? Город { get; set; }

    public string? Улица { get; set; }

    public int? Дом { get; set; }
}
