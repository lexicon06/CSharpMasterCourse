void CreateIfMissing(string path)
{
    bool folderExists = Directory.Exists(path);
    if (!folderExists)
    {
        Directory.CreateDirectory(path);
    }
}


for (int id = 1; id <= 47; id++)
{
    string url = $"http://aresbook.com/ib0t/emotes/{id}.png";
    CreateIfMissing("./emotes/");
    string fileName = $"./emotes/{id}.png";


    using (HttpClient client = new HttpClient())
    {
        using (HttpResponseMessage response = await client.GetAsync(url))
        {
            using (Stream stream = await response.Content.ReadAsStreamAsync())
            {
                using (FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    await stream.CopyToAsync(fileStream);
                }
            }
        }
    }
}
