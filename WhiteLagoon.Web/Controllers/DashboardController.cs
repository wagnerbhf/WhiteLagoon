using Microsoft.AspNetCore.Mvc;
using WhiteLagoon.Application.Services.Interface;

namespace WhiteLagoon.Web.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IDashboardService _dashboardService;

        public DashboardController(IDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult GetTotalBookingRadialChartData()
        {
            return Json(_dashboardService.GetTotalBookingRadialChartData());
        }

        public IActionResult GetRegisteredUserChartData()
        {
            return Json(_dashboardService.GetRegisteredUserChartData());
        }

        public IActionResult GetRevenueChartData()
        {
            return Json(_dashboardService.GetRevenueChartData());
        }

        public IActionResult GetBookingPieChartData()
        {
            return Json(_dashboardService.GetBookingPieChartData());
        }

        public IActionResult GetMemberAndBookingLineChartData()
        {
            return Json(_dashboardService.GetMemberAndBookingLineChartData());
        }
    }
}