using System.ComponentModel.DataAnnotations;
using ZambarakUz.DataAccess.Entites;

namespace ZambarakUz.DataAccess.Entities
{
    public class Client
    {
        [Key]
        public Guid UID { get; set; }

        public DateTime DATE_ADD { get; set; }
        public string NAME { get; set; }
        public Guid GROUP_UID { get; set; }
        public DateTime BIRTHDAY { get; set; }
        public string COMMENT { get; set; }
        public string BARCODE { get; set; }
        public string ADDRESS { get; set; }
        public string PHONE { get; set; }
        public string EMAIL { get; set; }
        public bool IS_DELETED { get; set; }

        // Bu alan ile UserGroup tablosuna olan ilişkiyi belirliyoruz

        public virtual ClientGroup GROUP_ { get; set; }

    }
}
/*
UID
DATE_ADD
NAME
GROUP_UID
BIRTHDAY
COMMENT
BARCODE
ADDRESS
PHONE
EMAIL
IS_DELETED*/