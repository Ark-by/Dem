using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace pz4.Models;

public partial class ЗаказImport
{
    public int НомерЗаказа { get; set; }

    public string? АртикулЗаказа { get; set; }

    public string? ДатаЗаказа { get; set; }

    public string? ДатаДоставки { get; set; }

    public int? АдресПунктаВыдачи { get; set; }

    public string? ФиоАвторизированногоКлиента { get; set; }

    public int? КодДляПолучения { get; set; }

    public string? СтатусЗаказа { get; set; }

    public virtual ПунктыВыдачиImport? АдресПунктаВыдачиNavigation { get; set; }

    Ispr2525AvetisyanAaLazarev1Context context;
    public void BeginEdit()
    {
        context = new();
        context.Update(this);
    }
    public void CancelEdit()
    {
        var entry = context.Entry(this);
        if (entry.State == Microsoft.EntityFrameworkCore.EntityState.Modified)
        {
            entry.Reload();
        }
    }
    public void EndEdit()
    {
        if (string.IsNullOrEmpty(АртикулЗаказа))
        {
            throw new ValidationException("Артикул не должен быть пустым");
        }
        if (string.IsNullOrEmpty(ДатаЗаказа))
        {
            throw new ValidationException("ДатаЗаказа не должен быть пустым");
        }
        if (string.IsNullOrEmpty(ДатаДоставки))
        {
            throw new ValidationException("ДатаДоставки не должен быть пустым");
        }
        if (string.IsNullOrEmpty(ФиоАвторизированногоКлиента))
        {
            throw new ValidationException("ФиоАвторизированногоКлиента не должен быть пустым");
        }
        if (string.IsNullOrEmpty(СтатусЗаказа))
        {
            throw new ValidationException("СтатусЗаказа не должен быть пустым");
        }
        context.SaveChanges();
    }
}
