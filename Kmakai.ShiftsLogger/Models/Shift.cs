﻿namespace Kmakai.ShiftsLogger.Models;

public class Shift
{
    public int Id { get; set; }
    public string? EmployeeName { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public TimeSpan? Duration => (EndTime - StartTime);
}
