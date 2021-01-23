using System;
using System.Collections.Generic;
using System.Text;

namespace G05Eg02OOP3
{
    /// <summary>
    /// Interface - Kendisini kaynak gösteren classların bu şablona uymak zorundasın deme yöntemi
    /// Yani burada oluşturduğumuz metotları interfaceyi implemente eden yerlerde de olmak zorunda.
    /// </summary>
    interface ICreditManager
    {
        void Calculate();
        void DoSomething();
    }
}
