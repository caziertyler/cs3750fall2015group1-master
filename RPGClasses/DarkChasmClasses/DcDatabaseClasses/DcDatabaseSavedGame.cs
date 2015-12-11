using System;

namespace DarkChasmDatabase.DcDatabaseClasses
{
    public class DcDatabaseSavedGame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Chapter { get; set; }
        public string CreatedDate { get; set; }
        public string ModifiedDate { get; set; }
        public string Data { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + "\tModified Date: " + ModifiedDate + "\tType: " + Type + "\tData: " + Data;
        }
    }
}
