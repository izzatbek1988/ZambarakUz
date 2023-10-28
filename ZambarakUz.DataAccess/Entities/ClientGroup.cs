using System.ComponentModel.DataAnnotations;

namespace ZambarakUz.DataAccess.Entities
{
    public class ClientGroup
    {
        [Key]
        public Guid UID { get; set; }
        public string NAME { get; set; }
        public decimal DISCOUNT { get; set; }
        public decimal MAX_SUM_CREDIT { get; set; }
        public string PRICE_UID { get; set; }
        public bool IS_SUPPLIER { get; set; }
        public bool IS_NON_USE_BONUS { get; set; }
        public bool IS_DELETED { get; set; }

    }
}
/*
UID
NAME
DISCOUNT
MAX_SUM_CREDIT
PRICE_UID
IS_SUPPLIER
IS_NON_USE_BONUS
IS_DELETED
*/