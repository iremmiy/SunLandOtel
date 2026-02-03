using SunLandOtel.Forms; // Bu satýrý ekledik, formlarý bulmasýný saðlar.

namespace SunLandOtel
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            // Artýk FrmAnaMenu'yü tanýyacak
            Application.Run(new FrmAnaMenu());
        }
    }
}