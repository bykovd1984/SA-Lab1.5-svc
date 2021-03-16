using System.Threading.Tasks;

namespace Lab_1._5
{
    public class ReadyChecker
    {
        public static bool IsReady { get; private set; } = false;

        public static void Start()
        {
            Task.Run(async () =>
            {
                await Task.Delay(5000);

                IsReady = true;
            });
        }
    }
}
