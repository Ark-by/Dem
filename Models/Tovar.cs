using System;
using System.Collections.Generic;

namespace pz4.Models;

public partial class Tovar
{
    public int Id { get; set; }

    public string? Артикул { get; set; }

    public string? НаименованиеТовара { get; set; }

    public string? ЕдиницаИзмерения { get; set; }

    public int? Цена { get; set; }

    public string? Поставщик { get; set; }

    public string? Производитель { get; set; }

    public string? КатегорияТовара { get; set; }

    public int? ДействующаяСкидка { get; set; }

    public int? КолВоНаСкладе { get; set; }

    public string? ОписаниеТовара { get; set; }

    public string? Фото { get; set; }
}
