static public class HTMLParser
{
    public static MyHashMap<string, int> Parse(string[] rows)
    {
        MyHashMap<string, int> hashMap = new MyHashMap<string, int>();

        foreach (string row in rows)
        {
            foreach (string element in row.Split('<'))
            {
                if (element.IndexOf('>', 0) != -1)
                {
                    string tag = element.ToLower().Substring(0, element.IndexOf('>', 0)).Replace("/", "");
                    int kolvo = 1;
                    if (hashMap.ContainsKey(tag))
                        kolvo+=hashMap.Get(tag);
                    hashMap.Put(tag, kolvo);
                }
            }
        }

        return hashMap;
    }
}