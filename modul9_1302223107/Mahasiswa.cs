namespace modul9_1302223107;

public class Mahasiswa
{
    public string Nama { get; set; }
    public string NIM { get; set; }

    public List<string> Course { get; set; }
    public int Year { get; set; }

    public Mahasiswa()
    {
        this.Nama = Nama;
        this.NIM = NIM;
        this.Course = new List<string>();
        this.Year = Year;
    }
}