using MetroFramework.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;
using System.IO.Compression;
using System.Diagnostics;

namespace updater
{
    public partial class ULauncher : MetroFramework.Forms.MetroForm
    {
        public ULauncher()
        {
            InitializeComponent();
            //this.StyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            memText.Text = "6144";
            JavaPatchText.Text = "javaw.exe";
            heightText.Text = "530";
            widthText.Text = "925";
            if (!System.IO.Directory.Exists(@".\versions"))
            {
                installclient();
                //Если Клиента нету установка
            }
            else
            {
                this.text2.Text = "Java Found! version : " + GetJavaVersionInformation();
                //Если клиент есть надо проверить сборку модов
                if (System.IO.Directory.Exists(@".\mods"))
                {
                    //Если есть папка Mods проверяем сброку на версию
                    StreamReader sr = new StreamReader(@".\mods\version.data");
                    string version = sr.ReadToEnd();
                    sr.Close();

                    WebClient ver_http = new WebClient();
                    var reader_http = ver_http.OpenRead("http://85.141.186.72:64000/version.data");
                    StreamReader sr_http = new StreamReader(reader_http);
                    string version_site = sr_http.ReadToEnd();

                    if (version != version_site)
                    {
                        //Directory.Delete(@".\mods", true);
                        //Directory.CreateDirectory(@".\mods");
                        System.IO.File.Delete(@".\mods\version.data");
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedU);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChangedU);
                        webClient.DownloadFileAsync(new Uri("http://85.141.186.72:64000/kmods.zip"), @".\update.zip");

                    }
                    else
                    {
                        //Запуск Игру и тд
                        this.launch.Visible = true;
                        this.nick.Visible = true;
                        this.metroProgressSpinner1.Visible = false;
                        this.text1.Text = "Minecraft Hi - Tech Ready";
                        this.text2.Visible = false;
                        this.pictureBox2.Visible = true;
                        this.metroTabControl1.Visible = true;

                        if (File.Exists(@".\config\udata.data"))
                        {
                            StreamReader srs = new StreamReader(@".\config\udata.data");
                            string namen = srs.ReadToEnd();
                            this.nick.Text = namen;
                            srs.Close();
                        }
                        else
                        {
                            System.IO.File.WriteAllText(@".\config\udata.data", "Введите Ник!");
                            this.nick.Text = "Введите Ник!";
                        }
                    }

                }
                else
                {
                    //Если папка Mods не обнаружена
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedU);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChangedU);
                    webClient.DownloadFileAsync(new Uri("http://85.141.186.72:64000/mods.zip"), @".\update.zip");
                }
            }

                //Environment.Exit(0);
        }
        
        private void ProgressChangedU(object sender, DownloadProgressChangedEventArgs e)
        {
            this.metroProgressSpinner1.Value = e.ProgressPercentage;
            this.text1.Text = "Downloading file: update.zip - " + e.ProgressPercentage + "% ";
        }

        private void CompletedU(object sender, AsyncCompletedEventArgs e)
        {
            this.text1.Text = "Download completed!";
            unpackU();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void unpackU()
        {
            ZipFile.ExtractToDirectory(@".\update.zip", @".\mods");
            System.IO.File.Delete(@".\update.zip");
            Application.Restart();
        }

        static string GetJavaVersionInformation()
        {
            try
            {
                System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("java", "-version ");

                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.RedirectStandardError = true;
                procStartInfo.UseShellExecute = false;
                procStartInfo.CreateNoWindow = true;
                System.Diagnostics.Process proc = new Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                return proc.StandardError.ReadToEnd();

            }
            catch (Exception objException)
            {
                return null;
            }
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //System.IO.File.Delete(@".\update.zip");
        }

        private void installclient()
        {
            if (GetJavaVersionInformation() == null)
            {
                MessageBox.Show(
                    "На вашем компьюетер не обнаружена Java.\n" +
                    "Установите Java (Рекомендуется 64-bit)",
                    "Вниманиe",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                Environment.Exit(0);
            }
            this.text2.Text = "Java Found! version : " + GetJavaVersionInformation();

            DialogResult result = MessageBox.Show(
            "После нажатия ОК будет установка клиента!\n" +
            "Вы уверены что хотите установить клиент в этой папке?\n"+
            "После уставновки клиент будет весить ~<1GB. \n" +
            "Проверьте нет ли кирилицы в путе к лаунчеру!",
            "Вниманиe!",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                //Установка Клиента
                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedC);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChangedC);
                webClient.DownloadFileAsync(new Uri("http://85.141.186.72:64000/client.zip"), @".\client.zip");
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void ProgressChangedC(object sender, DownloadProgressChangedEventArgs e)
        {
            this.metroProgressSpinner1.Value = e.ProgressPercentage;
            this.text1.Text = "Downloading file: client.zip - " + e.ProgressPercentage + "% ";
        }

        private void CompletedC(object sender, AsyncCompletedEventArgs e)
        {
            this.text1.Text = "Download completed!";
            unpackC();
        }

        private void unpackC()
        {
            ZipFile.ExtractToDirectory(@".\client.zip", @".\");
            System.IO.File.Delete(@".\client.zip");
            Application.Restart();
        }

        void launchMinecraft()
        {
        }

        private void launch_Click(object sender, EventArgs e)
        {
            if(this.nick.Text != "Введите Ник!"){
                string CurrentPath = System.IO.Directory.GetCurrentDirectory();
                string Mem = memText.Text;
                string PathJava = JavaPatchText.Text;
                string height = heightText.Text;
                string width = widthText.Text;
                string name = nick.Text;
                Guid GUID = Guid.NewGuid();
                ProcessStartInfo Minecraft = new ProcessStartInfo(PathJava,
                " -d64 -XX:+UnlockExperimentalVMOptions -XX:+UseG1GC -XX:G1NewSizePercent=20 -XX:G1ReservePercent=20 -XX:MaxGCPauseMillis=50 -XX:G1HeapRegionSize=32M -XX:ConcGCThreads=3 -XX:ParallelGCThreads=12" +
                " -Xmx"+Mem+"M -Dfile.encoding=UTF-8 -Dfml.ignoreInvalidMinecraftCertificates=true -Dfml.ignorePatchDiscrepancies=true -Djava.net.useSystemProxies=true -XX:HeapDumpPath=MojangTricksIntelDriversForPerformance_javaw.exe_minecraft.exe.heapdump \"-Dos.name=Windows 10\" -Dos.version=10.0" +
                " \"-Djava.library.path=" + CurrentPath + "\\versions\\ForgeOptiFine1.12.2\\natives\" -Dminecraft.launcher.brand=java-minecraft-launcher -Dminecraft.launcher.version=1.6.84-j \"-Dminecraft.client.jar=" + CurrentPath + "\\versions\\ForgeOptiFine1.12.2\\ForgeOptiFine1.12.2.jar\"" +
                " -cp \"" + CurrentPath + "\\libraries\\net\\minecraftforge\\forge\\1.12.2-14.23.5.2854\\forge-1.12.2-14.23.5.2854.jar;" +
                       CurrentPath + "\\libraries\\org\\ow2\\asm\\asm-debug-all\\5.2\\asm-debug-all-5.2.jar;" +
                       CurrentPath + "\\libraries\\net\\minecraftforge\\forge\\1.12.2-14.23.5.2854\\forge-1.12.2-14.23.5.2854.jar;" +
                       CurrentPath + "\\libraries\\org\\ow2\\asm\\asm-debug-all\\5.2\\asm-debug-all-5.2.jar;" +
                       CurrentPath + "\\libraries\\net\\minecraft\\launchwrapper\\1.12\\launchwrapper-1.12.jar;" +
                       CurrentPath + "\\libraries\\org\\jline\\jline\\3.5.1\\jline-3.5.1.jar;" +
                       CurrentPath + "\\libraries\\com\\typesafe\\akka\\akka-actor_2.11\\2.3.3\\akka-actor_2.11-2.3.3.jar;" +
                       CurrentPath + "\\libraries\\com\\typesafe\\config\\1.2.1\\config-1.2.1.jar;" +
                       CurrentPath + "\\libraries\\org\\scala-lang\\scala-actors-migration_2.11\\1.1.0\\scala-actors-migration_2.11-1.1.0.jar;" +
                       CurrentPath + "\\libraries\\org\\scala-lang\\scala-compiler\\2.11.1\\scala-compiler-2.11.1.jar;" +
                       CurrentPath + "\\libraries\\org\\scala-lang\\plugins\\scala-continuations-library_2.11\\1.0.2_mc\\scala-continuations-library_2.11-1.0.2_mc.jar;" +
                       CurrentPath + "\\libraries\\org\\scala-lang\\plugins\\scala-continuations-plugin_2.11.1\\1.0.2_mc\\scala-continuations-plugin_2.11.1-1.0.2_mc.jar;" +
                       CurrentPath + "\\libraries\\org\\scala-lang\\scala-library\\2.11.1\\scala-library-2.11.1.jar;" +
                       CurrentPath + "\\libraries\\org\\scala-lang\\scala-parser-combinators_2.11\\1.0.1\\scala-parser-combinators_2.11-1.0.1.jar;" +
                       CurrentPath + "\\libraries\\org\\scala-lang\\scala-reflect\\2.11.1\\scala-reflect-2.11.1.jar;" +
                       CurrentPath + "\\libraries\\org\\scala-lang\\scala-swing_2.11\\1.0.1\\scala-swing_2.11-1.0.1.jar;" +
                       CurrentPath + "\\libraries\\org\\scala-lang\\scala-xml_2.11\\1.0.2\\scala-xml_2.11-1.0.2.jar;" +
                       CurrentPath + "\\libraries\\lzma\\lzma\\0.0.1\\lzma-0.0.1.jar;" +
                       CurrentPath + "\\libraries\\java3d\\vecmath\\1.5.2\\vecmath-1.5.2.jar;" +
                       CurrentPath + "\\libraries\\net\\sf\\trove4j\\trove4j\\3.0.3\\trove4j-3.0.3.jar;" +
                       CurrentPath + "\\libraries\\org\\apache\\maven\\maven-artifact\\3.5.3\\maven-artifact-3.5.3.jar;" +
                       CurrentPath + "\\libraries\\net\\sf\\jopt-simple\\jopt-simple\\5.0.3\\jopt-simple-5.0.3.jar;" +
                       CurrentPath + "\\libraries\\oshi-project\\oshi-core\\1.1\\oshi-core-1.1.jar;" +
                       CurrentPath + "\\libraries\\net\\java\\dev\\jna\\jna\\4.4.0\\jna-4.4.0.jar;" +
                       CurrentPath + "\\libraries\\net\\java\\dev\\jna\\platform\\3.4.0\\platform-3.4.0.jar;" +
                       CurrentPath + "\\libraries\\com\\ibm\\icu\\icu4j-core-mojang\\51.2\\icu4j-core-mojang-51.2.jar;" +
                       CurrentPath + "\\libraries\\com\\paulscode\\codecjorbis\\20101023\\codecjorbis-20101023.jar;" +
                       CurrentPath + "\\libraries\\com\\paulscode\\codecwav\\20101023\\codecwav-20101023.jar;" +
                       CurrentPath + "\\libraries\\com\\paulscode\\libraryjavasound\\20101123\\libraryjavasound-20101123.jar;" +
                       CurrentPath + "\\libraries\\com\\paulscode\\librarylwjglopenal\\20100824\\librarylwjglopenal-20100824.jar;" +
                       CurrentPath + "\\libraries\\com\\paulscode\\soundsystem\\20120107\\soundsystem-20120107.jar;" +
                       CurrentPath + "\\libraries\\io\\netty\\netty-all\\4.1.9.Final\\netty-all-4.1.9.Final.jar;" +
                       CurrentPath + "\\libraries\\com\\google\\guava\\guava\\21.0\\guava-21.0.jar;" +
                       CurrentPath + "\\libraries\\org\\apache\\commons\\commons-lang3\\3.5\\commons-lang3-3.5.jar;" +
                       CurrentPath + "\\libraries\\commons-io\\commons-io\\2.5\\commons-io-2.5.jar;" +
                       CurrentPath + "\\libraries\\commons-codec\\commons-codec\\1.10\\commons-codec-1.10.jar;" +
                       CurrentPath + "\\libraries\\net\\java\\jinput\\jinput\\2.0.5\\jinput-2.0.5.jar;" +
                       CurrentPath + "\\libraries\\net\\java\\jutils\\jutils\\1.0.0\\jutils-1.0.0.jar;" +
                       CurrentPath + "\\libraries\\com\\google\\code\\gson\\gson\\2.8.0\\gson-2.8.0.jar;" +
                       CurrentPath + "\\libraries\\com\\mojang\\realms\\1.10.22\\realms-1.10.22.jar;" +
                       CurrentPath + "\\libraries\\org\\apache\\commons\\commons-compress\\1.8.1\\commons-compress-1.8.1.jar;" +
                       CurrentPath + "\\libraries\\org\\apache\\httpcomponents\\httpclient\\4.3.3\\httpclient-4.3.3.jar;" +
                       CurrentPath + "\\libraries\\commons-logging\\commons-logging\\1.1.3\\commons-logging-1.1.3.jar;" +
                       CurrentPath + "\\libraries\\org\\apache\\httpcomponents\\httpcore\\4.3.2\\httpcore-4.3.2.jar;" +
                       CurrentPath + "\\libraries\\it\\unimi\\dsi\\fastutil\\7.1.0\\fastutil-7.1.0.jar;" +
                       CurrentPath + "\\libraries\\org\\apache\\logging\\log4j\\log4j-api\\2.8.1\\log4j-api-2.8.1.jar;" +
                       CurrentPath + "\\libraries\\org\\apache\\logging\\log4j\\log4j-core\\2.8.1\\log4j-core-2.8.1.jar;" +
                       CurrentPath + "\\libraries\\org\\lwjgl\\lwjgl\\lwjgl\\2.9.4-nightly-20150209\\lwjgl-2.9.4-nightly-20150209.jar;" +
                       CurrentPath + "\\libraries\\org\\lwjgl\\lwjgl\\lwjgl_util\\2.9.4-nightly-20150209\\lwjgl_util-2.9.4-nightly-20150209.jar;" +
                       CurrentPath + "\\libraries\\com\\mojang\\text2speech\\1.10.3\\text2speech-1.10.3.jar;" +
                       CurrentPath + "\\libraries\\by\\ely\\authlib\\1.5.25.8\\authlib-1.5.25.8.jar;" +
                       CurrentPath + "\\versions\\ForgeOptiFine1.12.2\\ForgeOptiFine1.12.2.jar\" net.minecraft.launchwrapper.Launch " +
                  "--username "+name+" --version \"UMinecraft 1.12.2\" --gameDir " + CurrentPath + " --assetsDir " + CurrentPath + "\\assets --assetIndex 1.12 " +
                  "--uuid " + GUID + "  --accessToken 9495jks3k5ksiew15243 --userType legacy --tweakClass net.minecraftforge.fml.common.launcher.FMLTweaker " +
                  "--versionType Forge --width "+width+" --height "+height+""
                       );
                Process.Start(Minecraft);
                if (File.Exists(@"\config\udata.data") == false)
                {
                    System.IO.File.WriteAllText(@".\config\udata.data", this.nick.Text);
                }
                Environment.Exit(0);
            }
        }

        private void memText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void widthText_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void text2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {//Переустановка Модов

            DialogResult result = MessageBox.Show(
            "После нажатия ОК будет удаленна текущая папка mods!\n" +
            "Вы уверены что хотите переустановить Mod-Pack?",
            "Вниманиe!",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                this.metroProgressSpinner1.Visible = true;
                this.text1.Visible = true;
                this.text2.Visible = true;
                this.metroTabControl1.Visible = false;
                Directory.Delete(@".\mods", true);
                Directory.CreateDirectory(@".\mods");

                //Установка Модов
                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedU);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChangedU);
                webClient.DownloadFileAsync(new Uri("http://85.141.186.72:64000/mods.zip"), @".\update.zip");
            }
            else
            {
               
            }

        }
    }
}
