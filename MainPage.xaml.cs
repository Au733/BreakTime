namespace BreakTime;

public partial class MainPage : ContentPage
{
    private bool isRunning = false;
    private int _remainingTime;
    private int _i;
    

    public MainPage()
    {
        InitializeComponent();
        Title = "Break Time";
    }

    private void Countdown(int minutes)
    {
        _remainingTime = minutes;
        lblDisplay.Text = minutes.ToString() + " Minutes Left";
        isRunning = true;
        
        Dispatcher.StartTimer(TimeSpan.FromMinutes(1), () =>
        {
            if (_remainingTime > 1)
            {
                _remainingTime--;
                lblDisplay.Text = _remainingTime + " Minutes Left";

            }
            else
            {
                lblDisplay.Text = "Time is up!!!";
                TimesUp();
            }

            return isRunning;
        } );


    }

    private void TimesUp()
    {
        
        _i = 0;
        isRunning = true;
        
        Dispatcher.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            if (_i % 2 == 0)
            {
                ftmMain.Background = Colors.Yellow;
                _i++;
            }
            else
            {
                ftmMain.Background = Colors.Red;
                _i++;
            }

            return isRunning;
        } );
        
    }


    private void BtnFive_OnClicked(object sender, EventArgs e)
    {
        
        Countdown(5);
    }

    private void BtnTen_OnClicked(object sender, EventArgs e)
    {
        
        Countdown(10);
    }

    private void BtnFifteen_OnClicked(object sender, EventArgs e)
    {
        
        Countdown(15);
    }
}