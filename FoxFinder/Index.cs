using MongoDB.Driver;
namespace FoxFinder
{
    public partial class Index : Form
    {
        MongoClient m_Client;
        IMongoDatabase m_Database;
        IMongoCollection<Media> m_Collection;

        MainPage page;
        Video_s video;
        Books book;
        Games game;
        Favs favs;
        public Index()
        {
            page = new MainPage();
            video = new Video_s();
            book = new Books();
            game = new Games();
            favs = new Favs();
            InitializeComponent();

            m_Client = new MongoClient("mongodb+srv://NovaFoxy:Kyuubi99@maincluster.jtr1q.mongodb.net/FoxFinder?retryWrites=true&w=majority");
            m_Database = m_Client.GetDatabase("FoxFinder");
            m_Collection = m_Database.GetCollection<Media>("Media");
        }

        private void foxfinder_Click(object sender, EventArgs e)
        {
            page.Show();
            video.Hide();
            book.Hide();
            game.Hide();
            favs.Hide();
            this.Controls.Add(page);
        }

        private void videos_Click(object sender, EventArgs e)
        {
            video.Show();
            page.Hide();
            book.Hide();
            game.Hide();
            favs.Hide();
            this.Controls.Add(video);
        }

        private void books_Click(object sender, EventArgs e)
        {
            page.Hide();
            video.Hide();
            book.Show();
            game.Hide();
            favs.Hide();
            this.Controls.Add(book);
        }

        private void games_Click(object sender, EventArgs e)
        {
            page.Hide();
            video.Hide();
            book.Hide();
            game.Show();
            favs.Hide();
            this.Controls.Add(game);
        }

        private void fav_Click(object sender, EventArgs e)
        {
            page.Hide();
            video.Hide();
            book.Hide();
            game.Hide();
            favs.Show();
            this.Controls.Add(favs);
        }

        private void add_Click(object sender, EventArgs e)
        {
            var form1 = new Add_Edit();
            form1.Show();
        }
    }
}
