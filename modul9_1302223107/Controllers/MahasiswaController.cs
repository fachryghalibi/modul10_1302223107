
using Microsoft.AspNetCore.Mvc;
using modul9_1302223107;
namespace modul9_1302223107.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> listMahasiswa = new List<Mahasiswa>
    {
        new Mahasiswa{Nama=" Fachruddin Ghalibi", NIM= "1302223107", Course=["KPL", "PBO", "BASDAT"], Year = 2022 },
        new Mahasiswa{Nama=" Muhammad Fadlan Ghalibi", NIM= "1302223232", Course=["KPL", "PBO", "BASDAT"], Year = 2022 },
        new Mahasiswa{Nama=" Ihsan Ghalibi", NIM= "1302223131", Course=["KPL", "PBO", "BASDAT"], Year = 2022 }
    };
        [HttpGet]

        public IEnumerable<Mahasiswa> Get()
        {
            return listMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return listMahasiswa[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswa)
        {
            listMahasiswa.Add(mahasiswa);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listMahasiswa.RemoveAt(id);
        }
    }
}