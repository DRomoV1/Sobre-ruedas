using Newtonsoft.Json.Linq;
using UnityEngine;
[CreateAssetMenu(menuName = "ScriptableObjects/CurrentsCoins")]

public class CurrentsCoins : Data
{
    public int currentsCoins;
    public int totalCoins;

    public override void DeSerialize(string jsonString)
    {
        SaveData sd = JsonUtility.FromJson<SaveData>(jsonString);
        totalCoins = sd.totalCoins;
    }

    public override JObject Serialize()
    {
        SaveData sd = new SaveData(totalCoins);
        string jsonString = JsonUtility.ToJson(sd);
        JObject retVal = JObject.Parse(jsonString);
        return retVal;
    }
    private class SaveData
    {
        public int totalCoins;

        public SaveData(int totalCoins)
        {
            this.totalCoins = totalCoins;
        }
    }

}
