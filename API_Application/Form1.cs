using MingweiSamuel.Camille;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MatchV4Window v4 = new MatchV4Window();
            v4.ShowDialog();
            HttpClient clint = new HttpClient();
            clint.BaseAddress = new Uri("https://na1.api.riotgames.com/lol/summoner/v4/summoners");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void apiBox_TextChanged(object sender, EventArgs e)
        {
            var riotApi = RiotApi.NewInstance("");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //using ( addApi = new AddApi())
            //{
            //    if (addApi.ShowDialog() == DialogResult.OK)
            //    {
            //        API api = new API { Name = addAPI.ApiName };
            //        mViewModel.Api.Add(api);
            //    }
            //}
        } 
    }
}
