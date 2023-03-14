using LabD_02.Models.Domain;
using LabD_02.Models.view;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LabD_02.Controllers
{
    public class TicketController : Controller
    {

    #region service 
        private readonly ILogger<TicketController> _logger;
        public TicketController(ILogger<TicketController> logger)
        {
            _logger = logger;
        }
        #endregion

        public IActionResult Index()
        {

            var tickets= Ticket.GetTicketsList();   
            return View(tickets);
        }

        [HttpGet]
        public IActionResult GetAddForm()
        {
            
            return View("Add");
        }
        [HttpPost]
        public IActionResult add(AddTicketVM ticektvm )
        {
            _logger.LogInformation(ticektvm.ToString());
            var ticketlist= Ticket.GetTicketsList();
            var tickettoAdd = new Ticket
            {
                Id = Guid.NewGuid(),
                CreatedDate = ticektvm.CreatedDate,
                Isclosed = ticektvm.Isclosed,
                Description = ticektvm.Description,
                severity = ticektvm.severity
            };
            ticketlist.Add(tickettoAdd);
            return RedirectToAction(nameof(Index));
        }
    }
}
