namespace sutahsilatUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.ThreadException += (sender, e) =>// Uygulama genelinde yakalanmamış hataları ele al ,hataları senderden alıyor
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu: \n \n"  +
                    e.Exception.Message, "Hata!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            };
            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>// Tutulmayan istisnalar öyleki yakalanır, 
            {
                MessageBox.Show("Kritik bir sistem hatası oluştu: \n \n" +
                    e.ExceptionObject?.ToString(), "Kritik Hata!",//null gelebilir diye null kontrolü yapıldı
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
            Application.Run(new Form1());
        }
    }
}