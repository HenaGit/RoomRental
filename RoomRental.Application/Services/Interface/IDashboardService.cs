﻿using RoomRental.Application.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomRental.Application.Services.Interface
{
    public interface IDashboardService
    {
        Task<RadialBarChartDto> GetTotalBookingRadialChartData();
        Task<RadialBarChartDto> GetRegisteredUserChartData();
        Task<RadialBarChartDto> GetRevenueChartData();
        Task<PieChartDto> GetBookingPieChartData();
        Task<LineChartDto> GetMemberAndBookingLineChartData();
    }
}
