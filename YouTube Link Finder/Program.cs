using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTube_Link_Finder
{
    class Program
    {
        static string getUrlFromNotConvertedLink(string link)
        {
            int myIndex = link.IndexOf('=');
            string urlOfVideo = "";

            for (int i = myIndex + 1; i < link.Length; i++)
            {
                urlOfVideo += link[i];
            }

            return urlOfVideo;
        }

        static string getUrlFromConvertedLink(string link)
        {
            int myIndex = link.IndexOf('e');
            string urlOfVideo = "";

            for (int i = myIndex + 2; i < link.Length; i++)
            {
                urlOfVideo += link[i];
            }

            return urlOfVideo;
        }
        static void Main(string[] args)
        {
            string youtubeLink = "https://www.youtube/watch?v=Fjduhr165";
            bool linkIsConverted = false;
            bool isYoutubeLink = false;

            if (youtubeLink.Contains("youtu"))
            {
                isYoutubeLink = true;

                if (youtubeLink.Contains("/watch?v="))
                {
                    linkIsConverted = false;
                }
                else
                {
                    linkIsConverted = true;
                }
            }
            else
            {
                Console.WriteLine("Это не ютуб ссылка");
            }

            if ((linkIsConverted == true) && (isYoutubeLink == true))
            {
                string myResult = getUrlFromConvertedLink(youtubeLink);
                Console.WriteLine(myResult);
            }
            else if ((linkIsConverted == false) && (isYoutubeLink == true))
            {
                string myResult = getUrlFromNotConvertedLink(youtubeLink);
                Console.WriteLine(myResult);
            }
        }
    }
}
