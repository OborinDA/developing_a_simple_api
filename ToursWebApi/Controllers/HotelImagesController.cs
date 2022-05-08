using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ToursWebApi.Entities;

namespace ToursWebApi.Controllers
{
    public class HotelImagesController : ApiController
    {
        private ToursBaseEntities db = new ToursBaseEntities();

        // GET: api/HotelImages
        public IQueryable<HotelImage> GetHotelImage()
        {
            return db.HotelImage;
        }

        // GET: api/HotelImages/5
        [ResponseType(typeof(HotelImage))]
        public IHttpActionResult GetHotelImage(int id)
        {
            HotelImage hotelImage = db.HotelImage.Find(id);
            if (hotelImage == null)
            {
                return NotFound();
            }

            return Ok(hotelImage);
        }

        // PUT: api/HotelImages/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHotelImage(int id, HotelImage hotelImage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != hotelImage.Id)
            {
                return BadRequest();
            }

            db.Entry(hotelImage).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HotelImageExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/HotelImages
        [ResponseType(typeof(HotelImage))]
        public IHttpActionResult PostHotelImage(HotelImage hotelImage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.HotelImage.Add(hotelImage);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = hotelImage.Id }, hotelImage);
        }

        // DELETE: api/HotelImages/5
        [ResponseType(typeof(HotelImage))]
        public IHttpActionResult DeleteHotelImage(int id)
        {
            HotelImage hotelImage = db.HotelImage.Find(id);
            if (hotelImage == null)
            {
                return NotFound();
            }

            db.HotelImage.Remove(hotelImage);
            db.SaveChanges();

            return Ok(hotelImage);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HotelImageExists(int id)
        {
            return db.HotelImage.Count(e => e.Id == id) > 0;
        }
    }
}