using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;

namespace FoxFinder
{
    public partial class Add_Edit : Form
    {
        MongoClient m_Client;
        IMongoDatabase m_Database;
        IMongoCollection<Media> m_Collection;
        public Add_Edit()
        {
            InitializeComponent();
            m_Client = new MongoClient("mongodb+srv://NovaFoxy:Kyuubi99@maincluster.jtr1q.mongodb.net/FoxFinder?retryWrites=true&w=majority");
            m_Database = m_Client.GetDatabase("FoxFinder");
            m_Collection = m_Database.GetCollection<Media>("Media");
        }

        private void save2db_Click(object sender, EventArgs e)
        {
            try
            {
                Media media = new Media();

                media.Media_title = Media_title.Text;
                //media.Media_cover = Media_cover.Text;
                media.Media_description = Media_description.Text;
                media.Media_playable = Media_playable.Text;
                media.Media_type = Media_type.Text;
                media.Media_category = Media_category.Text;

                m_Collection.InsertOne(media);

                MessageBox.Show("New media added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
