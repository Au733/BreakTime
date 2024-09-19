using Android.App.Admin;

namespace BreakTime.Custom;

public class TimerLogic
{

    private void CountDown(int minutes)
    {
        Application.Current.Dispatcher.StartTimer(TimeSpan.FromMinutes(1), () =>
        {
            TimeRemaining = minutes;
            TimeRemaining--;


            return TimeRemaining;
        });

    }
}