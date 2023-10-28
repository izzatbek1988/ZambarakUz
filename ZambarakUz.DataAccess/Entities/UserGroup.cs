using System.ComponentModel.DataAnnotations;
using ZambarakUz.DataAccess.Entities;

namespace ZambarakUz.DataAccess.Entites
{
    public class UserGroup
    {
        [Key]
        public Guid UID { get; set; }
        public string NAME { get; set; }
        public bool? IS_SUPER { get; set; }
        public bool? IS_DELETED { get; set; }

    }
}

/*
UID
NAME
IS_SUPER
IS_DELETED
*/