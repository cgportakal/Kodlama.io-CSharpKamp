using System;
using System.Collections.Generic;
using System.Text;

namespace G05Eg02OOP3
{
    /// <summary>
    /// Başvuru Yapma
    /// </summary>
    class RequestManager
    {
        /// <summary>
        /// Metot injection yapıyoruz. Yani burada sadece soyutlama var.
        /// </summary>
        /// <param name="creditManager"></param>
        /// <param name="loggerService"></param>
        public void MakeRequest(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        public void KrediOnBilgilendirmesiYap(List<ICreditManager> credits)
        {
            foreach (ICreditManager credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
