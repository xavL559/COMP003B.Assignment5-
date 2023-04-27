using COMP003B.Assignment5.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment5.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class MusicController : ControllerBase
    {
        List<MusicPeople> musicPeoples = new List<MusicPeople>();

        public MusicController()
        {
            musicPeoples.Add(new MusicPeople { Id = 1, Title = "Still D.R.E", Artist = "Dr. DRE", Album = "2001", ReleaseYear = "1999" });
            musicPeoples.Add(new MusicPeople { Id = 2, Title = "It Was A Good Day", Artist = "Ice Cube", Album = "The Predator", ReleaseYear = "1992" });
            musicPeoples.Add(new MusicPeople { Id = 3, Title = "in Da Club", Artist = "50 Cent", Album = "Get Rich or Die Tryin'", ReleaseYear = "2003" });
            musicPeoples.Add(new MusicPeople { Id = 4, Title = "Dear Mama", Artist = "Tupac", Album = "Me Against the World", ReleaseYear = "1995" });
            musicPeoples.Add(new MusicPeople { Id = 5, Title = "Regulate", Artist = "Warren G", Album = "Above the Rim", ReleaseYear = "1994" });
        }

        //Get ALl
        
        public List<MusicPeople> Get()
        {
            return musicPeoples;
        }


        //Get single id
        
        public MusicPeople Get(int id)
        {
            return musicPeoples.Where(x => x.Id == id).FirstOrDefault();
        }

        //POST
        
        public void Post(MusicPeople val)
        {
            musicPeoples.Add(val);
        }

        //PUT
        
        public void Put(int id, [FromBody] string music)
        {

        }

        //DELETE

        [HttpDelete("{Id}")]
        public ActionResult Delete(int id)
        {
            bool badThingsHappened = false;

            if (badThingsHappened)
                return BadRequest();

            return NoContent();
        }
    }

    }


