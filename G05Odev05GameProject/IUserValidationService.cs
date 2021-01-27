using System;
using System.Collections.Generic;
using System.Text;

namespace G05Odev05GameProject
{
    /// <summary>
    /// GameManager E-Devletten doğrulama işlemi yapılması gerektiği için Mikro Servis sayılıyor.
    /// Kendi içinde dışarıdan çalışan bir servis gibi düşünmek lazım.
    /// </summary>
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
