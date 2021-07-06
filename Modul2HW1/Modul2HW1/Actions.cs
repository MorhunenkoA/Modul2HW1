using System;

namespace Modul2HW1
{
    public class Actions
    {
        public Result Method1()
        {
            Logger.Instance.Output(LoggerType.Info, "Start method:");
            return new Result(true);
        }

        public Result Method2()
        {
            Logger.Instance.Output(LoggerType.Warning, "Skipped logic in method:");
            return new Result(true);
        }

        public Result Method3()
        {
            Logger.Instance.Output(LoggerType.Error, "I broke a logic");
            return new Result(false);
        }
    }
}