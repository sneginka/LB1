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

                // создаем два объекта класса User
                User user1 = new User { Name = "Том", Age = 33 };
                User user2 = new User { Name = "Алиса", Age = 26 };

                // Добавляем пользователей в БД
                db.Users.AddRange(user1, user1);
                db.SaveChanges();
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }
    }
}