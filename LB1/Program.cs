namespace LB1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            using (ApplicationContext db = new ApplicationContext()) {
                User user1 = new User { Name = "Tom", Age = 33 };
                User user2 = new User { Name = "Alice", Age = 26 };

                db.Users.AddRange(user1, user1);
                db.SaveChanges();
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }
    }
}