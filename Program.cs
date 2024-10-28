namespace konsolowa
{
    public class MusicAlbum
    {
        public string artist;
        public string album;
        public int songsNumber;
        public string year;
        public int downloadNumber;

        public MusicAlbum()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static List<MusicAlbum> GetMusicAlbums()
        {
            var list = new List<MusicAlbum>();
            string path = "../../../Data.txt";

            StreamReader sr = new StreamReader(path);

            while(sr.ReadLine() != null)
            {
                string artist = sr.ReadLine() ?? "";
                string album = sr.ReadLine() ?? "";
                int songsNumber = Int32.Parse(sr.ReadLine() ?? "0");
                string year = sr.ReadLine() ?? "";
                int downloadNumber = Int32.Parse(sr.ReadLine() ?? "0");
            }
               
        }
    }
}
