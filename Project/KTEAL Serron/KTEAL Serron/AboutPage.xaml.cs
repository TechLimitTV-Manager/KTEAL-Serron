using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace KTEAL_Serron
{
    public sealed partial class AboutPage : Page
    {
        public AboutPage()
        {
            this.InitializeComponent();
        }
        private void About_Page_Loading(FrameworkElement sender, object args)
        {
            About_Content.NavigateToString(@"
                <html>
                    <body>
                        <center>
                            <hr/>
                                Έκδοση : 1.3.1.0 <br />
                                Εκδότης : TechLimitTV.eu <br />
                            <hr/>
                                Η εφαρμογή αυτή έγινε στο 1ο Hackathon των Μηχανικών Πληροφορικής Τ.Ε. του TEI Κεντρικής Μακεδονίας. <br />
                            <hr />
                                Η εφαρμογή ειναι γραμμένη σε Visual C# και είναι ανοιχτού κώδικα. <br />
                                Αν θέλετε το Source Code μπείτε στο TechLimitTV.eu/KTEALSerronSource <br />
                            <hr/>
                                Το λογότυπο της εφαρμογής ανήκει στην εταιρία ΚΤΕΑΛ Σερρών Α.Ε. και σε καμία περίπτωση δεν το αξίωνουμε ως δικό μας. <br />
                            <hr/>
                                © 2012-2016 TechLimitTV.eu
                    </body>
                </html>");
        }
    }
}
