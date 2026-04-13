namespace BT_C.Models
{
    public class KhoaHoc
    {
        public int Id { get; set; }
        public string TenKhoaHoc { get; set; }

        public List<DangKy> DangKys { get; set; }
    }
}
