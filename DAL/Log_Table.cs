//------------------------------------------------------------------------------
// <auto-generated>
//    Bu kod bir şablondan oluşturuldu.
//
//    Bu dosyada el ile yapılan değişiklikler uygulamanızda beklenmedik davranışa neden olabilir.
//    Kod yeniden oluşturulursa, bu dosyada el ile yapılan değişikliklerin üzerine yazılacak.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Log_Table
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string IPAddress { get; set; }
        public int ProcessID { get; set; }
        public int ProcessType { get; set; }
        public string ProcessCategoryType { get; set; }
        public System.DateTime ProcessDate { get; set; }
    
        public virtual ProcessType ProcessType1 { get; set; }
        public virtual T_User T_User { get; set; }
    }
}