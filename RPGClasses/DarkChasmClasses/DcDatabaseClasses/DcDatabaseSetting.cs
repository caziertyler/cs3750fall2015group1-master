namespace DarkChasmDatabase.DcDatabaseClasses
{
    public class DcDatabaseSetting
    {
        public int Id { get; set; }
        public int GamesaveId { get; set; }
        public string SettingName { get; set; }
        public int SettingValue { get; set; }
        public override string ToString()
        {
            return "Id " + Id + "GamesaveId " + GamesaveId + "SettingName " + SettingName + "SettingValue " + SettingValue;
        }
    }
}
