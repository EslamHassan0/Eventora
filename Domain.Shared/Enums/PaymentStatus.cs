using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventora.Domain.Shared.Enums
{
    public enum PaymentStatus
    {
        Pending,      // لم يتم الدفع بعد
        Paid,         // تم الدفع بالكامل
        PartiallyPaid,// تم دفع جزء فقط
        Failed,       // فشل الدفع
        Refunded      // تم استرجاع المبلغ
    }
}
