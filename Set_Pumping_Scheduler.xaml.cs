using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AquaSmart
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Set_Pumping_Scheduler : ContentPage
    {
        int mon_col = 0, tue_col = 0, wed_col = 0, thu_col = 0, fri_col = 0, sat_col = 0, sun_col = 0;
        public Set_Pumping_Scheduler()
        {
            InitializeComponent();
            BackgroundColor = Color.SkyBlue;
            start_clock.Time = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            end_clock.Time = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute + 5, DateTime.Now.Second);
            var Mon_tapGesture = new TapGestureRecognizer();
            Mon_tapGesture.Tapped += (s, e) =>
             {
                 mon_col++;
                 if (mon_col % 2 == 1)
                     Mon.BackgroundColor = Color.Green;
                 else
                     Mon.BackgroundColor = Color.Aqua;
                 save_Clicked(s, e);
             };
            Mon.GestureRecognizers.Add(Mon_tapGesture);
            var Tue_tapGesture = new TapGestureRecognizer();
            Tue_tapGesture.Tapped += (s, e) =>
            {
                tue_col++;
                if (tue_col % 2 == 1)
                    Tue.BackgroundColor = Color.Green;
                else
                    Tue.BackgroundColor = Color.Aqua;
                save_Clicked(s, e);
            };
            Tue.GestureRecognizers.Add(Tue_tapGesture);
            var Wed_tapGesture = new TapGestureRecognizer();
            Wed_tapGesture.Tapped += (s, e) =>
            {
                wed_col++;
                if (wed_col % 2 == 1)
                    Wed.BackgroundColor = Color.Green;
                else
                    Wed.BackgroundColor = Color.Aqua;
                save_Clicked(s, e);
            };
            Wed.GestureRecognizers.Add(Wed_tapGesture);
            var Thu_tapGesture = new TapGestureRecognizer();
            Thu_tapGesture.Tapped += (s, e) =>
            {
                thu_col++;
                if (thu_col % 2 == 1)
                    Thu.BackgroundColor = Color.Green;
                else
                    Thu.BackgroundColor = Color.Aqua;
                save_Clicked(s, e);
            };
            Thu.GestureRecognizers.Add(Thu_tapGesture);
            var Fri_tapGesture = new TapGestureRecognizer();
            Fri_tapGesture.Tapped += (s, e) =>
            {
                fri_col++;
                if (fri_col % 2 == 1)
                    Fri.BackgroundColor = Color.Green;
                else
                    Fri.BackgroundColor = Color.Aqua;
                save_Clicked(s, e);
            };
            Fri.GestureRecognizers.Add(Fri_tapGesture);
            var Sat_tapGesture = new TapGestureRecognizer();
            Sat_tapGesture.Tapped += (s, e) =>
            {
                sat_col++;
                if (sat_col % 2 == 1)
                    Sat.BackgroundColor = Color.Green;
                else
                    Sat.BackgroundColor = Color.Aqua;
                save_Clicked(s, e);
            };
            Sat.GestureRecognizers.Add(Sat_tapGesture);
            var Sun_tapGesture = new TapGestureRecognizer();
            Sun_tapGesture.Tapped += (s, e) =>
            {
                sun_col++;
                if (sun_col % 2 == 1)
                    Sun.BackgroundColor = Color.Green;
                else
                    Sun.BackgroundColor = Color.Aqua;
                save_Clicked(s, e);
            };
            Sun.GestureRecognizers.Add(Sun_tapGesture);
            }

        private void save_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new PumpConfiguration());    
        }

        
    }
}