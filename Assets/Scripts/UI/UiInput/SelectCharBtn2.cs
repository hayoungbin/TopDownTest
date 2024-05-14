public class SelectCharBtn2 : SelectChar
{
    public override void Select()
    {
        DataManager.instance.SettingPlayerChar(player2);
    }
    public override void Update()
    {
        if (DataManager.instance.PlayerChar == player2)
        {
            
        }
    }
}
