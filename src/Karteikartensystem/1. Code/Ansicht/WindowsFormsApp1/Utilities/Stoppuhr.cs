namespace AnsichtsFenster.Utilities
{
    using System.Diagnostics;

    public class Stoppuhr
    {
        Stopwatch stopWatch = new Stopwatch();

        public void Start()
        {
            stopWatch.Start();
        }

        public void Stop()
        {
            stopWatch.Stop();
        }

        public int GetZeit()
        {
            return stopWatch.Elapsed.Minutes;
        }
    }
}
