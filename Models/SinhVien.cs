namespace BT_C.Models
{
    public class SinhVien
    {
        public int Id { get; set; }
        public string Ten { get; set; }

        public List<DangKy> DangKys { get; set; }
    }
}
