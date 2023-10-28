using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZambarakUz.DataAccess.Entites;
using ZambarakUz.DataAccess.Entities;

public class User
{
    [Key]
    public Guid UID { get; set; }

    public Guid GROUP_UID { get; set; }
    public Guid CLIENT_UID { get; set; }
    public string ALIAS { get; set; }
    public string PASSWORD { get; set; }
    public string? LOGIN_FOR_KKM { get; set; }
    public string? PASSWORD_FOR_KKM { get; set; }
    public string? BARCODE { get; set; }
    public decimal FONT_SIZE { get; set; }
    public DateTime DATE_IN { get; set; }
    public DateTime DATE_OUT { get; set; }
    public bool? IS_KICKED { get; set; }
    public bool? IS_DELETED { get; set; }
    public string SECTION_UID { get; set; }
    [NotMapped]
    public virtual UserGroup GROUP_ { get; set; } // Bu alanim yukarideki public Guid GROUP_UID { get; set; } alaninin ilisgikisini temsil etmesini istiyorum
    [NotMapped]
    public virtual Client CLIENT_ { get; set; } // Bu alanim yukarideki public Guid CLIENT_UID { get; set; } alaninin ilisgikisini temsil etmesini istiyorum
}
/*UID
GROUP_UID
CLIENT_UID
ALIAS
PASSWORD
LOGIN_FOR_KKM
PASSWORD_FOR_KKM
BARCODE
FONT_SIZE
DATE_IN
DATE_OUT
IS_KICKED
IS_DELETED
SECTION_UID*/