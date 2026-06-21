namespace NotificationMaster;

[Serializable]
internal class HttpRequestElement
{
    // porting-note: upstream renamed this field `type` -> `Type` for the HttpMaster feature.
    public int Type = 0;
    public string URI = "";
    public string Content = "";
}
