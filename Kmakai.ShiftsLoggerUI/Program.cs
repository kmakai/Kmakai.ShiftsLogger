using Humanizer;
using Kmakai.ShiftsLoggerUI.Services;

ShiftsLoggerService shiftsLoggerService = new ShiftsLoggerService(new HttpClient());

var shift = await shiftsLoggerService.GetShiftAsync(1);


Console.WriteLine($"{shift.Id} punchIN: {shift.StartTime.ToShortDateString()}\n punchout: {shift.EndTime.ToShortDateString()} {shift.EmployeeName} totalhrs: {shift.Duration.ToString("hh'.'mm")}");


Console.WriteLine("press any key to exit");
Console.ReadKey();