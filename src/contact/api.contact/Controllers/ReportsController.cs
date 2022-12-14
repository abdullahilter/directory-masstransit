using entity.contact;
using Microsoft.AspNetCore.Mvc;
using service.contact;

namespace api.contact.Controllers;

[ApiController]
[Route("[controller]")]
public class ReportsController : ControllerBase
{
    private readonly ICommunicationService _service;

    public ReportsController(ICommunicationService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<List<ContactReportResponse>> GetReportAsync(CancellationToken cancellationToken)
    {
        var results = await _service.GetReportAsync(cancellationToken);

        return results;
    }
}