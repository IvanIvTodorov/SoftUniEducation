namespace MusicHub
{
    using System;
    using System.Linq;
    using System.Text;
    using Data;
    using Initializer;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            MusicHubDbContext context = 
                new MusicHubDbContext();

            DbInitializer.ResetDatabase(context);

            Console.WriteLine(ExportSongsAboveDuration(context, 4));
        }

        public static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
        {
            StringBuilder sb = new StringBuilder();

            var albums = context.Albums
                .Where(a => a.ProducerId == producerId)
                .Select(a => new
                {
                    a.Name,
                    ReleaseDate = a.ReleaseDate.ToString("MM/dd/yyyy"),
                    ProducerName = a.Producer.Name,
                    TotalPrice = a.Price,
                    AlbumSongs = a.Songs.Select(s => new
                    {
                        s.Name,
                        Price = $"{s.Price:F2}",
                        WriterName = s.Writer.Name

                    })
                    .OrderByDescending(s => s.Name)
                    .ThenBy(s => s.WriterName)
                    .ToList()
                })
                .ToList()
                .OrderByDescending(a => a.TotalPrice);

            
            foreach (var item in albums)
            {
                
                sb.AppendLine($"-AlbumName: {item.Name}");
                sb.AppendLine($"-ReleaseDate: {item.ReleaseDate}");
                sb.AppendLine($"-ProducerName: {item.ProducerName}");
                sb.AppendLine($"-Songs:");

                var num = 0;
                foreach (var i in item.AlbumSongs)
                {
                    num++;
                    sb.AppendLine($"---#{num}");
                    sb.AppendLine($"---SongName: {i.Name}");
                    sb.AppendLine($"---Price: {i.Price}");
                    sb.AppendLine($"---Writer: {i.WriterName}");
                }

                sb.AppendLine($"-AlbumPrice: {item.TotalPrice:F2}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
        {
            StringBuilder sb = new StringBuilder();

            var songs = context.Songs
                .Select(s => new
                {
                    s.Name,
                    PerformerName = s.SongPerformers.Select(sp => sp.Performer.FirstName + " " + sp.Performer.LastName).FirstOrDefault(),
                    WriterName = s.Writer.Name,
                    ProducerName = s.Album.Producer.Name,
                    s.Duration
                })
                .OrderBy(s => s.Name)
                .ThenBy(s => s.WriterName)
                .ThenBy(s => s.PerformerName)
                .ToList()
                .Where(s => s.Duration.TotalSeconds > duration)
                .ToList();

            var i = 1;
            foreach (var item in songs)
            {
                sb.AppendLine($"-Song #{i}");
                sb.AppendLine($"---SongName: {item.Name}");
                sb.AppendLine($"---Writer: {item.WriterName}");
                sb.AppendLine($"---Performer: {item.PerformerName}");
                sb.AppendLine($"---AlbumProducer: {item.ProducerName}");
                sb.AppendLine($"---Duration: {item.Duration.ToString("c")}");

                i++;
            }

            return sb.ToString().TrimEnd();
        }
    }
}
