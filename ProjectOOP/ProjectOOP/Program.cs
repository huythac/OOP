//using ProjectOOP.DATA;

namespace ProjectOOP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string compileInfoPath = @"C:\Users\ACER\Downloads\json.txt"; // ???ng d?n t?i t?p tin l?u thông tin biên d?ch
            string foodPath = @"C:\Users\ACER\Downloads\HangHoa.txt";
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new formHome());
            //Data data = new Data();
            //data.Serialize();
        }
    }
}