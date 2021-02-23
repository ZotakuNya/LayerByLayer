[System.Serializable]
public class SaveData
{
    private string _username;
    private string _passwd;

    public string Username
    {
        get => _username;
        set => _username = value;
    }

    public string Passwd
    {
        get => _passwd;
        set => _passwd = value;
    }
}
