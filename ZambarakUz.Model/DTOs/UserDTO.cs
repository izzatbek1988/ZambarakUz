namespace ZambarakUz.Model.DTOs
{
    public class UserDTO
    {
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
    }
}
