using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoxFinder
{
    public partial class MainPage : UserControl
    {
        MongoClient m_Client;
        IMongoDatabase m_Database;
        IMongoCollection<Media> m_Collection;
        
        public MainPage()
        {
            InitializeComponent();
            m_Client = new MongoClient("mongodb+srv://NovaFoxy:Kyuubi99@maincluster.jtr1q.mongodb.net/FoxFinder?retryWrites=true&w=majority");
            m_Database = m_Client.GetDatabase("FoxFinder");
            m_Collection = m_Database.GetCollection<Media>("Media");
        }
        //Refresh Button, This asks to MongoDB get colletion (Name from Collection) <Media> (Find data [place => x.Name record == "Name") Show value First(We need show all value here)
        private void refresh_Click(object sender, EventArgs e)
        {
            try
            {
                var ding = m_Database.GetCollection<Media>("Media").FindSync(x => x.Media_type == "Game").FirstOrDefault();
                MessageBox.Show(ding.Media_title, ding.Media_playable);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Yo");
            }
        }

    }
}
