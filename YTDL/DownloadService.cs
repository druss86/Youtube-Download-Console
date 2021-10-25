using System;
using System.Diagnostics;
using System.IO;

namespace YTDL
{
    public class DownloadService
    {
        public static void MainMenu()
        {
            //Get the initial user request - either Audio or Video
            Console.Write(
                "|| Main Menu ||\n\n" +
                "Choose from the following:\n" +
                "1) Audio\n" +
                "2) Video\n" +
                "/) View/Change Output Directory\n" +
                "') Exit (Apostrophe)\n");

            var menuInput = Console.ReadLine();

            switch (menuInput)
            {
                case MainMenuOptions.AUDIO:
                    //ExecuteAudioRequest();
                    break;
                case MainMenuOptions.VIDEO:
                    //GetVideoRequest();
                    break;
                case MainMenuOptions.CHANGE_DIRECTORY:
                    //ChangeOutputDirectory();
                    MainMenu();
                    break;
                case MainMenuOptions.EXIT:
                    Environment.Exit(0);
                    break;
            }
        }

        public static string GetOutputDirectory()
        {
            //TODO
        }

        public static void ChangeOutputDirectory()
        {
            //TODO
        }

        /* Creates the youtube request (changes directory first) and executes with cmd.exe
         * @params@ 
         * @directory         = "/c cd c:/ExampleDirectory &"
         * @AUDIO_MP3_REQUEST = "youtube-dl --extract-audio --audio-format mp3 <video URL>"
         * @youtubeUrl        = user input youtube URL.
         */
        public static void ExecuteAudioRequest()
        {
           //TODO
        }

        //See ExecuteAudioRequest comments for how this works.
        public static void GetVideoRequest()
        {
            //TODO
        }

       public static void ExecuteDownloadRequest(string youtubeUrl, string mediaOutputDirectory, string mediaRequestType)
        {
            //TODO
        }


        //Small method to check if a user input is a valid Youtube Url, returns to main menu if not.
        public static void IsValidYoutubeUrl(string youtubeUrl)
        {
            //TODO
        }
    }
}
