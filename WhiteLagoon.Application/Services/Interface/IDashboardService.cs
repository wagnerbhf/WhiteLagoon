using WhiteLagoon.Application.Common.DTO;

namespace WhiteLagoon.Application.Services.Interface
{
    public interface IDashboardService
    {
        RadialBarChartDto GetTotalBookingRadialChartData();
        RadialBarChartDto GetRegisteredUserChartData();
        RadialBarChartDto GetRevenueChartData();
        PieChartDto GetBookingPieChartData();
        LineChartDto GetMemberAndBookingLineChartData();
    }
}