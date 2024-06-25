using Microsoft.AspNetCore.Mvc;
using CovidVaccinationSystem.Models;
using CovidVaccinationSystem.Repositories;

[ApiController]
[Route("api/[controller]")]
public class PatientController : ControllerBase
{
    private readonly IPatientRepository _patientService;

    public PatientController(IPatientRepository patientService)
    {
        _patientService = patientService;
    }

    [HttpGet]
    public async Task<IEnumerable<Patient>> Get() => await _patientService.GetAllAsync();

    [HttpGet("{id}")]
    public async Task<ActionResult<Patient>> Get(int id)
    {
        var patient = await _patientService.GetByIdAsync(id);
        if (patient == null)
        {
            return NotFound();
        }
        return Ok(patient);
    }

    [HttpPost]
    public async Task<ActionResult> Post([FromBody] Patient patient)
    {
        await _patientService.AddAsync(patient);
        return CreatedAtAction(nameof(Get), new { id = patient.Id }, patient);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Put(int id, [FromBody] Patient patient)
    {
        if (id != patient.Id)
        {
            return BadRequest();
        }

        await _patientService.UpdateAsync(patient);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        await _patientService.DeleteAsync(id);
        return NoContent();
    }
}
