using Microsoft.EntityFrameworkCore;

namespace LB1
{
    internal class ApplicationContext: DbContext
    {
        // DbSet в C# — это список (набор) сущностей, хранящихся в базе данных.
        // Через этот класс разработчик выполняет основные запросы в базе данных
        //
        // DbSet выполняет две функции:
        //   - при вызове свойства контекста данных он возвращает коллекцию объектов, полученных из базы данных;
        //   - указывает классу DbModelBuilder, выполняющему привязку модели к базе данных, что этот класс модели должен отображаться на таблицу базы данных.
        public DbSet<User> Users { get; set; } = null;

        public ApplicationContext()
        {
            // Database.EnsureCreated() — это метод в Entity Framework Core, который гарантирует, что база данных будет создана.
            // Если БД отсутствует, то метод создаёт её.
            // Если база данных имеется, но она не имеет таблиц, то этот метод создаёт таблицы, которые соответствуют схеме данных.
            // Если база данных имеется и она имеет таблицы, то этот метод не оказывает никакого влияния.

            //Метод возвращает true, если база данных создана в результате вызова этого метода.
            //Если база данных уже есть, то возвращается false.

            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Строка подключения содержит адрес сервера (параметр Host),
            // порт (Port), название базы данных на сервере (Database),
            // имя пользователя в рамках сервера PostgreSQL (Username) и его пароль (Password)

            optionsBuilder.UseNpgsql(
                "Host = localhost; Port = 5432; Database = usersdb; Username = postgres; Password =1234");
                
        }
    }
}
