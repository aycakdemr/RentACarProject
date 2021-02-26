using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImageController : ControllerBase
    {
        public static IWebHostEnvironment _webHostEnvironment;

        ICarImageService _CarImageService;

        public CarImageController(ICarImageService CarImageService, IWebHostEnvironment webHostEnvironment)
        {
            _CarImageService = CarImageService;
            _webHostEnvironment = webHostEnvironment;
           
        }
        //[HttpGet("getall")]
        //public IActionResult GetAll()
        //{
        //    var result = _CarImageService.GetAll();
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}

        //[HttpGet("getbyid")]
        //public IActionResult GetById(int id)
        //{
        //    var result = _CarImageService.GetById(id);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}

        //[HttpPost("add")]
        //public IActionResult Add(CarImage carImage)
        //{

        //    var result = _CarImageService.Add(carImage);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}
        //[HttpPost("delete")]
        //public IActionResult Delete(CarImage carImage)
        //{
        //    var result = _CarImageService.Delete(carImage.Id);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}
        //[HttpPost("update")]
        //public IActionResult Update(int id, CarImage carImage)
        //{
        //    var result = _CarImageService.Update(id, carImage);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}
        [HttpPost("add")]
        public IActionResult Add([FromForm] FileUpload objectFile)
        {
            try
            {
                if (objectFile.files.Length > 0)
                {

                    string path = _webHostEnvironment.WebRootPath + "\\uploads\\";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    using (FileStream fileStream = System.IO.File.Create(path + objectFile.files.FileName))
                    {
                        var result = _CarImageService.Add(new CarImage { Date = DateTime.Now, ImagePath = path });
                        if (result.Success)
                        {
                            objectFile.files.CopyTo(fileStream);
                            fileStream.Flush();
                            return Ok(result);
                        }
                        return BadRequest(result);
                    }

                }

                return BadRequest();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    
    }
}
