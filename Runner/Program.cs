namespace Runner
{
    using Serilog;
    using Serilog.Core;

    public partial class Program
    {
        private static Logger Log = new LoggerConfiguration()
                                    .MinimumLevel.Verbose()
                                    .WriteTo.Console(
#if !DEBUG
                                        LogEventLevel.Warning
#endif
                                    ).WriteTo.File(
                                        path: "logs/runner.log"
                                    ).CreateLogger();

        static void Main(string[] args)
        {
            var exercises = GetExercises();
            Log.Debug("Exercises: {@exercises}", exercises);
            
            
        }
    }
}