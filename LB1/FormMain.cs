namespace LB1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // создадим объекет контекста данных
            using (ApplicationContext db = new ApplicationContext()) { 
                // получим записи из таблицы Users и создадим из них список
                var users = db.Users.ToList();

                labelUsers.Text = "Список пользователей:";

                foreach (var user in users) { 
                    LabelInfAboutUsers.Text += ($"{user.Id}. {user.Name} - {user.Age}\n");
                }
            }
        }
    }
}


