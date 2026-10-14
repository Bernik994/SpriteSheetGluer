namespace SpriteSheetGluer
//Jeśli ktoś to będzie kiedyś czytał to niech wie, że poniższy kod był robiony na odpierdol, byle by działało. 
//Pół jest moje, pół wygenerowane przez ChataGPT. Pomysł jak to ma działać jest za to w 100% mój.
//Pozdrawiam Berniusz
{
    public partial class Form1 : Form
    {
        private int SpriteX;
        private int SpriteY;
        private int liczbaWier;
        private int liczbaKol;
        public Form1()
        {
            InitializeComponent();

            NumY.Minimum = 1;
            NumY.Maximum = 1000;

            NumX.Minimum = 1;
            NumX.Maximum = 1000;

            NumPoz.Minimum = 1;
            NumPoz.Maximum = 1000;

            NumKol.Minimum = 1;
            NumKol.Maximum = 1000;

        }


        private void FolderGen_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string mainPath = Path.Combine(desktopPath, "SpriteSheetGluer");
            string spritesPath = Path.Combine(mainPath, "Sprites");
            string GluerPath = Path.Combine(mainPath, "Sklejone");

            liczbaKol = (int)NumKol.Value;

            Directory.CreateDirectory(GluerPath);
            for (int i = 1; i <= liczbaKol; i++)
            {
                Directory.CreateDirectory(Path.Combine(spritesPath, "Kolumna" + i));
            }
        }

        private void sklej1_Click(object sender, EventArgs e)
        {
            SpriteX = (int)NumX.Value;
            SpriteY = (int)NumY.Value;
            liczbaWier = (int)NumPoz.Value;
            liczbaKol = (int)NumKol.Value;

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string spritesPath = Path.Combine(desktopPath, "SpriteSheetGluer", "Sprites");
            string outputPath = Path.Combine(desktopPath, "SpriteSheetGluer", "Sklejone", "arkusz.png");

            Bitmap arkusz = new Bitmap(liczbaWier * SpriteX, liczbaKol * SpriteY);

            using (Graphics g = Graphics.FromImage(arkusz))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                for (int k = 1; k <= liczbaKol; k++)
                {
                    string colFolder = Path.Combine(spritesPath, "Kolumna" + k);
                    if (!Directory.Exists(colFolder)) continue;

                    string[] files = Directory.GetFiles(colFolder, "*.png").OrderBy(f => f).ToArray();

                    for (int w = 0; w < Math.Min(files.Length, liczbaWier); w++)
                    {
                        using (Image sprite = Image.FromFile(files[w]))
                        {
                            // Rysujemy sprite'a na odpowiedniej pozycji:
                            // X = (numer kolumny - 1) * szerokość
                            // Y = numer wiersza * wysokość
                            g.DrawImage(sprite, w * SpriteX, (k - 1) * SpriteY, SpriteX, SpriteY);
                        }
                    }
                }
            }

            // Zapis i czyszczenie
            arkusz.Save(outputPath, System.Drawing.Imaging.ImageFormat.Png);
            arkusz.Dispose();

            MessageBox.Show("Arkusz został wygenerowany pomyślnie!");
        }

    }
}