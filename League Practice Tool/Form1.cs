using LCUSharp;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace League_Practice_Tool
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Initialize a connection to the league client.
            var api = await LeagueClientApi.ConnectAsync();



            // Update the current summoner's profile icon to 23.
            string request = @"{
	        customGameLobby: {
		        configuration: {
			        gameMode: 'PRACTICETOOL',
			        gameMutator: '',
			        mapId: 11,
			        mutators: {
				        id: 1
			        },
			        spectatorPolicy: 'NotAllowed',
			        teamSize: 5
		        },
		        lobbyName: 'Practice Tool',
		        lobbyPassword: null
	        },
	        isCustom: true
            }";
            JObject body = JObject.Parse(request);
            var queryParameters = Enumerable.Empty<string>();
            try
            {
                await api.RequestHandler.GetJsonResponseAsync(HttpMethod.Post, "/lol-lobby/v2/lobby",
                                                                         queryParameters, body);
                string messageBoxText = "A lobby has been created";
                string caption = "INFO";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Information;
                System.Windows.MessageBox.Show(messageBoxText, caption, button, icon);
            }
            catch (Exception)
            {
                string messageBoxText = "There was an error";
                string caption = "ERROR";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                System.Windows.MessageBox.Show(messageBoxText, caption, button, icon);
                System.Windows.Forms.Application.Exit();
            }
       


        }
    }
}
