using APiFizyo.Data;
using APiFizyo.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APiFizyo.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class KullanıcıController : ControllerBase //controllerbaseden geliyor fark olarak mvcden
    {
        //DI Dependency Injection 
        //Bağımlılık Enjeksiyonu
        //Database Bağlantısı
        private readonly APIFizyoDBContext _context;

        public KullanıcıController(APIFizyoDBContext context)
        {
            _context = context;
        }


        //dönen bir şey olursa returnde ActionResult 
        //dönen bir şey olmazsa noContent gibi IActionResult 




        //hepsini almak için
        // GET: api/TümKullanıcılarıGetir
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Kullanıcı>>> TümKullanıcılarıGetir()
        //tümkullanıcı listesini getir
        {
            IEnumerable<Kullanıcı> kullanıcılar = await _context.Kullanıcılar.ToListAsync();

            return await _context.Kullanıcılar.ToListAsync();
        }




        //seçili olanı alma
        // GET: api/SeçiliKullanıcıyıGetir
        [HttpGet("SeçiliKullanıcıyıGetir/{id}")]
        public async Task<ActionResult<Kullanıcı>> seçiliKullanıcıyıGetir(int id)
        {
            return await _context.Kullanıcılar.FindAsync(id);
            //primaryKey olarak eminsen kullanıyorsun, FirstOrDefault gibi, firstordefault için farketmiyor hepsinde geçerli
        }




        //seçili olanı alma
        // GET: api/SeçiliKullanıcıyıGetir
        [HttpGet("{SeçiliKullanıcıyıGetir}")]
        public async Task<ActionResult<IEnumerable<Kullanıcı>>> KullanıcılarByRol(int id)
        {
            return await _context.Kullanıcılar.Where(kullanıcı => kullanıcı.RolID == id).ToListAsync();
        }




        // GET: api/ROl ID ve kullanıcı adına göre
        [HttpGet("KullanıcılarByRolAD/{Ad}")]
        public async Task<ActionResult<IEnumerable<Kullanıcı>>> KullanıcılarByRolAD(string Ad)
        {
            return await _context.Kullanıcılar.Include(kullanıcı => kullanıcı.Rol).Where(kullanıcı => kullanıcı.Rol.RolAdı == Ad).ToListAsync();
            //seçili rol ıd ye ait kullanıcıları getir demek 
        }





        // ekleme
        // POST: api/Kullanıcı/5
        [HttpPost]
        public async Task<ActionResult<Kullanıcı>> KullanıcıEkle(Kullanıcı kullanıcı)
        {
            _context.Kullanıcılar.Add(kullanıcı);
            await _context.SaveChangesAsync();
            return NoContent();
        }




        // güncelleme
        // PUT: api/Kullanıcı/5

        [HttpPut("{id}")]
        public async Task<ActionResult<Kullanıcı>> KullanıcıGüncelle(int id, Kullanıcı kullanıcı)
        // id kimi güncelleyeyim,kullanıcı ne ile güncelleyeyim
        {

            _context.Entry(kullanıcı).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return await _context.Kullanıcılar.FindAsync(id);
            //dönen bir şey olursa returnde ActionResult 
            //dönen bir şey olmazsa noContent gibi IActionResult 

        }




        // silme
        // DELETE: api/Kullanıcı/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRol(int id)
        {
            Kullanıcı kullanıcı = await _context.Kullanıcılar.FindAsync(id);
            if (kullanıcı == null)
            {
                return NotFound();
            }

            _context.Kullanıcılar.Remove(kullanıcı);
            await _context.SaveChangesAsync();

            return NoContent();
        }




        //Kullanıcılardan admin kullanıcı outlook mailli ve şifresi 5 den büyük 
        //8 tane iş yapıyo
        //Roladı girilmiş veya null
        //Eposta girilmiş veya null
        //limit girilmiş veya null

        //Multi filters
        // GET: api/ROl ID, şifre ve kullanıcı adına göre
        [HttpGet("KullanıcılarFiltreli/{EpostaUzantı}/{RolAdı}")]
        public async Task<ActionResult<IEnumerable<Kullanıcı>>> KullanıcılarFiltreli(string RolAdı, string EpostaUzantı, int? limit)
                                                                                     //string nullabledir    , int? nullable olabilir
        {
            return await _context.Kullanıcılar.Include(a => a.Rol).
            Where(a =>
                      (a.Rol.RolAdı == RolAdı || RolAdı == null)
                      &&
                      (a.Eposta.Contains(EpostaUzantı) || EpostaUzantı == null)
                      &&
                      (a.Şifre.Length > limit || limit == null)
                  )
                      .ToListAsync();

        }








    }
}
