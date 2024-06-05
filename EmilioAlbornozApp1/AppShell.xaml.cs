using EmilioAlbornozApp1.Views;

namespace EmilioAlbornozApp1
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(EA_NotePage), typeof(EA_NotePage));
            Routing.RegisterRoute(nameof(EA_ConteoCaracteresPage), typeof(EA_ConteoCaracteresPage));
        }
    }
}
