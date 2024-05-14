public class SelectCharBtn1 : SelectChar
{
    public override void Select()
    {
        DataManager.instance.SettingPlayerChar(player1);
    }
    public override void Update()
    {
        if(DataManager.instance.PlayerChar == player1)
        {

        }
    }
}
