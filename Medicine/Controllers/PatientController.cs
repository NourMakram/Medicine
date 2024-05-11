using Medicine.Dtos;
using Medicine.Dtos.Patient;
using Medicine.Models;
using Medicine.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Medicine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {

        private readonly Ipatient _repository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IFileService _fileService;

        public PatientController(Ipatient repository,
            UserManager<ApplicationUser> userManager,
            IFileService fileService)
        {
            _repository = repository;
            _userManager = userManager;
            _fileService = fileService;
        }
        [HttpGet("GetById/{id}")]
        public ActionResult<List<PatientDto>> GetById(string id)
        {
            return _repository.getPatientById(id);

        }

        [HttpPost("PatientsAfterEdit/{id}")]
        public async Task<IActionResult> Edit(string id, [FromForm] PatientDto model)
        {

            try
            {
                // Update ApplicationUser properties
                var user = await _userManager.FindByIdAsync(id);
                if (user != null)
                {
                    string oldimage = user.ImageUrl;
                    if (model.ImageFile != null)
                    {
                        await _fileService.DeleteImage(oldimage);
                    }

                    if (model.ImageFile != null)
                    {
                        var fileResult = _fileService.SaveImage(model.ImageFile);
                        if (fileResult.Item1 == 1)
                        {
                            model.ImageUrl = fileResult.Item2; // getting name of image
                        }
                    }
                    user.PhoneNumber = model.PhoneNumber;
                    user.UserName = model.UsreName;
                    user.Email = model.Email;
                    user.ImageUrl = model.ImageUrl;

                    var userMange = await _userManager.UpdateAsync(user);
                    _repository.UpdateProfile(id, new Patient()
                    {
                        BloodType = model.BloodType,
                        userId = user.Id,

                    });


                    return Ok("Patient updated successfully!");

                }
                else
                {
                    return NotFound(" user not found");
                }


            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
    }
}

