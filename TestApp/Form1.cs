using System;
using System.IO;
using System.Windows.Forms;
using iiInfinityEngine.Core;
using iiInfinityEngine.Core.Files;
using iiInfinityEngine.Core.Readers;
using iiInfinityEngine.Core.Writers;

namespace iiInfinityEngine.Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var languageFile = @"D:\MyMod\Languages\English\Main.tra";

                // Load all the resources in a game (excluding the override directory)
                Game game = new Game(@"F:\GOG Games\Icewind Dale 2");
                game.backupManager = new BackupManager(@"D:\Games\ie\bg2\main\mod_backup");
                game.LoadResources(IEFileType.Itm);

                
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }
    }
}