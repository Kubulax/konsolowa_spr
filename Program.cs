using System.Runtime.ConstrainedExecution;

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
            string path = "../../../Data.txt";
            List<MusicAlbum> albumList = GetMusicAlbums(path);
            DisplayAlbums(albumList);
        }

        /**********************************************
        nazwa funkcji: GetMusicAlbums
        opis funkcji: Funkcja czyta dane albumów z określonego podaną jako parametr funkcji ścieżką, tworzy z nich obiekt klasy MusicAlbum, dodaje do listy a nastęmnie ją zwraca.
        parametry: string path: parametr określający ścieżkę, pod którą znajduje się plik z danymi albumów muzycznych.
        ...
        zwracany typ i opis: List<MusicAlbum> - lista obiektów klasy MusicAlbum odczytanych z pliku (lista albumów muzycznych).
        autor: PESEL
        ***********************************************/
        public static List<MusicAlbum> GetMusicAlbums(string path)
        {
            List<MusicAlbum> list = new List<MusicAlbum>();

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
