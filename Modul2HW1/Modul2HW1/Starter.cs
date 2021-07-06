using System;
using System.IO;

namespace Modul2HW1
{
    public class Starter
    {
        public void Run()
        {
            var actions = new Actions();
            var result = new Result();
            result.Status = false;
            var min = 1;
            var max = 4;
            var random = new Random().Next(min, max);
            var range = 100;
            for (var i = 0; i < range; i++)
            {
                switch (random)
                {
                    case 1:
                        result = actions.Method1();
                        break;
                    case 2:
                        result = actions.Method2();
                        break;
                    case 3:
                        result = actions.Method3();
                        break;
                }
            }

            if (result.Status == false)
            {
                Logger.Instance.Output(LoggerType.Error, $"Action failed by a reason: {result.Message}");
            }

            File.WriteAllText("log.txt", Logger.Instance.ToString());
        }
    }
}
