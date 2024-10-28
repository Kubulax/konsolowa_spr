namespace konsolowa
{
    public class MusicAlbum
    {
        public string artist;
        public string album;
        public int songsNumber;
        public string year;
        public int downloadNumber;

        public MusicAlbum (string artist, string album, int songsNumber, string year, int downloadNumber)
        {
            this.artist = artist;
            this.album = album;
            this.songsNumber = songsNumber;
            this.year = year;
            this.downloadNumber = downloadNumber;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<MusicAlbum> albumList = GetMusicAlbums();
            DisplayAlbums(albumList);
        }

        public static List<MusicAlbum> GetMusicAlbums()
        {
            List<MusicAlbum> list = new List<MusicAlbum>();
            string path = "../../../Data.txt";

            StreamReader sr = new StreamReader(path);

            while(!sr.EndOfStream)
            {
                string artist = sr.ReadLine() ?? "";
                string album = sr.ReadLine() ?? "";
                int songsNumber = int.Parse(sr.ReadLine() ?? "0");
                string year = sr.ReadLine() ?? "";
                int downloadNumber = int.Parse(sr.ReadLine() ?? "0");
                sr.ReadLine();

                MusicAlbum musicAlbum = new MusicAlbum(artist, album, songsNumber, year, downloadNumber);
                list.Add(musicAlbum);
            }
            
            return list;
        }

        public static void DisplayAlbums(List<MusicAlbum> albumList)
        {
            foreach (MusicAlbum album in albumList)
            {
                Console.WriteLine(album.artist);
                Console.WriteLine(album.album);
                Console.WriteLine(album.songsNumber);
                Console.WriteLine(album.year);
                Console.WriteLine(album.downloadNumber);
                Console.WriteLine("");
            }
        }
    }
}
