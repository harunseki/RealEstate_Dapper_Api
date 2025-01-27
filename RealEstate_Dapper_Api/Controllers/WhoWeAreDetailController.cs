using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.WhoWeAreDetailDtos;
using RealEstate_Dapper_Api.Repositories.WhoWeAreRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhoWeAreDetailController : ControllerBase
    {
        private readonly IWhoWeAreRepository _whoWeAreRepository;

        public WhoWeAreDetailController(IWhoWeAreRepository whoWeAreRepository)
        {
            _whoWeAreRepository = whoWeAreRepository;
        }
        [HttpGet("List")]
        public async Task<IActionResult> WhoWeAreList()
        {
            var values = await _whoWeAreRepository.GetAllWhoWeAreDetailAsync();
            return Ok(values);
        }
        [HttpPost("Create")]
        public async Task<IActionResult> CreateWhoWeAreDetail(CreateWhoWeAreDetailDto createWhoWeAreDto)
        {
            _whoWeAreRepository.CreateWhoWeAreDetail(createWhoWeAreDto);
            return Ok("Hakkımızda kısmı başarılı şekilde eklendi...");
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteWhoWeAreDetail(int id)
        {
            _whoWeAreRepository.DeleteWhoWeAreDetail(id);
            return Ok("Hakkımızda Silme başarılı");
        }
        [HttpPut("Update")]
        public async Task<IActionResult> UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDto updateWhoWeAreDto)
        {
            _whoWeAreRepository.UpdateWhoWeAreDetail(updateWhoWeAreDto);
            return Ok("Hakkımızda Güncelleme Başarılı");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetWhoWeAreDetail(int id)
        {
            var values = await _whoWeAreRepository.GetWhoWeAreDetail(id);
            return Ok(values);
        }
    }
}
