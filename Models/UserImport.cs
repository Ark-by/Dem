using System;
using System.Collections.Generic;

namespace pz4.Models;

public partial class UserImport
{
    public int UserId { get; set; }

    public string? РольСотрудника { get; set; }

    public string? Фио { get; set; }

    public string? Логин { get; set; }

    public string? Пароль { get; set; }
}
